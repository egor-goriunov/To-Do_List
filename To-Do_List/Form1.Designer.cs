namespace To_Do_List
{
    partial class FrmToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Lbl_Description = new Label();
            Lbl_Title = new Label();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl1.Location = new Point(12, 9);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(1699, 92);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "To Do List";
            Lbl1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1699, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1699, 23);
            textBox2.TabIndex = 2;
            // 
            // Lbl_Description
            // 
            Lbl_Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Description.Location = new Point(12, 153);
            Lbl_Description.Name = "Lbl_Description";
            Lbl_Description.Size = new Size(1699, 23);
            Lbl_Description.TabIndex = 3;
            Lbl_Description.Text = "Description:";
            Lbl_Description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Title
            // 
            Lbl_Title.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Title.Location = new Point(12, 101);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(1699, 23);
            Lbl_Title.TabIndex = 4;
            Lbl_Title.Text = "Title:";
            Lbl_Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1723, 989);
            Controls.Add(Lbl_Title);
            Controls.Add(Lbl_Description);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Lbl1);
            Name = "FrmToDoList";
            Text = "To Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Lbl_Description;
        private Label Lbl_Title;
    }
}