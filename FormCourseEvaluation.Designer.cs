
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFinalExam = new System.Windows.Forms.TextBox();
            this.lblFinResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpStudentInfo.SuspendLayout();
            this.grpEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 48);
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
            this.grpStudentInfo.Location = new System.Drawing.Point(43, 78);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(287, 171);
            this.grpStudentInfo.TabIndex = 1;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Number";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(19, 58);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 23);
            this.txtStudentId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(164, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(19, 116);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 3;
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
            this.grpEvaluation.Location = new System.Drawing.Point(336, 78);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Size = new System.Drawing.Size(360, 171);
            this.grpEvaluation.TabIndex = 2;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "Evaluation Components";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "MIdterm (30%)";
            // 
            // txtMidterm
            // 
            this.txtMidterm.Location = new System.Drawing.Point(6, 58);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(100, 23);
            this.txtMidterm.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Final Result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Project (30%)";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(136, 58);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 23);
            this.txtProject.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Final Exam (40%)";
            // 
            // txtFinalExam
            // 
            this.txtFinalExam.Location = new System.Drawing.Point(255, 58);
            this.txtFinalExam.Name = "txtFinalExam";
            this.txtFinalExam.Size = new System.Drawing.Size(100, 23);
            this.txtFinalExam.TabIndex = 1;
            // 
            // lblFinResult
            // 
            this.lblFinResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinResult.ForeColor = System.Drawing.Color.Red;
            this.lblFinResult.Location = new System.Drawing.Point(6, 116);
            this.lblFinResult.Name = "lblFinResult";
            this.lblFinResult.Size = new System.Drawing.Size(106, 28);
            this.lblFinResult.TabIndex = 2;
            this.lblFinResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(172, 112);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 32);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // CourseEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.grpEvaluation);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.label1);
            this.Name = "CourseEvaluation";
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
    }
}