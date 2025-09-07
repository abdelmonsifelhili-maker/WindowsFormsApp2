namespace WindowsFormsApp2
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
            this.TaskTbx = new System.Windows.Forms.TextBox();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.TasksLbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TaskTbx
            // 
            this.TaskTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTbx.Location = new System.Drawing.Point(31, 38);
            this.TaskTbx.Margin = new System.Windows.Forms.Padding(5);
            this.TaskTbx.Name = "TaskTbx";
            this.TaskTbx.Size = new System.Drawing.Size(234, 38);
            this.TaskTbx.TabIndex = 0;
            this.TaskTbx.TextChanged += new System.EventHandler(this.TaskTbx_TextChanged);
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(303, 40);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(125, 38);
            this.AddTaskBtn.TabIndex = 1;
            this.AddTaskBtn.Text = "Add task";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // TasksLbx
            // 
            this.TasksLbx.FormattingEnabled = true;
            this.TasksLbx.ItemHeight = 25;
            this.TasksLbx.Location = new System.Drawing.Point(31, 115);
            this.TasksLbx.Name = "TasksLbx";
            this.TasksLbx.Size = new System.Drawing.Size(397, 354);
            this.TasksLbx.TabIndex = 3;
            this.TasksLbx.SelectedIndexChanged += new System.EventHandler(this.TasksLbx_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 492);
            this.Controls.Add(this.TasksLbx);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.TaskTbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskTbx;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.ListBox TasksLbx;
    }
}

