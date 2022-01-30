using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanTable.Date
{
    public class Notes
    {
        public string NoteTitle { get; set; }
        public string WroteNote { get; set; }
        public string Category { get; set; }
        public Color CategoryColor { get; set; }

        public override string ToString()
        {
            return NoteTitle;
        }
    }
}
