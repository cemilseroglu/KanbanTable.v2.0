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
    public partial class AddNewNoteForm : Form
    {
        Project project;
        public AddNewNoteForm(Project inputProject)
        {
            InitializeComponent();
            project = inputProject;
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            int u = 140 - txtNote.TextLength;
            lblLeft.Text = u.ToString();
        }

        private void AddNewNoteForm_Load(object sender, EventArgs e)
        {
            txtNote.MaxLength = 140;
            lblLeft.Text = 140.ToString();
            foreach (var item in project.category)
            {
                txtCategory.Items.Add(item.Category);
            }
        }

        private void btnAddNewNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoteTitle.Text) || string.IsNullOrEmpty(txtNote.Text) || string.IsNullOrEmpty(txtCategory.Text))
            {
                MessageBox.Show("Fill all blank fields.");
            }
            else
            {
                project.AddNote(txtNoteTitle.Text, txtCategory.Text, txtNote.Text);
                MessageBox.Show("Note added.");
                txtCategory.SelectedIndex = 0;
                txtNote.Clear();
                txtNoteTitle.Clear();
            }
            Close();
        }
    }
}
