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
    public partial class ViewNotesForm : Form
    {
        Notes notes;
        public ViewNotesForm(Notes inputNotes)
        {
            InitializeComponent();
            notes= inputNotes;
        }

        private void ViewNotesForm_Load(object sender, EventArgs e)
        {
            txtNoteTitleReadOnly.Text = notes.NoteTitle;
            txtCategoryReadOnly.Text = notes.Category;
            txtNotesReadOnly.Text = notes.WroteNote;
        }
    }
}
