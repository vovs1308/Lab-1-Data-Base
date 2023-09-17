using System.Diagnostics;
using System.Windows.Forms;

namespace Лаб_1_База_данных
{
    public partial class Form1 : Form
    {
        private List<Student> _list;


        public Form1()
        {
            InitializeComponent();
            _list = new List<Student>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"students.txt");
                // StLastName, StFirstName,Grade,Classroom,Bus,TLastName,TFirstName
                // COOKUS,XUAN ,3 ,107,52,FAFARD,ROCIO
                foreach (string line in lines)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //richTextBox1.Text += line + Environment.NewLine;
                    Student student = new Student()
                    {
                        StLastName = data[0],
                        StFirstName = data[1],
                        Grade = int.Parse(data[2]),
                        Classroom = int.Parse(data[3]),
                        Bus = int.Parse(data[4]),
                        TLastName = data[5],
                        TFirstName = data[6]
                    };
                    _list.Add(student);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip2.Items[1].Text = _list.Count.ToString();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)//task1
        {
            tbResult.Text = "";
            int count = 0;
            
            foreach (var item in _list)
            {
                var StudentSurname = tbSurname.Text.Trim();
                if (item.StLastName == StudentSurname)
                {
                    tbResult.Text += item.ToStringStudentClassTeacher();
                    count++;
                }
                if (count > 1000)
                    break;
            }
            
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)//task2
        {
            tbResult.Text = "";
            int count = 0;
            foreach (var item in _list)
            {
                var StudentSurname = tbSurname_2.Text.Trim();
                if (item.StLastName == StudentSurname)
                {
                    tbResult.Text += item.ToStringStudentBus();
                    count++;
                }
                if (count > 1000)
                    break;
            }
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)//task3
        {
            tbResult.Text = "";
            int count = 0;
            foreach (var item in _list)
            {
                var TeacherSurname = tbSurname_Professor.Text.Trim();
                if (item.TLastName == TeacherSurname)
                {
                    tbResult.Text += item.ToStringTeachersStudentsList();
                    count++;
                }
                if (count > 1000)
                    break;
            }
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)//task4
        {
            tbResult.Text = "";
            int count = 0;
            int BusNum = Convert.ToInt32(Bus_Number.Text.Trim());
            foreach (var item in _list)
            {
                if (item.Bus == BusNum)
                {
                    tbResult.Text += item.ToStringStudentsBus1();
                    count++;
                }
                if (count > 1000)
                    break;
            }
        }

        private void task5ToolStripMenuItem_Click(object sender, EventArgs e)//task5
        {
            tbResult.Text = "";
            int count = 0;
            int Grade = Convert.ToInt32(Grade_students.Text.Trim());
            foreach (var item in _list)
            {
                if (item.Grade == Grade)
                {
                    tbResult.Text += item.ToStringStudentsGrade();
                    count++;
                }
                if (count > 1000)
                    break;
            }
        }

        
    }
}            
