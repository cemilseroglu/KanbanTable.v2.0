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
    public partial class LoginForm : Form
    {
        ProjectManage projectManager;
        List<Project> projectList;
        Project project;
        public LoginForm()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText("veri.json");
                projectManager = JsonConvert.DeserializeObject<ProjectManage>(json);
            }
            catch (Exception)
            {

                projectManager = new ProjectManage();
            }
            projectList = projectManager.Projects;
            checkCmb();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbSavedProject.Text))
                MessageBox.Show("Select a project or create a new project.");
            else
            {
                project = projectManager.openProject(cmbSavedProject.Text);
                MainWindowForm mainWindow = new MainWindowForm(project,this);
                mainWindow.Show();
                this.Hide();
            }

        }



        private void btnNewProject_Click(object sender, EventArgs e)
        {
            NewProjectForm newProject = new NewProjectForm(projectManager);
            newProject.ShowDialog();

            checkCmb();
        }

        public void checkCmb()
        {
            cmbSavedProject.Items.Clear();
            foreach (var item in projectList)
            {
                cmbSavedProject.Items.Add(item.ProjectName);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(projectManager);
            File.WriteAllText("veri.json", json);
        }
    }
}
