using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanTable.Date
{
    public class ProjectManage
    {
        public ProjectManage()
        {
            Projects = new List<Project>();
        }
        public List<Project> Projects { get; set; }

        public bool ProjectControl(string projectName)
        {
            return Projects.Any(x => x.ProjectName == projectName);
        }


        public bool addNewProject(string projectName)
        {
            if (ProjectControl(projectName))
            {
                return false;
            }

            else if (!ProjectControl(projectName))
            {
                Projects.Add(new Project()
                {
                    ProjectName = projectName,

                });
                return true;
            }
            return false;
        }

        public Project openProject(string projectName)
        {
            return Projects.FirstOrDefault(x => x.ProjectName == projectName);
        }
    }

    

   

}
