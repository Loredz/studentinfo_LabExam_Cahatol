using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Cahatol_Joshua_LabExam
{
    partial class Student_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnView;

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
            dataGridView1 = new DataGridView();
            btnView = new Button();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(57, 213);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(606, 129);
            dataGridView1.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.Location = new Point(302, 358);
            btnView.Name = "btnView";
            btnView.Size = new Size(100, 30);
            btnView.TabIndex = 2;
            btnView.Text = "View Details";
            btnView.UseVisualStyleBackColor = true;
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(dataGridView1);
            Controls.Add(btnView);
            Name = "Student_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Page Form";
            Load += Student_Page_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
