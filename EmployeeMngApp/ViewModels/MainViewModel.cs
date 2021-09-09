using Caliburn.Micro;
using EmployeeMngApp.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace EmployeeMngApp.ViewModels
{
    public class MainViewModel : Conductor<object> // Screen // PropertyChangedBase, IHaveDisplayName 모두 포함
    {
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
                NotifyOfPropertyChange(() => CanDelEmployees); //삭제 버튼 활성/ 비활성화
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
                NotifyOfPropertyChange(() => CanSaveEmployees); //저장 버튼 활성/ 비활성화

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
                 NotifyOfPropertyChange(() => CanSaveEmployees); //저장 버튼 활성/ 비활성화
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
                NotifyOfPropertyChange(() => CanSaveEmployees); //저장 버튼 활성/ 비활성화
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

        #region ### 선택된 직원 오른쪽 TextBox에 보여주기 ###
        private Employees selectedEmployee;
        public Employees SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
                
                if(selectedEmployee != null)
                {
                    Id          = value.Id;
                    EmpName     = value.EmpName;
                    Salary      = value.Salary;
                    DeptName    = value.DeptName;
                    Destination = value.Destination;
                   
                    NotifyOfPropertyChange(() => SelectedEmployee);

                }
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
        
        // 1. SELECT 문
        public void GetEmployees()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                string selquery = Models.Employees.SELECT_QUERY;
                SqlCommand cmd = new SqlCommand(selquery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Employees = new BindableCollection<Employees>();

                while (reader.Read())
                {
                    var empTmp = new Employees
                    {
                        Id          = (int)reader["id"],
                        EmpName     = reader["EmpName"].ToString(),
                        Salary      = (decimal)reader["Salary"],
                        DeptName    = reader["DeptName"].ToString(),
                        Destination = reader["Destination"].ToString()
                    };
                    Employees.Add(empTmp);
                }
                conn.Close();
            }
        } 

        // 2. UPDATE 문
        public void SaveEmployees()
        {
            int resultRow = 0; // UPDATE 된 행의 횟수

            // Validation Check
            if (string.IsNullOrEmpty(EmpName) || Salary == 0 || string.IsNullOrEmpty(DeptName))
            {
                MessageBox.Show("입력값에 빈 값이 있습니다.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    var upquery = Models.Employees.UPDATE_QUERY;
                    var inquery = Models.Employees.INSERT_QUERY;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (Id == 0) // insert
                        cmd.CommandText = inquery;
                    else // update
                        cmd.CommandText = upquery;

                    SqlParameter empNameParam = new SqlParameter("empName", EmpName);
                    cmd.Parameters.Add(empNameParam);
                    SqlParameter salaryParam = new SqlParameter("salary", Salary);
                    cmd.Parameters.Add(salaryParam);
                    SqlParameter deptNameParam = new SqlParameter("deptName", DeptName);
                    cmd.Parameters.Add(deptNameParam);
                    SqlParameter destinationParam = new SqlParameter("destination", Destination);
                    cmd.Parameters.Add(destinationParam);

                    if (id != 0)// update일 때만 Id param 사용
                    {
                        SqlParameter idParam = new SqlParameter("id", Id);
                        cmd.Parameters.Add(idParam);
                    }

                    resultRow = cmd.ExecuteNonQuery();

                    if(resultRow > 0 ) // 값을 수정
                    {
                        MessageBox.Show("데이터 저장 성공");
                        GetEmployees();
                    }
                    else
                    {
                        MessageBox.Show("데이터 저장 실패");
                    }
                }
                NewEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
                return;
            }

        }
        // 3. 신규 버튼 클릭 / 저장 이후 입력 컨트롤 비우기
        public void NewEmployees()
        {
            Id = 0;
            Salary = 0;
            EmpName = DeptName = Destination = string.Empty;
        }


        public void DelEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    var delquery = Models.Employees.DELETE_QUERY;
                    
                    SqlCommand cmd = new SqlCommand(delquery, conn);
                    SqlParameter idParam = new SqlParameter("@id", Id);
                    cmd.Parameters.Add(idParam);

                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        GetEmployees();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
                return;
            }
            finally
            {
                NewEmployees();
            }
        }
        public bool CanDelEmployees
        {
            get => Id != 0;
            set
            {

            }
        }
        public bool CanSaveEmployees
        {
            get => !string.IsNullOrEmpty(EmpName) && Salary > 0 && !string.IsNullOrEmpty(DeptName);
            set
            {

            }
        }

        #endregion


    }
}
