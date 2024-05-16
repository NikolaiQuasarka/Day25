namespace Task1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            IdNote = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBoxFullName = new TextBox();
            textBoxSubj = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAddConsultation = new Button();
            buttonCancel = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdNote, Day, Student, Subject });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(609, 368);
            dataGridView1.TabIndex = 0;
            // 
            // IdNote
            // 
            IdNote.DataPropertyName = "IdNote";
            IdNote.HeaderText = "Column1";
            IdNote.MinimumWidth = 6;
            IdNote.Name = "IdNote";
            IdNote.ReadOnly = true;
            IdNote.Visible = false;
            // 
            // Day
            // 
            Day.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Day.DataPropertyName = "ConsultationTime";
            Day.HeaderText = "Время консультации";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            Day.ReadOnly = true;
            Day.Width = 167;
            // 
            // Student
            // 
            Student.DataPropertyName = "StudentFullName";
            Student.HeaderText = "Студент";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Subject
            // 
            Subject.DataPropertyName = "ConstSubject";
            Subject.HeaderText = "Предмет консультации";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 394);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Записи";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxFullName);
            groupBox2.Controls.Add(textBoxSubj);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonAddConsultation);
            groupBox2.Location = new Point(639, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 359);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Запись на консультацию";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(185, 153);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(151, 27);
            textBoxFullName.TabIndex = 12;
            // 
            // textBoxSubj
            // 
            textBoxSubj.Location = new Point(185, 218);
            textBoxSubj.Name = "textBoxSubj";
            textBoxSubj.Size = new Size(151, 27);
            textBoxSubj.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(185, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 221);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 8;
            label4.Text = "Предмет консультации:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 156);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 7;
            label3.Text = "Ф.И.О. студента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 96);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Время:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 47);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "День:";
            // 
            // buttonAddConsultation
            // 
            buttonAddConsultation.Location = new Point(154, 283);
            buttonAddConsultation.Name = "buttonAddConsultation";
            buttonAddConsultation.Size = new Size(94, 29);
            buttonAddConsultation.TabIndex = 4;
            buttonAddConsultation.Text = "Добавить";
            buttonAddConsultation.UseVisualStyleBackColor = true;
            buttonAddConsultation.Click += buttonAddConsultation_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(639, 380);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(207, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отменить консультацию";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 396);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 420);
            Controls.Add(panel1);
            Controls.Add(buttonCancel);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAddConsultation;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBoxSubj;
        private Button buttonCancel;
        private DataGridViewTextBoxColumn IdNote;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Subject;
        private TextBox textBoxFullName;
        private Panel panel1;
    }
}
