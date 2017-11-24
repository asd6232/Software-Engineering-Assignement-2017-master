using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Patient_Info_Box : Form
    {
        public DataGridView PatientGrid
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }    

        public Patient_Info_Box()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            UIManager.Instance.swapVisibility3();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                int id = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());

                UIManager.Instance.Delete_Click(id.ToString());

                System.Windows.MessageBox.Show("Information Deleted");
            }
            
        }   

        }
    }
