﻿namespace A_8
{
    partial class FormAdmin_DeleteUser
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
            this.label_Headline = new System.Windows.Forms.Label();
            this.checkBox_Accept = new System.Windows.Forms.CheckBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_Headline
            // 
            this.label_Headline.AutoSize = true;
            this.label_Headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Headline.ForeColor = System.Drawing.Color.Black;
            this.label_Headline.Location = new System.Drawing.Point(286, 18);
            this.label_Headline.Name = "label_Headline";
            this.label_Headline.Size = new System.Drawing.Size(146, 29);
            this.label_Headline.TabIndex = 1;
            this.label_Headline.Text = "Delete User";
            this.label_Headline.Click += new System.EventHandler(this.label_Headline_Click);
            // 
            // checkBox_Accept
            // 
            this.checkBox_Accept.AutoSize = true;
            this.checkBox_Accept.Location = new System.Drawing.Point(165, 460);
            this.checkBox_Accept.Name = "checkBox_Accept";
            this.checkBox_Accept.Size = new System.Drawing.Size(68, 21);
            this.checkBox_Accept.TabIndex = 3;
            this.checkBox_Accept.Text = "Agree";
            this.checkBox_Accept.UseVisualStyleBackColor = true;
            this.checkBox_Accept.Visible = false;
            this.checkBox_Accept.Click += new System.EventHandler(this.checkBox_Accept_Click);
            // 
            // button_Accept
            // 
            this.button_Accept.Enabled = false;
            this.button_Accept.Location = new System.Drawing.Point(291, 449);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(82, 40);
            this.button_Accept.TabIndex = 4;
            this.button_Accept.Text = "Accept";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = global::A_8.Properties.Resources.back;
            this.button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Back.Location = new System.Drawing.Point(414, 446);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(47, 43);
            this.button_Back.TabIndex = 22;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(15, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 379);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Permission";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Department";
            this.columnHeader5.Width = 200;
            // 
            // FormAdmin_DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 501);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.checkBox_Accept);
            this.Controls.Add(this.label_Headline);
            this.Name = "FormAdmin_DeleteUser";
            this.Text = "FormAdminDeleteUsercs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminDeleteUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Headline;
        private System.Windows.Forms.CheckBox checkBox_Accept;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}