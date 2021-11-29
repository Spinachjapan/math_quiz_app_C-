
namespace Networked_Math_Quiz
{
    partial class Student_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.answer_textBox = new System.Windows.Forms.TextBox();
            this.question_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(236, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submit_button);
            this.groupBox1.Controls.Add(this.answer_textBox);
            this.groupBox1.Controls.Add(this.question_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Enter your answer and click SUBMIT";
            // 
            // submit_button
            // 
            this.submit_button.Enabled = false;
            this.submit_button.Location = new System.Drawing.Point(399, 284);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(119, 40);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "SUBMIT";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // answer_textBox
            // 
            this.answer_textBox.Enabled = false;
            this.answer_textBox.Location = new System.Drawing.Point(300, 188);
            this.answer_textBox.Name = "answer_textBox";
            this.answer_textBox.Size = new System.Drawing.Size(218, 31);
            this.answer_textBox.TabIndex = 3;
            // 
            // question_textBox
            // 
            this.question_textBox.Enabled = false;
            this.question_textBox.Location = new System.Drawing.Point(300, 94);
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.ReadOnly = true;
            this.question_textBox.Size = new System.Drawing.Size(218, 31);
            this.question_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Your Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(429, 577);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(119, 38);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 637);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Student_form";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.student_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox answer_textBox;
        private System.Windows.Forms.TextBox question_textBox;
        private System.Windows.Forms.Button exit_button;
    }
}