namespace AccuracyProgram
{
    partial class ResultForm2
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
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.saveResultImage = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dGraphControl = new ZedGraph.ZedGraphControl();
            this.dMinBox = new System.Windows.Forms.TextBox();
            this.testSerial = new System.Windows.Forms.TextBox();
            this.dMaxBox = new System.Windows.Forms.TextBox();
            this.dStdBox = new System.Windows.Forms.TextBox();
            this.testModel = new System.Windows.Forms.TextBox();
            this.testDate = new System.Windows.Forms.TextBox();
            this.testName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveResultData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1120, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 34);
            this.label11.TabIndex = 96;
            this.label11.Text = "Distance";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveResultImage
            // 
            this.saveResultImage.Location = new System.Drawing.Point(1261, 854);
            this.saveResultImage.Name = "saveResultImage";
            this.saveResultImage.Size = new System.Drawing.Size(131, 54);
            this.saveResultImage.TabIndex = 93;
            this.saveResultImage.Text = "결과화면저장";
            this.saveResultImage.UseVisualStyleBackColor = true;
            this.saveResultImage.Click += new System.EventHandler(this.saveResultImage_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1261, 914);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(131, 54);
            this.closeBtn.TabIndex = 92;
            this.closeBtn.Text = "닫기";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dGraphControl
            // 
            this.dGraphControl.Location = new System.Drawing.Point(20, 260);
            this.dGraphControl.Name = "dGraphControl";
            this.dGraphControl.ScrollGrace = 0D;
            this.dGraphControl.ScrollMaxX = 0D;
            this.dGraphControl.ScrollMaxY = 0D;
            this.dGraphControl.ScrollMaxY2 = 0D;
            this.dGraphControl.ScrollMinX = 0D;
            this.dGraphControl.ScrollMinY = 0D;
            this.dGraphControl.ScrollMinY2 = 0D;
            this.dGraphControl.Size = new System.Drawing.Size(1201, 685);
            this.dGraphControl.TabIndex = 89;
            this.dGraphControl.UseExtendedPrintDialog = true;
            // 
            // dMinBox
            // 
            this.dMinBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.dMinBox.Location = new System.Drawing.Point(1120, 161);
            this.dMinBox.Name = "dMinBox";
            this.dMinBox.Size = new System.Drawing.Size(100, 33);
            this.dMinBox.TabIndex = 86;
            this.dMinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // testSerial
            // 
            this.testSerial.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testSerial.Location = new System.Drawing.Point(121, 194);
            this.testSerial.Name = "testSerial";
            this.testSerial.Size = new System.Drawing.Size(281, 33);
            this.testSerial.TabIndex = 82;
            // 
            // dMaxBox
            // 
            this.dMaxBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.dMaxBox.Location = new System.Drawing.Point(1120, 127);
            this.dMaxBox.Name = "dMaxBox";
            this.dMaxBox.Size = new System.Drawing.Size(100, 33);
            this.dMaxBox.TabIndex = 87;
            this.dMaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dStdBox
            // 
            this.dStdBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.dStdBox.Location = new System.Drawing.Point(1120, 196);
            this.dStdBox.Name = "dStdBox";
            this.dStdBox.Size = new System.Drawing.Size(100, 33);
            this.dStdBox.TabIndex = 73;
            this.dStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // testModel
            // 
            this.testModel.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testModel.Location = new System.Drawing.Point(121, 160);
            this.testModel.Name = "testModel";
            this.testModel.Size = new System.Drawing.Size(281, 33);
            this.testModel.TabIndex = 75;
            // 
            // testDate
            // 
            this.testDate.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testDate.Location = new System.Drawing.Point(121, 125);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(281, 33);
            this.testDate.TabIndex = 80;
            // 
            // testName
            // 
            this.testName.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testName.Location = new System.Drawing.Point(121, 91);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(281, 33);
            this.testName.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1015, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 34);
            this.label8.TabIndex = 65;
            this.label8.Text = "최소값";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 34);
            this.label4.TabIndex = 66;
            this.label4.Text = "시리얼번호";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("나눔바른고딕", 32F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(475, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 59);
            this.label12.TabIndex = 67;
            this.label12.Text = "Result";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1015, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 34);
            this.label7.TabIndex = 71;
            this.label7.Text = "최대값";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 69;
            this.label3.Text = "모델명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1015, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 34);
            this.label6.TabIndex = 70;
            this.label6.Text = "표준편차";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 68;
            this.label2.Text = "검사일자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 64;
            this.label1.Text = "검사항목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.testName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dGraphControl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dMinBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.testSerial);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dMaxBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dStdBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.testModel);
            this.panel1.Controls.Add(this.testDate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 954);
            this.panel1.TabIndex = 97;
            // 
            // saveResultData
            // 
            this.saveResultData.Location = new System.Drawing.Point(1261, 794);
            this.saveResultData.Name = "saveResultData";
            this.saveResultData.Size = new System.Drawing.Size(131, 54);
            this.saveResultData.TabIndex = 98;
            this.saveResultData.Text = "결과데이터저장";
            this.saveResultData.UseVisualStyleBackColor = true;
            this.saveResultData.Click += new System.EventHandler(this.saveResultData_Click);
            // 
            // ResultForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 976);
            this.Controls.Add(this.saveResultData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveResultImage);
            this.Controls.Add(this.closeBtn);
            this.Name = "ResultForm2";
            this.Text = "ResultForm2";
            this.Load += new System.EventHandler(this.ResultForm2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveResultImage;
        private System.Windows.Forms.Button closeBtn;
        private ZedGraph.ZedGraphControl dGraphControl;
        private System.Windows.Forms.TextBox dMinBox;
        private System.Windows.Forms.TextBox testSerial;
        private System.Windows.Forms.TextBox dMaxBox;
        private System.Windows.Forms.TextBox dStdBox;
        private System.Windows.Forms.TextBox testModel;
        private System.Windows.Forms.TextBox testDate;
        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveResultData;
    }
}