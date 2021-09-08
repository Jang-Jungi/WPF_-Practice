using Caliburn.Micro;
using EmployeeMngApp.Models;
using System.Data.SqlClient;

namespace EmployeeMngApp.ViewModels
{
    public class MainViewModel : Conductor<object> // Screen // PropertyChangedBase, IHaveDisplayName 모두 포함
    {
        private readonly string connstr = "Data Source=localhost;Initial Catalog=EMS;Integrated Security=True";
        private BindableCollection<Employees> employees;
        
        #region ### 생성자 생성 ###
        public BindableCollection<Employees> Employees
        {
            get => employees;
            set
            {
                employees = value;
                NotifyOfPropertyChange(() => Employees);
            }
        }
        private int id;
        public int Id
        {
            get => id;
            set
            {
                id = value;
                NotifyOfPropertyChange(() => Id);
            }
        }

        private string empName;
        public string EmpName
        {
            get => empName;
            set
            {
                empName = value;
                NotifyOfPropertyChange(() => EmpName);
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
                NotifyOfPropertyChange(() => Salary);
            }
        }

        private string deptName;
        public string DeptName
        {
            get => deptName;
            set
            {
                deptName = value;
                NotifyOfPropertyChange(() => DeptName);
            }
        }

        private string destination;
        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
                NotifyOfPropertyChange(() => Destination);
            }
        }
        #endregion

        #region ### 선택된 직원 ###
        private Employees selectedEmployee;
        public Employees SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
                //
            }
        }
        #endregion

        #region ### 실행 ###
        public MainViewModel()
        {
            DisplayName = "Employee Management App";
            GetEmployees();
        }
        #endregion

        #region ###DB에 연결###
        private void GetEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string selquery = @"SELECT Id
                                         , EmpName
                                         , Salary
                                         , DeptName
                                         , Destination
                                      FROM Employees";
                SqlCommand cmd = new SqlCommand(selquery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Employees = new BindableCollection<Employees>();

                while (reader.Read())
                {
                    var empTmp = new Employees
                    {
                        Id = (int)reader["id"],
                        EmpName = reader["EmpName"].ToString(),
                        Salary = (decimal)reader["Salary"],
                        DeptName = reader["DeptName"].ToString(),
                        Destination = reader["Destination"].ToString()
                    };
                    Employees.Add(empTmp);
                }
                conn.Close();
            }
        } 
        #endregion
    }
}
