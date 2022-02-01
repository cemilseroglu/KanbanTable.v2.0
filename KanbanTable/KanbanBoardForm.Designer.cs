namespace KanbanTable
{
    partial class KanbanBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.lbToDo = new System.Windows.Forms.ListBox();
            this.lbInProgress = new System.Windows.Forms.ListBox();
            this.lbDone = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(12, 12);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(105, 36);
            this.btnAddToDo.TabIndex = 0;
            this.btnAddToDo.Text = "Add To Do";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // lbToDo
            // 
            this.lbToDo.AllowDrop = true;
            this.lbToDo.BackColor = System.Drawing.Color.IndianRed;
            this.lbToDo.ContextMenuStrip = this.contextMenuStrip1;
            this.lbToDo.FormattingEnabled = true;
            this.lbToDo.Location = new System.Drawing.Point(162, 43);
            this.lbToDo.Name = "lbToDo";
            this.lbToDo.Size = new System.Drawing.Size(216, 394);
            this.lbToDo.TabIndex = 2;
            this.lbToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_DragDrop);
            this.lbToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_DragEnter);
            this.lbToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_DragOver);
            this.lbToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            // 
            // lbInProgress
            // 
            this.lbInProgress.AllowDrop = true;
            this.lbInProgress.BackColor = System.Drawing.Color.Green;
            this.lbInProgress.ContextMenuStrip = this.contextMenuStrip1;
            this.lbInProgress.FormattingEnabled = true;
            this.lbInProgress.Location = new System.Drawing.Point(400, 43);
            this.lbInProgress.Name = "lbInProgress";
            this.lbInProgress.Size = new System.Drawing.Size(216, 394);
            this.lbInProgress.TabIndex = 2;
            this.lbInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_DragDrop);
            this.lbInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_DragEnter);
            this.lbInProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_DragOver);
            this.lbInProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            // 
            // lbDone
            // 
            this.lbDone.AllowDrop = true;
            this.lbDone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbDone.ContextMenuStrip = this.contextMenuStrip1;
            this.lbDone.FormattingEnabled = true;
            this.lbDone.Location = new System.Drawing.Point(636, 43);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(216, 394);
            this.lbDone.TabIndex = 2;
            this.lbDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_DragDrop);
            this.lbDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_DragEnter);
            this.lbDone.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_DragOver);
            this.lbDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "IN PROGRESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(666, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "DONE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(194, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "TODO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(12, 120);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(134, 20);
            this.txtCategoryName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(12, 179);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(134, 173);
            this.lbCategory.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.showNoteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // showNoteToolStripMenuItem
            // 
            this.showNoteToolStripMenuItem.Name = "showNoteToolStripMenuItem";
            this.showNoteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.showNoteToolStripMenuItem.Text = "Show Note";
            this.showNoteToolStripMenuItem.Click += new System.EventHandler(this.showNoteToolStripMenuItem_Click);
            // 
            // KanbanBoardForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 444);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDone);
            this.Controls.Add(this.lbInProgress);
            this.Controls.Add(this.lbToDo);
            this.Controls.Add(this.btnAddToDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KanbanBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KanbanBoardForm";
            this.Load += new System.EventHandler(this.KanbanBoardForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.ListBox lbToDo;
        private System.Windows.Forms.ListBox lbInProgress;
        private System.Windows.Forms.ListBox lbDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNoteToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}