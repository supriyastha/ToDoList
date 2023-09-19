using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.User_Control;

namespace ToDoList
{
    public partial class Dashboard : Form
    {
        private HomePage homepage;
        private AllTasks alltasks;
        private Completed completed;
        private Remaining remaining;
        private LogOut logout;
        public Dashboard()
        {
            InitializeComponent();
            HomePage homepage=new HomePage();
            addUserControl(homepage);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllTasks alltasks = new AllTasks();
            addUserControl(alltasks);        }

        private void button2_Click(object sender, EventArgs e)
        {
            Completed completed = new Completed();
            addUserControl(completed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remaining remaining = new Remaining();
            addUserControl(remaining);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogOut logout = new LogOut();
            addUserControl(logout);
        }
    }
}
