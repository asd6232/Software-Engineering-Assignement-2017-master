using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public sealed class UIManager
    {

        private MainForm mainForm = new MainForm();
        private LoggInScreen myLoggInScreen = new LoggInScreen();
        private Patient_Info_Box patientInfo = new Patient_Info_Box();
        private User activeUser;
        private Patient activePatient;
        private Calendar calendarForm;
        private DataSet ds1 = new DataSet();


        public Patient ActivePatient
        {
            get { return activePatient; }
            set 
            { 
                activePatient = value;
                DataSet ds = UIManager.Instance.getDataSet();
                // patientInfo.PatientGrid.DataSource = ds.Tables[0];
                patientInfo.PatientGrid.AutoGenerateColumns = true;
                patientInfo.PatientGrid.DataSource = ds; // dataset
                patientInfo.PatientGrid.DataMember = "Table"; // table name you need to show
                
            }
        }

        private static readonly UIManager instance = new UIManager();

        static UIManager()
        {
        }

        private UIManager()
        {
        }

        public static UIManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void callLoginScreen()
        {
            myLoggInScreen.FormClosing += Form_FormClosing;
            
            mainForm.Visible = false;
            mainForm.FormClosing += Form_FormClosing;
            Application.Run(myLoggInScreen);   
        }

        internal DataSet ProjectSelectedDateToCalendar(string selectedDate)
        {
            string sql = @"SELECT DISTINCT a.AppointmentTime, s.StaffMemberName, p.PatientName FROM Appointments a INNER JOIN StaffMembers s on a.StaffID = s.Id INNER JOIN Patients p on a.PatientID = p.Id WHERE a.AppointmentDate = '" + selectedDate + "'";
            DataSet ds = DBManager.getDBConnectionInstance().getDataSet(sql);
            return ds;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCancel(e);
        }

        public void swapVisibility()
        {
            if(myLoggInScreen.Visible == true)
            {
                myLoggInScreen.Visible = false;
                mainForm.Visible = true;
            }
            else if(mainForm.Visible == true)
            {
                mainForm.Visible = false;
                myLoggInScreen.Visible = true;
                
            }
        }

        public void swapVisibility2()
        {
            if (mainForm.Visible == true)
            {
                mainForm.Visible = false;
                patientInfo.Visible = true;
            }
            else if (patientInfo.Visible == true)
            {
                patientInfo.Visible = false;
                mainForm.Visible = true;
            }
        }

        public void swapVisibility3()
        {
            if (patientInfo.Visible == true)
            {
                patientInfo.Visible = false;
                mainForm.Visible = true;
            }
            else if (mainForm.Visible == true)
            {
                mainForm.Visible = false;
                patientInfo.Visible = true;

            }
        }

        public void logOffBut_ClickUi(EventArgs e)
        {
            const string message = "Are you sure that you would like to log out?";
            const string caption = "Log Out";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Instance.swapVisibility();
            }
        }

        public void CloseCancel(FormClosingEventArgs e)
        {

                const string message = "Are you sure that you would like to exit?";
                const string caption = "Attention";
                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                myLoggInScreen.FormClosing -= Form_FormClosing;
                mainForm.FormClosing -= Form_FormClosing;
                Application.Exit();
            }
        }

        internal void showCalendar()
        {
            calendarForm = new Calendar();
            calendarForm.ShowDialog();
        }

        internal bool ConfirmSearchPatientClick(string PatientName, string Address, string dateOfBirth)
        {
            string sql = @"SELECT * FROM Patients WHERE PatientName = '" + PatientName + "' AND Address = '" + Address + "' AND dateOfBirth = '" + dateOfBirth + "'";
            DataSet ds = DBManager.getDBConnectionInstance().getDataSet(sql);
            setDataSet(ds);
            if (Utility.CheckFind(ds))
            {
                UIManager.Instance.ActivePatient = new Patient(ds);
                return true;
            }
            else return false;

        }

        internal bool ConfirmSearchPatientClick(string id)
        {
            string sql = @"SELECT Patients.Id, Patients.PatientName, Patients.dateOfBirth, Patients.Address, 
                  PatientsIllnesses.IllnessID, PatientsIllnesses.DateFrom, PatientsIllnesses.DateTo, PatientsMeds.MedId, PatientsMeds.DateFrom AS DateFrom1, 
                  PatientsMeds.DateTo AS DateTo1, PatientsMeds.ExtentionDate  
                  FROM     Patients INNER JOIN
                  PatientsIllnesses ON Patients.Id = PatientsIllnesses.PatientID INNER JOIN
                  PatientsMeds ON Patients.Id = PatientsMeds.PatientID WHERE Id = '" + id + "'";
            DataSet ds = DBManager.getDBConnectionInstance().getDataSet(sql);
            setDataSet(ds);
            if (Utility.CheckFind(ds))
            {
                UIManager.Instance.ActivePatient = new Patient(ds);
                return true;
            }
            else return false;

        }

        internal bool Delete_Click(string id)
        {
                string sql = @"DELETE Patients.Id, Patients.PatientName, Patients.dateOfBirth, Patients.Address, 
                  PatientsIllnesses.IllnessID, PatientsIllnesses.DateFrom, PatientsIllnesses.DateTo, PatientsMeds.MedId, PatientsMeds.DateFrom AS DateFrom1, 
                  PatientsMeds.DateTo AS DateTo1, PatientsMeds.ExtentionDate  
                  FROM     Patients INNER JOIN
                  PatientsIllnesses ON Patients.Id = PatientsIllnesses.PatientID INNER JOIN
                  PatientsMeds ON Patients.Id = PatientsMeds.PatientID WHERE Id = '" + id + "'";

                DataSet ds = DBManager.getDBConnectionInstance().getDataSet(sql);
                setDataSet(ds);
                
                if (Utility.CheckFind(ds))
            {
                UIManager.Instance.ActivePatient = new Patient(ds);
                return true;
            }
            else return false;
            }   
    
        private void setDataSet(DataSet dset)
        {
            ds1 = dset;
            
        }

        public DataSet getDataSet ()
        {
            return ds1;
        }
        public bool ClickLogIn(string userName, string password)
        {
            
            string sql = @"SELECT * FROM Users WHERE Username = '" + userName + "'AND Password = '" + password +"'";
            DataSet ds = DBManager.getDBConnectionInstance().getDataSet(sql);
            if (Utility.CheckFind(ds))
            {
                UIManager.Instance.activeUser = new User(ds);
                return true;
            }
            else return false;
                    
        }      
    }
    public static class Utility
    {
        public static bool CheckFind(DataSet ds)
        {

            if (ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Multiple Entries with the same credentials");
                Console.ReadLine();
                return false;
            }
        }
    }
}
