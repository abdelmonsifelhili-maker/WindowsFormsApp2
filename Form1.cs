using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> MyTasks = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TaskTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            MyTasks.Add(TaskTbx.Text);

            TasksLbx.DataSource = null;
            TasksLbx.DataSource = MyTasks;
        }

        private void TasksLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TasksLbx.SelectedIndex >= 0 && TasksLbx.SelectedIndex < MyTasks.Count)
            {
                MyTasks.RemoveAt(TasksLbx.SelectedIndex);

                TasksLbx.DataSource = null;
                TasksLbx.DataSource = MyTasks;
            }
        }
    }
}
