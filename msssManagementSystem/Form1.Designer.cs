namespace msssManagementSystem
{
    partial class Form1
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
            this.DataListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstructionBox = new System.Windows.Forms.TextBox();
            this.labelForId = new System.Windows.Forms.Label();
            this.labelForName = new System.Windows.Forms.Label();
            this.filterById = new System.Windows.Forms.TextBox();
            this.filterByName = new System.Windows.Forms.TextBox();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DataListView
            // 
            this.DataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DataListView.Enabled = false;
            this.DataListView.HideSelection = false;
            this.DataListView.Location = new System.Drawing.Point(12, 28);
            this.DataListView.Name = "DataListView";
            this.DataListView.Size = new System.Drawing.Size(390, 783);
            this.DataListView.TabIndex = 0;
            this.DataListView.UseCompatibleStateImageBehavior = false;
            this.DataListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "name";
            this.columnHeader2.Width = 120;
            // 
            // InstructionBox
            // 
            this.InstructionBox.Enabled = false;
            this.InstructionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionBox.Location = new System.Drawing.Point(891, 94);
            this.InstructionBox.Multiline = true;
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(392, 503);
            this.InstructionBox.TabIndex = 1;
            // 
            // labelForId
            // 
            this.labelForId.AutoSize = true;
            this.labelForId.Location = new System.Drawing.Point(457, 38);
            this.labelForId.Name = "labelForId";
            this.labelForId.Size = new System.Drawing.Size(115, 25);
            this.labelForId.TabIndex = 2;
            this.labelForId.Text = "Filter by ID";
            // 
            // labelForName
            // 
            this.labelForName.AutoSize = true;
            this.labelForName.Location = new System.Drawing.Point(466, 126);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(151, 25);
            this.labelForName.TabIndex = 3;
            this.labelForName.Text = "Filter by Name";
            // 
            // filterById
            // 
            this.filterById.Location = new System.Drawing.Point(462, 78);
            this.filterById.Name = "filterById";
            this.filterById.Size = new System.Drawing.Size(260, 31);
            this.filterById.TabIndex = 4;
            this.filterById.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterById_KeyUp);
            // 
            // filterByName
            // 
            this.filterByName.Location = new System.Drawing.Point(462, 172);
            this.filterByName.Name = "filterByName";
            this.filterByName.Size = new System.Drawing.Size(260, 31);
            this.filterByName.TabIndex = 5;
            this.filterByName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterByName_KeyUp);
            // 
            // ResultListView
            // 
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(462, 238);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(351, 573);
            this.ResultListView.TabIndex = 6;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "name";
            this.columnHeader4.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1018);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.filterByName);
            this.Controls.Add(this.filterById);
            this.Controls.Add(this.labelForName);
            this.Controls.Add(this.labelForId);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.DataListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DataListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox InstructionBox;
        private System.Windows.Forms.Label labelForId;
        private System.Windows.Forms.Label labelForName;
        private System.Windows.Forms.TextBox filterById;
        private System.Windows.Forms.TextBox filterByName;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

