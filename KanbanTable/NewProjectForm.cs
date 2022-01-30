using KanbanTable.Date;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanTable
{
    public partial class NewProjectForm : Form
    {
        ProjectManage manager;
        public NewProjectForm(ProjectManage input)
        {
            InitializeComponent();
            manager = input;
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProjectName.Text))
            {
                bool checkCreatedProject = (manager.addNewProject(txtProjectName.Text));
                if (checkCreatedProject)
                {
                    MessageBox.Show("Project created!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Used project name,please enter new project name.");
                }

            }
            else
                MessageBox.Show("Fill all blank fields.");
        }
    }
}
