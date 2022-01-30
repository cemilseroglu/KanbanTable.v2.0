using KanbanTable.Date;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanTable
{
    public partial class MainWindowForm : Form
    {
        KanbanBoardForm KanbanTable;
        LoginForm Login;
        Project project;
        
        public MainWindowForm(Project inputProject,LoginForm inputLogin)
        {
            InitializeComponent();
            project = inputProject;
            Login = inputLogin;
        }


        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KanbanTable = new KanbanBoardForm(project,this);
            KanbanTable.MdiParent = this;
            KanbanTable.Show();
        }

        private void exitProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm();
            Login.Show();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            this.Text = project.ProjectName;
        }

        private void MainWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new LoginForm();
            Login.Show();
        }
    }
}
