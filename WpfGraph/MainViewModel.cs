using Caliburn.Micro;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WpfGraph
{
    public class ViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }

        private PlotModel plotViewModel;
        public PlotModel PlotViewModel
        {
            get => plotViewModel;
            set
            {
                plotViewModel = value;
                OnPropertyChanged("PlotViewModel");
            }
        }
        Task T;

        public ViewModel() // 생성자 생성
        {
            var plotModel1 = new PlotModel();
            var dateTimeAxis1 = new DateTimeAxis();
            plotModel1.Axes.Add(dateTimeAxis1);
            var linearAxis1 = new LinearAxis();
            linearAxis1.Minimum = -1;
            linearAxis1.Maximum = 1;
            plotModel1.Axes.Add(linearAxis1);
            var lineSeries1 = new LineSeries();
            lineSeries1.MarkerType = MarkerType.Circle;
            

            lineSeries1.Points.Add(new DataPoint());


            plotModel1.Series.Add(lineSeries1);

            plotViewModel = plotModel1;
            plotViewModel.InvalidatePlot(true); // 실시간 업데이트 
            
            T = new Task(FunctionA);
            T.Start();
        }
        ~ViewModel()
        {
          
        }

        public void FunctionA()
        {
            DateTime curtime;
            var lineSeries1 = new LineSeries();
            lineSeries1.MarkerType = MarkerType.Circle;
            // List < DataPoint > 는 기본적으로 Plot의 X,Y 값을 갖는다.
            List<DataPoint> lData = new List<DataPoint>();

            DateTime StartDate;
            DateTime EndDate;


            while (true)
            {
                Thread.Sleep(100);
                plotViewModel.Series.Clear();
                lineSeries1.Points.Clear();
                curtime = DateTime.Now;

                // 현재 시간 Datetime -> double 변환
                double dCurtime = curtime.ToOADate();
                double dValue = Math.Sin(50000 * dCurtime);

                if (lData.Count == 0)
                {
                    lData.Add(new DataPoint(dCurtime, dValue));
                }
                else
                {
                    // X 좌표 double -> Datetime 으로 바꿔서 20초 차이를 계산하는 로직 
                    StartDate = DateTime.FromOADate(lData[0].X);
                    EndDate = DateTime.FromOADate(lData[lData.Count - 1].X);
                    double Diff = Math.Abs((StartDate - EndDate).Seconds);

                    if (Diff <= 10)
                    {
                        lData.Add(new DataPoint(dCurtime, dValue));
                    }
                    else
                    {
                        lData.RemoveAt(0);
                        lData.Add(new DataPoint(dCurtime, dValue));
                    }
                }

                foreach (var data in lData)
                {
                    lineSeries1.Points.Add(data);
                }

                plotViewModel.Series.Add(lineSeries1);
                PlotViewModel.InvalidatePlot(true);

            }
        }
    }

}
