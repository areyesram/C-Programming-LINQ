namespace areyesram
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gridPersons = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numPage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(555, 37);
            this.panel1.TabIndex = 5;
            // 
            // numPage
            // 
            this.numPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.numPage.Location = new System.Drawing.Point(403, 8);
            this.numPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(120, 20);
            this.numPage.TabIndex = 5;
            this.numPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.ValueChanged += new System.EventHandler(this.numPage_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(348, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Page";
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFilter.Location = new System.Drawing.Point(8, 8);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(340, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // gridPersons
            // 
            this.gridPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPersons.Location = new System.Drawing.Point(0, 37);
            this.gridPersons.MultiSelect = false;
            this.gridPersons.Name = "gridPersons";
            this.gridPersons.ReadOnly = true;
            this.gridPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersons.Size = new System.Drawing.Size(555, 294);
            this.gridPersons.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 331);
            this.Controls.Add(this.gridPersons);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView gridPersons;
    }
}

