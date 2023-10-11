namespace msssManagementSystem
{
    partial class Admin
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
            this.idLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(63, 26);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(32, 25);
            this.idLable.TabIndex = 0;
            this.idLable.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(63, 118);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 31);
            this.textBox2.TabIndex = 3;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(176, 280);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(103, 70);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(301, 280);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(98, 70);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(479, 26);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 459);
            this.textBox3.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(39, 280);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 70);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 594);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLable);
            this.Name = "Admin";
            this.Text = "Admin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Admin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Add;
    }
}