namespace Lab1HealthClub
{
    partial class frmMain
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
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSeniorCitizen = new System.Windows.Forms.RadioButton();
            this.grType = new System.Windows.Forms.GroupBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkPersonalTri = new System.Windows.Forms.CheckBox();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.lblNumberofMembers = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.gbMembershipLength = new System.Windows.Forms.GroupBox();
            this.lblMonthelyfee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbMemberFee = new System.Windows.Forms.GroupBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblMonFee = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grType.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.gbMembershipLength.SuspendLayout();
            this.gbMemberFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(21, 24);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(148, 25);
            this.radAdult.TabIndex = 0;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult ";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(21, 47);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(152, 25);
            this.radChild.TabIndex = 1;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child(12 & Under)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(21, 70);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(88, 25);
            this.radStudent.TabIndex = 2;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radSeniorCitizen
            // 
            this.radSeniorCitizen.AutoSize = true;
            this.radSeniorCitizen.Location = new System.Drawing.Point(21, 93);
            this.radSeniorCitizen.Name = "radSeniorCitizen";
            this.radSeniorCitizen.Size = new System.Drawing.Size(135, 25);
            this.radSeniorCitizen.TabIndex = 3;
            this.radSeniorCitizen.TabStop = true;
            this.radSeniorCitizen.Text = "Senior_Citizen";
            this.radSeniorCitizen.UseVisualStyleBackColor = true;
            // 
            // grType
            // 
            this.grType.Controls.Add(this.radSeniorCitizen);
            this.grType.Controls.Add(this.radStudent);
            this.grType.Controls.Add(this.radChild);
            this.grType.Controls.Add(this.radAdult);
            this.grType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grType.Location = new System.Drawing.Point(46, 40);
            this.grType.Name = "grType";
            this.grType.Size = new System.Drawing.Size(200, 131);
            this.grType.TabIndex = 4;
            this.grType.TabStop = false;
            this.grType.Text = "Type of Membership";
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(29, 25);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(68, 25);
            this.chkYoga.TabIndex = 5;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(29, 56);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(78, 25);
            this.chkKarate.TabIndex = 6;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkPersonalTri
            // 
            this.chkPersonalTri.AutoSize = true;
            this.chkPersonalTri.Location = new System.Drawing.Point(29, 87);
            this.chkPersonalTri.Name = "chkPersonalTri";
            this.chkPersonalTri.Size = new System.Drawing.Size(152, 25);
            this.chkPersonalTri.TabIndex = 7;
            this.chkPersonalTri.Text = "Personal Trainer";
            this.chkPersonalTri.UseVisualStyleBackColor = true;
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.chkKarate);
            this.gbOption.Controls.Add(this.chkPersonalTri);
            this.gbOption.Controls.Add(this.chkYoga);
            this.gbOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOption.Location = new System.Drawing.Point(262, 40);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(234, 131);
            this.gbOption.TabIndex = 8;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Options";
            // 
            // lblNumberofMembers
            // 
            this.lblNumberofMembers.AutoSize = true;
            this.lblNumberofMembers.Location = new System.Drawing.Point(23, 31);
            this.lblNumberofMembers.Name = "lblNumberofMembers";
            this.lblNumberofMembers.Size = new System.Drawing.Size(153, 42);
            this.lblNumberofMembers.TabIndex = 9;
            this.lblNumberofMembers.Text = "Enter the Number \r\nof Months:";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(27, 76);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(140, 28);
            this.txtMonths.TabIndex = 10;
            // 
            // gbMembershipLength
            // 
            this.gbMembershipLength.Controls.Add(this.txtMonths);
            this.gbMembershipLength.Controls.Add(this.lblNumberofMembers);
            this.gbMembershipLength.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMembershipLength.Location = new System.Drawing.Point(46, 200);
            this.gbMembershipLength.Name = "gbMembershipLength";
            this.gbMembershipLength.Size = new System.Drawing.Size(200, 130);
            this.gbMembershipLength.TabIndex = 11;
            this.gbMembershipLength.TabStop = false;
            this.gbMembershipLength.Text = "Membership Length";
            // 
            // lblMonthelyfee
            // 
            this.lblMonthelyfee.AutoSize = true;
            this.lblMonthelyfee.Location = new System.Drawing.Point(31, 38);
            this.lblMonthelyfee.Name = "lblMonthelyfee";
            this.lblMonthelyfee.Size = new System.Drawing.Size(120, 21);
            this.lblMonthelyfee.TabIndex = 12;
            this.lblMonthelyfee.Text = "Monthly Fee : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(89, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 21);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total : ";
            // 
            // gbMemberFee
            // 
            this.gbMemberFee.Controls.Add(this.lblTotalFee);
            this.gbMemberFee.Controls.Add(this.lblMonFee);
            this.gbMemberFee.Controls.Add(this.lblMonthelyfee);
            this.gbMemberFee.Controls.Add(this.lblTotal);
            this.gbMemberFee.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemberFee.Location = new System.Drawing.Point(262, 200);
            this.gbMemberFee.Name = "gbMemberFee";
            this.gbMemberFee.Size = new System.Drawing.Size(234, 130);
            this.gbMemberFee.TabIndex = 16;
            this.gbMemberFee.TabStop = false;
            this.gbMemberFee.Text = "Membership Fees";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(157, 76);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(35, 21);
            this.lblTotalFee.TabIndex = 21;
            this.lblTotalFee.Text = "Tot";
            // 
            // lblMonFee
            // 
            this.lblMonFee.AutoSize = true;
            this.lblMonFee.Location = new System.Drawing.Point(157, 38);
            this.lblMonFee.Name = "lblMonFee";
            this.lblMonFee.Size = new System.Drawing.Size(42, 21);
            this.lblMonFee.TabIndex = 20;
            this.lblMonFee.Text = "Fee ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(67, 336);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 39);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(220, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 39);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(364, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 39);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbMemberFee);
            this.Controls.Add(this.gbMembershipLength);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.grType);
            this.Name = "frmMain";
            this.Text = "MemberShip Fee Calculator";
            this.grType.ResumeLayout(false);
            this.grType.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.gbMembershipLength.ResumeLayout(false);
            this.gbMembershipLength.PerformLayout();
            this.gbMemberFee.ResumeLayout(false);
            this.gbMemberFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSeniorCitizen;
        private System.Windows.Forms.GroupBox grType;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkPersonalTri;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.Label lblNumberofMembers;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.GroupBox gbMembershipLength;
        private System.Windows.Forms.Label lblMonthelyfee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbMemberFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblMonFee;
    }
}

