
namespace CourseEvaluation
{
    partial class FormCourseEvaluation
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFinResult = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFinalExam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListView();
            this.studentId = new System.Windows.Forms.ColumnHeader();
            this.firstName = new System.Windows.Forms.ColumnHeader();
            this.lastName = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.midTerm = new System.Windows.Forms.ColumnHeader();
            this.project = new System.Windows.Forms.ColumnHeader();
            this.finalExam = new System.Windows.Forms.ColumnHeader();
            this.finalGrade = new System.Windows.Forms.ColumnHeader();
            this.grpStudentInfo.SuspendLayout();
            this.grpEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Evaluation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.txtLastName);
            this.grpStudentInfo.Controls.Add(this.label5);
            this.grpStudentInfo.Controls.Add(this.txtEmail);
            this.grpStudentInfo.Controls.Add(this.label4);
            this.grpStudentInfo.Controls.Add(this.txtFirstName);
            this.grpStudentInfo.Controls.Add(this.label3);
            this.grpStudentInfo.Controls.Add(this.txtStudentId);
            this.grpStudentInfo.Controls.Add(this.label2);
            this.grpStudentInfo.Location = new System.Drawing.Point(33, 130);
            this.grpStudentInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStudentInfo.Size = new System.Drawing.Size(410, 285);
            this.grpStudentInfo.TabIndex = 1;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Student Information";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(27, 193);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(141, 31);
            this.txtLastName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(234, 193);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(234, 97);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(27, 97);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(141, 31);
            this.txtStudentId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Number";
            // 
            // grpEvaluation
            // 
            this.grpEvaluation.Controls.Add(this.btnCalculate);
            this.grpEvaluation.Controls.Add(this.lblFinResult);
            this.grpEvaluation.Controls.Add(this.txtProject);
            this.grpEvaluation.Controls.Add(this.label8);
            this.grpEvaluation.Controls.Add(this.txtFinalExam);
            this.grpEvaluation.Controls.Add(this.label9);
            this.grpEvaluation.Controls.Add(this.label7);
            this.grpEvaluation.Controls.Add(this.txtMidterm);
            this.grpEvaluation.Controls.Add(this.label6);
            this.grpEvaluation.Location = new System.Drawing.Point(451, 130);
            this.grpEvaluation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEvaluation.Size = new System.Drawing.Size(514, 285);
            this.grpEvaluation.TabIndex = 2;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "Evaluation Components";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(246, 187);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 53);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFinResult
            // 
            this.lblFinResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinResult.ForeColor = System.Drawing.Color.Red;
            this.lblFinResult.Location = new System.Drawing.Point(9, 193);
            this.lblFinResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinResult.Name = "lblFinResult";
            this.lblFinResult.Size = new System.Drawing.Size(151, 45);
            this.lblFinResult.TabIndex = 2;
            this.lblFinResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(194, 97);
            this.txtProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(141, 31);
            this.txtProject.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Project (30%)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtFinalExam
            // 
            this.txtFinalExam.Location = new System.Drawing.Point(364, 97);
            this.txtFinalExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFinalExam.Name = "txtFinalExam";
            this.txtFinalExam.Size = new System.Drawing.Size(141, 31);
            this.txtFinalExam.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Final Exam (40%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Final Result";
            // 
            // txtMidterm
            // 
            this.txtMidterm.Location = new System.Drawing.Point(9, 97);
            this.txtMidterm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(141, 31);
            this.txtMidterm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "MIdterm (30%)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1013, 150);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 42);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1013, 222);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(1013, 288);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(113, 42);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "&List";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1013, 368);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lstInfo
            // 
            this.lstInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentId,
            this.firstName,
            this.lastName,
            this.email,
            this.midTerm,
            this.project,
            this.finalExam,
            this.finalGrade});
            this.lstInfo.GridLines = true;
            this.lstInfo.HideSelection = false;
            this.lstInfo.Location = new System.Drawing.Point(33, 660);
            this.lstInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(1091, 216);
            this.lstInfo.TabIndex = 4;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            // 
            // studentId
            // 
            this.studentId.Text = "Student Number";
            this.studentId.Width = 180;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 150;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 200;
            // 
            // midTerm
            // 
            this.midTerm.Text = "Midterm";
            this.midTerm.Width = 100;
            // 
            // project
            // 
            this.project.Text = "Project";
            this.project.Width = 100;
            // 
            // finalExam
            // 
            this.finalExam.Text = "Final Exam";
            this.finalExam.Width = 100;
            // 
            // finalGrade
            // 
            this.finalGrade.Text = "Final Grde";
            this.finalGrade.Width = 100;
            // 
            // FormCourseEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 920);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpEvaluation);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCourseEvaluation";
            this.Text = "CourseEvaluation";
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFinResult;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFinalExam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.ColumnHeader studentId;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader midTerm;
        private System.Windows.Forms.ColumnHeader project;
        private System.Windows.Forms.ColumnHeader finalExam;
        private System.Windows.Forms.ColumnHeader finalGrade;
    }
}