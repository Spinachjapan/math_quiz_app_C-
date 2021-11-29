
namespace Networked_Math_Quiz
{
    partial class Teacher_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.operator_comboBox = new System.Windows.Forms.ComboBox();
            this.answer_textBox = new System.Windows.Forms.TextBox();
            this.secondNumber_textBox = new System.Windows.Forms.TextBox();
            this.firstNumber_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.insertion_button = new System.Windows.Forms.Button();
            this.selection_button = new System.Windows.Forms.Button();
            this.bubble_button = new System.Windows.Forms.Button();
            this.mathQuiz_dataGridView = new System.Windows.Forms.DataGridView();
            this.number_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wrongAnswer_TextBox = new System.Windows.Forms.RichTextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.linkedList_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.postSave_button = new System.Windows.Forms.Button();
            this.inSave_button = new System.Windows.Forms.Button();
            this.postDisplay_button = new System.Windows.Forms.Button();
            this.inDisplay_button = new System.Windows.Forms.Button();
            this.preSave_button = new System.Windows.Forms.Button();
            this.preDisplay_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.BT_TextArea = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mathQuiz_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.operator_comboBox);
            this.groupBox1.Controls.Add(this.answer_textBox);
            this.groupBox1.Controls.Add(this.secondNumber_textBox);
            this.groupBox1.Controls.Add(this.firstNumber_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(628, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter question. then click SEND";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // operator_comboBox
            // 
            this.operator_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operator_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operator_comboBox.FormattingEnabled = true;
            this.operator_comboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.operator_comboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operator_comboBox.Location = new System.Drawing.Point(360, 117);
            this.operator_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.operator_comboBox.Name = "operator_comboBox";
            this.operator_comboBox.Size = new System.Drawing.Size(216, 45);
            this.operator_comboBox.TabIndex = 8;
            // 
            // answer_textBox
            // 
            this.answer_textBox.Location = new System.Drawing.Point(360, 254);
            this.answer_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.answer_textBox.Name = "answer_textBox";
            this.answer_textBox.ReadOnly = true;
            this.answer_textBox.Size = new System.Drawing.Size(216, 31);
            this.answer_textBox.TabIndex = 7;
            // 
            // secondNumber_textBox
            // 
            this.secondNumber_textBox.Location = new System.Drawing.Point(360, 183);
            this.secondNumber_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.secondNumber_textBox.Name = "secondNumber_textBox";
            this.secondNumber_textBox.Size = new System.Drawing.Size(216, 31);
            this.secondNumber_textBox.TabIndex = 6;
            // 
            // firstNumber_textBox
            // 
            this.firstNumber_textBox.Location = new System.Drawing.Point(360, 56);
            this.firstNumber_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNumber_textBox.Name = "firstNumber_textBox";
            this.firstNumber_textBox.Size = new System.Drawing.Size(216, 31);
            this.firstNumber_textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(396, 477);
            this.send_button.Margin = new System.Windows.Forms.Padding(4);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(216, 42);
            this.send_button.TabIndex = 2;
            this.send_button.Text = "SEND";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.insertion_button);
            this.groupBox2.Controls.Add(this.selection_button);
            this.groupBox2.Controls.Add(this.bubble_button);
            this.groupBox2.Controls.Add(this.mathQuiz_dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(740, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(912, 415);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array of questions asked";
            // 
            // insertion_button
            // 
            this.insertion_button.Location = new System.Drawing.Point(646, 344);
            this.insertion_button.Margin = new System.Windows.Forms.Padding(2);
            this.insertion_button.Name = "insertion_button";
            this.insertion_button.Size = new System.Drawing.Size(224, 42);
            this.insertion_button.TabIndex = 5;
            this.insertion_button.Text = "Insertion sort (asc)";
            this.insertion_button.UseVisualStyleBackColor = true;
            this.insertion_button.Click += new System.EventHandler(this.insertion_button_Click);
            // 
            // selection_button
            // 
            this.selection_button.Location = new System.Drawing.Point(344, 344);
            this.selection_button.Margin = new System.Windows.Forms.Padding(2);
            this.selection_button.Name = "selection_button";
            this.selection_button.Size = new System.Drawing.Size(232, 42);
            this.selection_button.TabIndex = 4;
            this.selection_button.Text = "Selection sort (desc)";
            this.selection_button.UseVisualStyleBackColor = true;
            this.selection_button.Click += new System.EventHandler(this.selection_button_Click);
            // 
            // bubble_button
            // 
            this.bubble_button.Location = new System.Drawing.Point(62, 344);
            this.bubble_button.Margin = new System.Windows.Forms.Padding(4);
            this.bubble_button.Name = "bubble_button";
            this.bubble_button.Size = new System.Drawing.Size(220, 42);
            this.bubble_button.TabIndex = 3;
            this.bubble_button.Text = "Bubble sort (asc)";
            this.bubble_button.UseVisualStyleBackColor = true;
            this.bubble_button.Click += new System.EventHandler(this.bubble_button_Click);
            // 
            // mathQuiz_dataGridView
            // 
            this.mathQuiz_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mathQuiz_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mathQuiz_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mathQuiz_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_1,
            this.math,
            this.number_2,
            this.equal,
            this.answer});
            this.mathQuiz_dataGridView.Location = new System.Drawing.Point(62, 56);
            this.mathQuiz_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mathQuiz_dataGridView.Name = "mathQuiz_dataGridView";
            this.mathQuiz_dataGridView.RowHeadersWidth = 82;
            this.mathQuiz_dataGridView.RowTemplate.Height = 33;
            this.mathQuiz_dataGridView.Size = new System.Drawing.Size(808, 260);
            this.mathQuiz_dataGridView.TabIndex = 0;
            // 
            // number_1
            // 
            this.number_1.HeaderText = "Number 1";
            this.number_1.MinimumWidth = 10;
            this.number_1.Name = "number_1";
            // 
            // math
            // 
            this.math.HeaderText = "Math";
            this.math.MinimumWidth = 10;
            this.math.Name = "math";
            // 
            // number_2
            // 
            this.number_2.HeaderText = "Number 2";
            this.number_2.MinimumWidth = 10;
            this.number_2.Name = "number_2";
            // 
            // equal
            // 
            this.equal.HeaderText = "=";
            this.equal.MinimumWidth = 10;
            this.equal.Name = "equal";
            // 
            // answer
            // 
            this.answer.HeaderText = "Answer";
            this.answer.MinimumWidth = 10;
            this.answer.Name = "answer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 100);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(714, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 67);
            this.label5.TabIndex = 0;
            this.label5.Text = "Instructor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wrongAnswer_TextBox);
            this.groupBox3.Controls.Add(this.exit_button);
            this.groupBox3.Controls.Add(this.linkedList_button);
            this.groupBox3.Location = new System.Drawing.Point(44, 604);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1610, 244);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Linked List (of all incorectlly answered questions)";
            // 
            // wrongAnswer_TextBox
            // 
            this.wrongAnswer_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.wrongAnswer_TextBox.Location = new System.Drawing.Point(32, 87);
            this.wrongAnswer_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wrongAnswer_TextBox.Name = "wrongAnswer_TextBox";
            this.wrongAnswer_TextBox.ReadOnly = true;
            this.wrongAnswer_TextBox.Size = new System.Drawing.Size(1550, 135);
            this.wrongAnswer_TextBox.TabIndex = 7;
            this.wrongAnswer_TextBox.Text = "";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1370, 0);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(224, 38);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // linkedList_button
            // 
            this.linkedList_button.Location = new System.Drawing.Point(1044, 0);
            this.linkedList_button.Margin = new System.Windows.Forms.Padding(2);
            this.linkedList_button.Name = "linkedList_button";
            this.linkedList_button.Size = new System.Drawing.Size(232, 38);
            this.linkedList_button.TabIndex = 5;
            this.linkedList_button.Text = "Display Linked List ";
            this.linkedList_button.UseVisualStyleBackColor = true;
            this.linkedList_button.Click += new System.EventHandler(this.linkedList_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.postSave_button);
            this.groupBox4.Controls.Add(this.inSave_button);
            this.groupBox4.Controls.Add(this.postDisplay_button);
            this.groupBox4.Controls.Add(this.inDisplay_button);
            this.groupBox4.Controls.Add(this.preSave_button);
            this.groupBox4.Controls.Add(this.preDisplay_button);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(44, 1134);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1610, 206);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "   ";
            // 
            // postSave_button
            // 
            this.postSave_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postSave_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.postSave_button.Location = new System.Drawing.Point(1386, 133);
            this.postSave_button.Margin = new System.Windows.Forms.Padding(4);
            this.postSave_button.Name = "postSave_button";
            this.postSave_button.Size = new System.Drawing.Size(140, 40);
            this.postSave_button.TabIndex = 8;
            this.postSave_button.Text = " Save";
            this.postSave_button.UseVisualStyleBackColor = true;
            this.postSave_button.Click += new System.EventHandler(this.postSave_button_Click);
            // 
            // inSave_button
            // 
            this.inSave_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inSave_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inSave_button.Location = new System.Drawing.Point(814, 133);
            this.inSave_button.Margin = new System.Windows.Forms.Padding(4);
            this.inSave_button.Name = "inSave_button";
            this.inSave_button.Size = new System.Drawing.Size(140, 40);
            this.inSave_button.TabIndex = 7;
            this.inSave_button.Text = " Save";
            this.inSave_button.UseVisualStyleBackColor = true;
            this.inSave_button.Click += new System.EventHandler(this.inSave_button_Click);
            // 
            // postDisplay_button
            // 
            this.postDisplay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDisplay_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.postDisplay_button.Location = new System.Drawing.Point(1230, 133);
            this.postDisplay_button.Margin = new System.Windows.Forms.Padding(4);
            this.postDisplay_button.Name = "postDisplay_button";
            this.postDisplay_button.Size = new System.Drawing.Size(136, 40);
            this.postDisplay_button.TabIndex = 6;
            this.postDisplay_button.Text = "Display";
            this.postDisplay_button.UseVisualStyleBackColor = true;
            this.postDisplay_button.Click += new System.EventHandler(this.postDisplay_button_Click);
            // 
            // inDisplay_button
            // 
            this.inDisplay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDisplay_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inDisplay_button.Location = new System.Drawing.Point(652, 133);
            this.inDisplay_button.Margin = new System.Windows.Forms.Padding(4);
            this.inDisplay_button.Name = "inDisplay_button";
            this.inDisplay_button.Size = new System.Drawing.Size(136, 40);
            this.inDisplay_button.TabIndex = 5;
            this.inDisplay_button.Text = "Display";
            this.inDisplay_button.UseVisualStyleBackColor = true;
            this.inDisplay_button.Click += new System.EventHandler(this.inDisplay_button_Click);
            // 
            // preSave_button
            // 
            this.preSave_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preSave_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.preSave_button.Location = new System.Drawing.Point(236, 133);
            this.preSave_button.Margin = new System.Windows.Forms.Padding(4);
            this.preSave_button.Name = "preSave_button";
            this.preSave_button.Size = new System.Drawing.Size(140, 40);
            this.preSave_button.TabIndex = 4;
            this.preSave_button.Text = " Save";
            this.preSave_button.UseVisualStyleBackColor = true;
            this.preSave_button.Click += new System.EventHandler(this.preSave_button_Click);
            // 
            // preDisplay_button
            // 
            this.preDisplay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preDisplay_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.preDisplay_button.Location = new System.Drawing.Point(76, 133);
            this.preDisplay_button.Margin = new System.Windows.Forms.Padding(4);
            this.preDisplay_button.Name = "preDisplay_button";
            this.preDisplay_button.Size = new System.Drawing.Size(136, 40);
            this.preDisplay_button.TabIndex = 3;
            this.preDisplay_button.Text = "Display";
            this.preDisplay_button.UseVisualStyleBackColor = true;
            this.preDisplay_button.Click += new System.EventHandler(this.preDisplay_button_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(1228, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 50);
            this.label8.TabIndex = 2;
            this.label8.Text = "Post-Order";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(656, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 50);
            this.label7.TabIndex = 1;
            this.label7.Text = "In-Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(76, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pre-Order";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.search_textBox);
            this.groupBox5.Controls.Add(this.search_button);
            this.groupBox5.Controls.Add(this.BT_TextArea);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(44, 902);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1610, 206);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Binary Tree (of all questions - added in the order asked)";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(1044, 0);
            this.search_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(232, 31);
            this.search_textBox.TabIndex = 9;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1370, 0);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(224, 42);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // BT_TextArea
            // 
            this.BT_TextArea.BackColor = System.Drawing.SystemColors.Window;
            this.BT_TextArea.Location = new System.Drawing.Point(32, 48);
            this.BT_TextArea.Margin = new System.Windows.Forms.Padding(4);
            this.BT_TextArea.Name = "BT_TextArea";
            this.BT_TextArea.ReadOnly = true;
            this.BT_TextArea.Size = new System.Drawing.Size(1550, 135);
            this.BT_TextArea.TabIndex = 8;
            this.BT_TextArea.Text = "";
            // 
            // Teacher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1835, 1383);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.teacher_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mathQuiz_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox answer_textBox;
        private System.Windows.Forms.TextBox secondNumber_textBox;
        private System.Windows.Forms.TextBox firstNumber_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView mathQuiz_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bubble_button;
        private System.Windows.Forms.Button insertion_button;
        private System.Windows.Forms.Button selection_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox wrongAnswer_TextBox;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button linkedList_button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button postSave_button;
        private System.Windows.Forms.Button inSave_button;
        private System.Windows.Forms.Button postDisplay_button;
        private System.Windows.Forms.Button inDisplay_button;
        private System.Windows.Forms.Button preSave_button;
        private System.Windows.Forms.Button preDisplay_button;
        private System.Windows.Forms.ComboBox operator_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn math;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn equal;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.RichTextBox BT_TextArea;
    }
}

