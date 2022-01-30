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
    public partial class KanbanBoardForm : Form
    {
        Project project;
        Notes copyNote;
        ListBox listbox_Item_Input;
        ListBox listbox_Item_Output;
        int Listbox_Index = 0;
        MainWindowForm mainForm;
        public KanbanBoardForm(Project inputProject, MainWindowForm inputForm)
        {
            InitializeComponent();
            project = inputProject;
            mainForm = inputForm;
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            AddNewNoteForm addNoteForm = new AddNewNoteForm(project);
            addNoteForm.ShowDialog();
            ListHere();
        }

        private void KanbanBoardForm_Load(object sender, EventArgs e)
        {
            ListHere();
        }

        void ListHere()
        {
            lbDone.Items.Clear();
            lbInProgress.Items.Clear();
            lbToDo.Items.Clear();
            lbCategory.Items.Clear();
            foreach (var item in project.todoList)
            {
                lbToDo.Items.Add(item);
            }
            foreach (var item in project.ınProgressList)
            {
                lbInProgress.Items.Add(item);
            }
            foreach (var item in project.doneList)
            {
                lbDone.Items.Add(item);
            }

            foreach (var item in project.category)
            {
                lbCategory.Items.Add(item.Category);
            }


        }

        private void lb_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lb_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        private void lb_MouseDown(object sender, MouseEventArgs e)
        {
            listbox_Item_Input = sender as ListBox;
            Point blind_point = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Input.IndexFromPoint(blind_point);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
            {
                listbox_Item_Input.DoDragDrop(listbox_Item_Input.Items[Listbox_Index].ToString(), DragDropEffects.All);
            }
            if (e.Button == MouseButtons.Right)
            {
                int indux = listbox_Item_Input.IndexFromPoint(e.Location);

                if (indux == listbox_Item_Input.SelectedIndex)
                {
                    contextMenuStrip1.Show(MousePosition);
                }

            }
        }

        private void lb_DragDrop(object sender, DragEventArgs e)
        {
            listbox_Item_Output = sender as ListBox;
            listbox_Item_Output.Items.Add(listbox_Item_Input.Items[Listbox_Index]);
            Notes tranferedNote = (Notes)listbox_Item_Input.Items[Listbox_Index];

            listbox_Item_Input.Items.Remove(listbox_Item_Input.Items[Listbox_Index]);

            if (listbox_Item_Output.Name == lbInProgress.Name)
            {
                project.ınProgressList.Add(tranferedNote);
            }
            else if (listbox_Item_Output.Name == lbToDo.Name)
            {
                project.todoList.Add(tranferedNote);
            }
            else if (listbox_Item_Output.Name == lbDone.Name)
            {
                project.doneList.Add(tranferedNote);
            }

            if (listbox_Item_Input.Name == lbInProgress.Name)
            {
                project.ınProgressList.Remove(tranferedNote);
            }
            else if (listbox_Item_Input.Name == lbToDo.Name)
            {
                project.todoList.Remove(tranferedNote);
            }
            else if (listbox_Item_Input.Name == lbDone.Name)
            {
                project.doneList.Remove(tranferedNote);
            }

            ListHere();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyNote = (Notes)listbox_Item_Input.SelectedItem;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copyNote != null)
            {
                if (listbox_Item_Input.Name == lbInProgress.Name)
                {
                    project.ınProgressList.Add(copyNote);
                }

                else if (listbox_Item_Input.Name == lbToDo.Name)
                {
                    project.todoList.Add(copyNote);
                }
                else if (listbox_Item_Input.Name == lbDone.Name)
                {
                    project.doneList.Add(copyNote);
                }
                ListHere();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes deleteNote = new Notes();
            deleteNote = (Notes)listbox_Item_Input.SelectedItem;
            if (listbox_Item_Input.Name == lbInProgress.Name)
            {
                project.ınProgressList.Remove(deleteNote);
            }
            else if (listbox_Item_Input.Name == lbToDo.Name)
            {
                project.todoList.Remove(deleteNote);
            }
            else if (listbox_Item_Input.Name == lbDone.Name)
            {
                project.doneList.Remove(deleteNote);
            }
            ListHere();
        }

        private void showNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes viewNotes = new Notes();
            viewNotes = (Notes)listbox_Item_Input.SelectedItem;
            ViewNotesForm viewNotesForm = new ViewNotesForm(viewNotes);
            viewNotesForm.MdiParent = mainForm;
            viewNotesForm.BackColor = inputColor;
            viewNotesForm.Show();
        }
        Color inputColor;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO
            if (project.AddCategory(txtCategoryName.Text, inputColor))
            {
                MessageBox.Show("Category added.");
            }
            colorDialog1.ShowDialog();
            inputColor = colorDialog1.Color;
            ListHere();
        }



    }
}
