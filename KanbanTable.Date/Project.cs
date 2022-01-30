using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanTable.Date
{
    public class Project
    {
        public Project()
        {
            todoList = new List<Notes>();
            ınProgressList = new List<Notes>();
            doneList = new List<Notes>();
            category = new List<Notes>();

        }

        public string ProjectName { get; set; }

        public List<Notes> todoList { get; set; }
        public List <Notes> ınProgressList { get; set; }    

        public List <Notes> doneList { get; set; }
        public List<Notes> category { get; set; }   

        public bool AddNote(string noteName,string category,string note)
        {
            todoList.Add(new Notes()
            {
                NoteTitle = noteName,
                Category = category,
                WroteNote = note

            });

            return true;
        }

        public bool AddCategory(string categoryName,Color color)
        {
            category.Add(new Notes()
            {
                Category = categoryName,
                CategoryColor = color
            });

            return true;
        }
    }
}
