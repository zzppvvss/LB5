namespace LB5
{
  partial class FORMA
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
            this.standartStudyProcess = new System.Windows.Forms.Button();
            this.vacation = new System.Windows.Forms.Button();
            this.vstup = new System.Windows.Forms.Button();
            this.teachers = new System.Windows.Forms.GroupBox();
            this.teachersGrid = new System.Windows.Forms.DataGridView();
            this.students = new System.Windows.Forms.GroupBox();
            this.studentsGrid = new System.Windows.Forms.DataGridView();
            this.modeText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.regime = new System.Windows.Forms.GroupBox();
            this.teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGrid)).BeginInit();
            this.students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.regime.SuspendLayout();
            this.SuspendLayout();
            // 
            // standartStudyProcess
            // 
            this.standartStudyProcess.BackColor = System.Drawing.Color.DarkKhaki;
            this.standartStudyProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standartStudyProcess.Location = new System.Drawing.Point(27, 239);
            this.standartStudyProcess.Name = "standartStudyProcess";
            this.standartStudyProcess.Size = new System.Drawing.Size(165, 52);
            this.standartStudyProcess.TabIndex = 6;
            this.standartStudyProcess.Text = "Проведення занять";
            this.standartStudyProcess.UseVisualStyleBackColor = false;
            this.standartStudyProcess.Click += new System.EventHandler(this.standartStudyOnClick);
            // 
            // vacation
            // 
            this.vacation.BackColor = System.Drawing.Color.Coral;
            this.vacation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacation.Location = new System.Drawing.Point(27, 433);
            this.vacation.Name = "vacation";
            this.vacation.Size = new System.Drawing.Size(165, 52);
            this.vacation.TabIndex = 5;
            this.vacation.Text = "Сезон Відпусток";
            this.vacation.UseVisualStyleBackColor = false;
            this.vacation.Click += new System.EventHandler(this.vidpustkaOnclick);
            // 
            // vstup
            // 
            this.vstup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vstup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vstup.Location = new System.Drawing.Point(27, 65);
            this.vstup.Name = "vstup";
            this.vstup.Size = new System.Drawing.Size(165, 52);
            this.vstup.TabIndex = 4;
            this.vstup.Text = "Вступна компанія";
            this.vstup.UseVisualStyleBackColor = false;
            this.vstup.Click += new System.EventHandler(this.vstupOnClick);
            // 
            // teachers
            // 
            this.teachers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teachers.Controls.Add(this.teachersGrid);
            this.teachers.Location = new System.Drawing.Point(6, 43);
            this.teachers.Name = "teachers";
            this.teachers.Size = new System.Drawing.Size(539, 470);
            this.teachers.TabIndex = 0;
            this.teachers.TabStop = false;
            this.teachers.Text = "Вчителі";
            // 
            // teachersGrid
            // 
            this.teachersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachersGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.teachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersGrid.Location = new System.Drawing.Point(6, 22);
            this.teachersGrid.Name = "teachersGrid";
            this.teachersGrid.ReadOnly = true;
            this.teachersGrid.RowTemplate.Height = 25;
            this.teachersGrid.Size = new System.Drawing.Size(526, 440);
            this.teachersGrid.TabIndex = 0;
            // 
            // students
            // 
            this.students.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.students.Controls.Add(this.groupBox2);
            this.students.Controls.Add(this.studentsGrid);
            this.students.Location = new System.Drawing.Point(593, 43);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(519, 470);
            this.students.TabIndex = 1;
            this.students.TabStop = false;
            this.students.Text = "Студенти";
            // 
            // studentsGrid
            // 
            this.studentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGrid.Location = new System.Drawing.Point(6, 22);
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.ReadOnly = true;
            this.studentsGrid.RowTemplate.Height = 25;
            this.studentsGrid.Size = new System.Drawing.Size(507, 440);
            this.studentsGrid.TabIndex = 0;
            // 
            // modeText
            // 
            this.modeText.AutoSize = true;
            this.modeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modeText.Location = new System.Drawing.Point(531, 19);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(14, 21);
            this.modeText.TabIndex = 3;
            this.modeText.Text = " ";
            this.modeText.Click += new System.EventHandler(this.modeText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modeText);
            this.groupBox1.Controls.Add(this.students);
            this.groupBox1.Controls.Add(this.teachers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 509);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Location = new System.Drawing.Point(531, -34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 331);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Студенти";
            // 
            // regime
            // 
            this.regime.Controls.Add(this.vstup);
            this.regime.Controls.Add(this.vacation);
            this.regime.Controls.Add(this.standartStudyProcess);
            this.regime.Location = new System.Drawing.Point(1142, 12);
            this.regime.Name = "regime";
            this.regime.Size = new System.Drawing.Size(216, 509);
            this.regime.TabIndex = 7;
            this.regime.TabStop = false;
            this.regime.Text = "РЕЖИМИ";
            // 
            // FORMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1376, 538);
            this.Controls.Add(this.regime);
            this.Controls.Add(this.groupBox1);
            this.Name = "FORMA";
            this.Text = "LB5 -- Korovina";
            this.Load += new System.EventHandler(this.FAORMALoading);
            this.teachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersGrid)).EndInit();
            this.students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.regime.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private Button vstup;
    private Button vacation;
    private Button standartStudyProcess;
        private GroupBox teachers;
        private DataGridView teachersGrid;
        private GroupBox students;
        private DataGridView studentsGrid;
        private Label modeText;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox regime;
    }
}