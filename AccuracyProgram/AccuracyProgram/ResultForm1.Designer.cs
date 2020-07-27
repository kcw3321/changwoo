namespace AccuracyProgram
{
    partial class ResultForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.TextBox();
            this.testDate = new System.Windows.Forms.TextBox();
            this.testModel = new System.Windows.Forms.TextBox();
            this.testSerial = new System.Windows.Forms.TextBox();
            this.yGraphControl = new ZedGraph.ZedGraphControl();
            this.dGraphControl = new ZedGraph.ZedGraphControl();
            this.zGraphControl = new ZedGraph.ZedGraphControl();
            this.xGraphControl = new ZedGraph.ZedGraphControl();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveResultImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xStdBox = new System.Windows.Forms.TextBox();
            this.xMaxBox = new System.Windows.Forms.TextBox();
            this.xMinBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yStdBox = new System.Windows.Forms.TextBox();
            this.yMaxBox = new System.Windows.Forms.TextBox();
            this.yMinBox = new System.Windows.Forms.TextBox();
            this.zStdBox = new System.Windows.Forms.TextBox();
            this.zMaxBox = new System.Windows.Forms.TextBox();
            this.zMinBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dStdBox = new System.Windows.Forms.TextBox();
            this.dMaxBox = new System.Windows.Forms.TextBox();
            this.dMinBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveResultData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "검사항목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 40;
            this.label2.Text = "검사일자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "모델명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "시리얼번호";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // testName
            // 
            this.testName.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testName.Location = new System.Drawing.Point(118, 87);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(281, 33);
            this.testName.TabIndex = 41;
            // 
            // testDate
            // 
            this.testDate.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testDate.Location = new System.Drawing.Point(118, 121);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(281, 33);
            this.testDate.TabIndex = 41;
            // 
            // testModel
            // 
            this.testModel.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testModel.Location = new System.Drawing.Point(118, 156);
            this.testModel.Name = "testModel";
            this.testModel.Size = new System.Drawing.Size(281, 33);
            this.testModel.TabIndex = 41;
            // 
            // testSerial
            // 
            this.testSerial.Font = new System.Drawing.Font("굴림", 16.5F);
            this.testSerial.Location = new System.Drawing.Point(118, 190);
            this.testSerial.Name = "testSerial";
            this.testSerial.Size = new System.Drawing.Size(281, 33);
            this.testSerial.TabIndex = 41;
            // 
            // yGraphControl
            // 
            this.yGraphControl.Location = new System.Drawing.Point(633, 257);
            this.yGraphControl.Name = "yGraphControl";
            this.yGraphControl.ScrollGrace = 0D;
            this.yGraphControl.ScrollMaxX = 0D;
            this.yGraphControl.ScrollMaxY = 0D;
            this.yGraphControl.ScrollMaxY2 = 0D;
            this.yGraphControl.ScrollMinX = 0D;
            this.yGraphControl.ScrollMinY = 0D;
            this.yGraphControl.ScrollMinY2 = 0D;
            this.yGraphControl.Size = new System.Drawing.Size(585, 339);
            this.yGraphControl.TabIndex = 56;
            this.yGraphControl.UseExtendedPrintDialog = true;
            // 
            // dGraphControl
            // 
            this.dGraphControl.Location = new System.Drawing.Point(633, 602);
            this.dGraphControl.Name = "dGraphControl";
            this.dGraphControl.ScrollGrace = 0D;
            this.dGraphControl.ScrollMaxX = 0D;
            this.dGraphControl.ScrollMaxY = 0D;
            this.dGraphControl.ScrollMaxY2 = 0D;
            this.dGraphControl.ScrollMinX = 0D;
            this.dGraphControl.ScrollMinY = 0D;
            this.dGraphControl.ScrollMinY2 = 0D;
            this.dGraphControl.Size = new System.Drawing.Size(585, 339);
            this.dGraphControl.TabIndex = 57;
            this.dGraphControl.UseExtendedPrintDialog = true;
            // 
            // zGraphControl
            // 
            this.zGraphControl.Location = new System.Drawing.Point(17, 602);
            this.zGraphControl.Name = "zGraphControl";
            this.zGraphControl.ScrollGrace = 0D;
            this.zGraphControl.ScrollMaxX = 0D;
            this.zGraphControl.ScrollMaxY = 0D;
            this.zGraphControl.ScrollMaxY2 = 0D;
            this.zGraphControl.ScrollMinX = 0D;
            this.zGraphControl.ScrollMinY = 0D;
            this.zGraphControl.ScrollMinY2 = 0D;
            this.zGraphControl.Size = new System.Drawing.Size(585, 339);
            this.zGraphControl.TabIndex = 58;
            this.zGraphControl.UseExtendedPrintDialog = true;
            // 
            // xGraphControl
            // 
            this.xGraphControl.Location = new System.Drawing.Point(17, 257);
            this.xGraphControl.Name = "xGraphControl";
            this.xGraphControl.ScrollGrace = 0D;
            this.xGraphControl.ScrollMaxX = 0D;
            this.xGraphControl.ScrollMaxY = 0D;
            this.xGraphControl.ScrollMaxY2 = 0D;
            this.xGraphControl.ScrollMinX = 0D;
            this.xGraphControl.ScrollMinY = 0D;
            this.xGraphControl.ScrollMinY2 = 0D;
            this.xGraphControl.Size = new System.Drawing.Size(585, 339);
            this.xGraphControl.TabIndex = 59;
            this.xGraphControl.UseExtendedPrintDialog = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1267, 897);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(131, 54);
            this.closeBtn.TabIndex = 60;
            this.closeBtn.Text = "닫기";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveResultImage
            // 
            this.saveResultImage.Location = new System.Drawing.Point(1267, 837);
            this.saveResultImage.Name = "saveResultImage";
            this.saveResultImage.Size = new System.Drawing.Size(131, 54);
            this.saveResultImage.TabIndex = 60;
            this.saveResultImage.Text = "결과화면저장";
            this.saveResultImage.UseVisualStyleBackColor = true;
            this.saveResultImage.Click += new System.EventHandler(this.saveResultImage_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(703, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 34);
            this.label6.TabIndex = 40;
            this.label6.Text = "표준편차";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(703, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 34);
            this.label7.TabIndex = 40;
            this.label7.Text = "최대값";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(703, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 34);
            this.label8.TabIndex = 40;
            this.label8.Text = "최소값";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xStdBox
            // 
            this.xStdBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.xStdBox.Location = new System.Drawing.Point(808, 192);
            this.xStdBox.Name = "xStdBox";
            this.xStdBox.Size = new System.Drawing.Size(100, 33);
            this.xStdBox.TabIndex = 41;
            this.xStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xMaxBox
            // 
            this.xMaxBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.xMaxBox.Location = new System.Drawing.Point(808, 123);
            this.xMaxBox.Name = "xMaxBox";
            this.xMaxBox.Size = new System.Drawing.Size(100, 33);
            this.xMaxBox.TabIndex = 41;
            this.xMaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xMinBox
            // 
            this.xMinBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.xMinBox.Location = new System.Drawing.Point(808, 157);
            this.xMinBox.Name = "xMinBox";
            this.xMinBox.Size = new System.Drawing.Size(100, 33);
            this.xMinBox.TabIndex = 41;
            this.xMinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1014, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 34);
            this.label9.TabIndex = 62;
            this.label9.Text = "Z";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(911, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 34);
            this.label5.TabIndex = 63;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(808, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 34);
            this.label10.TabIndex = 61;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yStdBox
            // 
            this.yStdBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.yStdBox.Location = new System.Drawing.Point(911, 192);
            this.yStdBox.Name = "yStdBox";
            this.yStdBox.Size = new System.Drawing.Size(100, 33);
            this.yStdBox.TabIndex = 41;
            this.yStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yMaxBox
            // 
            this.yMaxBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.yMaxBox.Location = new System.Drawing.Point(911, 123);
            this.yMaxBox.Name = "yMaxBox";
            this.yMaxBox.Size = new System.Drawing.Size(100, 33);
            this.yMaxBox.TabIndex = 41;
            this.yMaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yMinBox
            // 
            this.yMinBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.yMinBox.Location = new System.Drawing.Point(911, 157);
            this.yMinBox.Name = "yMinBox";
            this.yMinBox.Size = new System.Drawing.Size(100, 33);
            this.yMinBox.TabIndex = 41;
            this.yMinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zStdBox
            // 
            this.zStdBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.zStdBox.Location = new System.Drawing.Point(1014, 193);
            this.zStdBox.Name = "zStdBox";
            this.zStdBox.Size = new System.Drawing.Size(100, 33);
            this.zStdBox.TabIndex = 41;
            this.zStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zMaxBox
            // 
            this.zMaxBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.zMaxBox.Location = new System.Drawing.Point(1014, 124);
            this.zMaxBox.Name = "zMaxBox";
            this.zMaxBox.Size = new System.Drawing.Size(100, 33);
            this.zMaxBox.TabIndex = 41;
            this.zMaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zMinBox
            // 
            this.zMinBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.zMinBox.Location = new System.Drawing.Point(1014, 158);
            this.zMinBox.Name = "zMinBox";
            this.zMinBox.Size = new System.Drawing.Size(100, 33);
            this.zMinBox.TabIndex = 41;
            this.zMinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1117, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 34);
            this.label11.TabIndex = 62;
            this.label11.Text = "Distance";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dStdBox
            // 
            this.dStdBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.dStdBox.Location = new System.Drawing.Point(1117, 192);
            this.dStdBox.Name = "dStdBox";
            this.dStdBox.Size = new System.Drawing.Size(100, 33);
            this.dStdBox.TabIndex = 41;
            this.dStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dMaxBox
            // 
            this.dMaxBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.dMaxBox.Location = new System.Drawing.Point(1117, 123);
            this.dMaxBox.Name = "dMaxBox";
            this.dMaxBox.Size = new System.Drawing.Size(100, 33);
            this.dMaxBox.TabIndex = 41;
            this.dMaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dMinBox
            // 
            this.dMinBox.Font = new System.Drawing.Font("굴림", 16.5F);
            this.dMinBox.Location = new System.Drawing.Point(1117, 157);
            this.dMinBox.Name = "dMinBox";
            this.dMinBox.Size = new System.Drawing.Size(100, 33);
            this.dMinBox.TabIndex = 41;
            this.dMinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("나눔바른고딕", 32F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(472, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 59);
            this.label12.TabIndex = 40;
            this.label12.Text = "Result";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.yGraphControl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dGraphControl);
            this.panel1.Controls.Add(this.testName);
            this.panel1.Controls.Add(this.zGraphControl);
            this.panel1.Controls.Add(this.testDate);
            this.panel1.Controls.Add(this.xGraphControl);
            this.panel1.Controls.Add(this.xStdBox);
            this.panel1.Controls.Add(this.dMinBox);
            this.panel1.Controls.Add(this.testModel);
            this.panel1.Controls.Add(this.zMinBox);
            this.panel1.Controls.Add(this.yStdBox);
            this.panel1.Controls.Add(this.yMinBox);
            this.panel1.Controls.Add(this.xMaxBox);
            this.panel1.Controls.Add(this.xMinBox);
            this.panel1.Controls.Add(this.zStdBox);
            this.panel1.Controls.Add(this.testSerial);
            this.panel1.Controls.Add(this.yMaxBox);
            this.panel1.Controls.Add(this.dMaxBox);
            this.panel1.Controls.Add(this.dStdBox);
            this.panel1.Controls.Add(this.zMaxBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 946);
            this.panel1.TabIndex = 64;
            // 
            // saveResultData
            // 
            this.saveResultData.Location = new System.Drawing.Point(1267, 777);
            this.saveResultData.Name = "saveResultData";
            this.saveResultData.Size = new System.Drawing.Size(131, 54);
            this.saveResultData.TabIndex = 60;
            this.saveResultData.Text = "결과데이터저장";
            this.saveResultData.UseVisualStyleBackColor = true;
            this.saveResultData.Click += new System.EventHandler(this.saveResultData_Click);
            // 
            // ResultForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 959);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveResultData);
            this.Controls.Add(this.saveResultImage);
            this.Controls.Add(this.closeBtn);
            this.Name = "ResultForm1";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.TextBox testDate;
        private System.Windows.Forms.TextBox testModel;
        private System.Windows.Forms.TextBox testSerial;
        private ZedGraph.ZedGraphControl yGraphControl;
        private ZedGraph.ZedGraphControl dGraphControl;
        private ZedGraph.ZedGraphControl zGraphControl;
        private ZedGraph.ZedGraphControl xGraphControl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveResultImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xStdBox;
        private System.Windows.Forms.TextBox xMaxBox;
        private System.Windows.Forms.TextBox xMinBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yStdBox;
        private System.Windows.Forms.TextBox yMaxBox;
        private System.Windows.Forms.TextBox yMinBox;
        private System.Windows.Forms.TextBox zStdBox;
        private System.Windows.Forms.TextBox zMaxBox;
        private System.Windows.Forms.TextBox zMinBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dStdBox;
        private System.Windows.Forms.TextBox dMaxBox;
        private System.Windows.Forms.TextBox dMinBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveResultData;
    }
}