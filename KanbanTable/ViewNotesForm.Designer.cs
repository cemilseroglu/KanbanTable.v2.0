namespace KanbanTable
{
    partial class ViewNotesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoteTitleReadOnly = new System.Windows.Forms.TextBox();
            this.txtCategoryReadOnly = new System.Windows.Forms.TextBox();
            this.txtNotesReadOnly = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Note:";
            // 
            // txtNoteTitleReadOnly
            // 
            this.txtNoteTitleReadOnly.Location = new System.Drawing.Point(123, 30);
            this.txtNoteTitleReadOnly.Name = "txtNoteTitleReadOnly";
            this.txtNoteTitleReadOnly.ReadOnly = true;
            this.txtNoteTitleReadOnly.Size = new System.Drawing.Size(238, 20);
            this.txtNoteTitleReadOnly.TabIndex = 1;
            // 
            // txtCategoryReadOnly
            // 
            this.txtCategoryReadOnly.Location = new System.Drawing.Point(123, 84);
            this.txtCategoryReadOnly.Name = "txtCategoryReadOnly";
            this.txtCategoryReadOnly.ReadOnly = true;
            this.txtCategoryReadOnly.Size = new System.Drawing.Size(238, 20);
            this.txtCategoryReadOnly.TabIndex = 1;
            // 
            // txtNotesReadOnly
            // 
            this.txtNotesReadOnly.Location = new System.Drawing.Point(123, 155);
            this.txtNotesReadOnly.Name = "txtNotesReadOnly";
            this.txtNotesReadOnly.ReadOnly = true;
            this.txtNotesReadOnly.Size = new System.Drawing.Size(238, 169);
            this.txtNotesReadOnly.TabIndex = 2;
            this.txtNotesReadOnly.Text = "";
            // 
            // ViewNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(437, 366);
            this.Controls.Add(this.txtNotesReadOnly);
            this.Controls.Add(this.txtCategoryReadOnly);
            this.Controls.Add(this.txtNoteTitleReadOnly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewNotesForm";
            this.Text = "ViewNotesForm";
            this.Load += new System.EventHandler(this.ViewNotesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoteTitleReadOnly;
        private System.Windows.Forms.TextBox txtCategoryReadOnly;
        private System.Windows.Forms.RichTextBox txtNotesReadOnly;
    }
}