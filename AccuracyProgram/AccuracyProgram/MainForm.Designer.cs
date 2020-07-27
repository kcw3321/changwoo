namespace AccuracyProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stopAccuracyTimer = new System.Windows.Forms.Timer(this.components);
            this.straightAccuracyTimer = new System.Windows.Forms.Timer(this.components);
            this.vibeAccurayTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.yGraphControl = new ZedGraph.ZedGraphControl();
            this.dGraphControl = new ZedGraph.ZedGraphControl();
            this.zGraphControl = new ZedGraph.ZedGraphControl();
            this.xGraphControl = new ZedGraph.ZedGraphControl();
            this.countCycle = new System.Windows.Forms.NumericUpDown();
            this.countData = new System.Windows.Forms.NumericUpDown();
            this.zBaundaryBox = new System.Windows.Forms.NumericUpDown();
            this.yBaundaryBox = new System.Windows.Forms.NumericUpDown();
            this.xBaundaryBox = new System.Windows.Forms.NumericUpDown();
            this.enterInterval = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentCountCycleBox = new System.Windows.Forms.TextBox();
            this.dStdBox = new System.Windows.Forms.TextBox();
            this.xMin = new System.Windows.Forms.TextBox();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.xStdBox = new System.Windows.Forms.TextBox();
            this.xMax = new System.Windows.Forms.TextBox();
            this.modelName = new System.Windows.Forms.TextBox();
            this.yMin = new System.Windows.Forms.TextBox();
            this.yStdBox = new System.Windows.Forms.TextBox();
            this.currentDate = new System.Windows.Forms.TextBox();
            this.yMax = new System.Windows.Forms.TextBox();
            this.zStdBox = new System.Windows.Forms.TextBox();
            this.dMin = new System.Windows.Forms.TextBox();
            this.zMin = new System.Windows.Forms.TextBox();
            this.dMax = new System.Windows.Forms.TextBox();
            this.zMax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveResultBtn = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.showResultBtn = new System.Windows.Forms.Button();
            this.loadResultData = new System.Windows.Forms.Button();
            this.stopVibeBtn = new System.Windows.Forms.Button();
            this.stopAccuracyBtn = new System.Windows.Forms.Button();
            this.stopStraightBtn = new System.Windows.Forms.Button();
            this.straightAccuracyStart = new System.Windows.Forms.Button();
            this.vibeAccuracyStart = new System.Windows.Forms.Button();
            this.stopAccuracyStart = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.originSetBtn = new System.Windows.Forms.Button();
            this.repeatRead = new System.Windows.Forms.Button();
            this.originCancelBtn = new System.Windows.Forms.Button();
            this.xValueBox = new System.Windows.Forms.TextBox();
            this.yValueBox = new System.Windows.Forms.TextBox();
            this.zValueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portOpen = new System.Windows.Forms.Button();
            this.portRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbComSelect = new System.Windows.Forms.ComboBox();
            this.repeatTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBaundaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBaundaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBaundaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // stopAccuracyTimer
            // 
            this.stopAccuracyTimer.Tick += new System.EventHandler(this.stopAccuracyTimer_Tick);
            // 
            // straightAccuracyTimer
            // 
            this.straightAccuracyTimer.Tick += new System.EventHandler(this.straightAccuracyTimer_Tick);
            // 
            // vibeAccurayTimer
            // 
            this.vibeAccurayTimer.Tick += new System.EventHandler(this.vibeAccurayTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yGraphControl);
            this.panel1.Controls.Add(this.dGraphControl);
            this.panel1.Controls.Add(this.zGraphControl);
            this.panel1.Controls.Add(this.xGraphControl);
            this.panel1.Controls.Add(this.countCycle);
            this.panel1.Controls.Add(this.countData);
            this.panel1.Controls.Add(this.zBaundaryBox);
            this.panel1.Controls.Add(this.yBaundaryBox);
            this.panel1.Controls.Add(this.xBaundaryBox);
            this.panel1.Controls.Add(this.enterInterval);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.currentCountCycleBox);
            this.panel1.Controls.Add(this.dStdBox);
            this.panel1.Controls.Add(this.xMin);
            this.panel1.Controls.Add(this.serialNumber);
            this.panel1.Controls.Add(this.xStdBox);
            this.panel1.Controls.Add(this.xMax);
            this.panel1.Controls.Add(this.modelName);
            this.panel1.Controls.Add(this.yMin);
            this.panel1.Controls.Add(this.yStdBox);
            this.panel1.Controls.Add(this.currentDate);
            this.panel1.Controls.Add(this.yMax);
            this.panel1.Controls.Add(this.zStdBox);
            this.panel1.Controls.Add(this.dMin);
            this.panel1.Controls.Add(this.zMin);
            this.panel1.Controls.Add(this.dMax);
            this.panel1.Controls.Add(this.zMax);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.saveResultBtn);
            this.panel1.Controls.Add(this.saveImage);
            this.panel1.Controls.Add(this.showResultBtn);
            this.panel1.Controls.Add(this.loadResultData);
            this.panel1.Controls.Add(this.stopVibeBtn);
            this.panel1.Controls.Add(this.stopAccuracyBtn);
            this.panel1.Controls.Add(this.stopStraightBtn);
            this.panel1.Controls.Add(this.straightAccuracyStart);
            this.panel1.Controls.Add(this.vibeAccuracyStart);
            this.panel1.Controls.Add(this.stopAccuracyStart);
            this.panel1.Controls.Add(this.readBtn);
            this.panel1.Controls.Add(this.originSetBtn);
            this.panel1.Controls.Add(this.repeatRead);
            this.panel1.Controls.Add(this.originCancelBtn);
            this.panel1.Controls.Add(this.xValueBox);
            this.panel1.Controls.Add(this.yValueBox);
            this.panel1.Controls.Add(this.zValueBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.portOpen);
            this.panel1.Controls.Add(this.portRefresh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbComSelect);
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 684);
            this.panel1.TabIndex = 56;
            // 
            // yGraphControl
            // 
            this.yGraphControl.Location = new System.Drawing.Point(852, 178);
            this.yGraphControl.Name = "yGraphControl";
            this.yGraphControl.ScrollGrace = 0D;
            this.yGraphControl.ScrollMaxX = 0D;
            this.yGraphControl.ScrollMaxY = 0D;
            this.yGraphControl.ScrollMaxY2 = 0D;
            this.yGraphControl.ScrollMinX = 0D;
            this.yGraphControl.ScrollMinY = 0D;
            this.yGraphControl.ScrollMinY2 = 0D;
            this.yGraphControl.Size = new System.Drawing.Size(460, 240);
            this.yGraphControl.TabIndex = 119;
            this.yGraphControl.UseExtendedPrintDialog = true;
            // 
            // dGraphControl
            // 
            this.dGraphControl.Location = new System.Drawing.Point(852, 424);
            this.dGraphControl.Name = "dGraphControl";
            this.dGraphControl.ScrollGrace = 0D;
            this.dGraphControl.ScrollMaxX = 0D;
            this.dGraphControl.ScrollMaxY = 0D;
            this.dGraphControl.ScrollMaxY2 = 0D;
            this.dGraphControl.ScrollMinX = 0D;
            this.dGraphControl.ScrollMinY = 0D;
            this.dGraphControl.ScrollMinY2 = 0D;
            this.dGraphControl.Size = new System.Drawing.Size(460, 240);
            this.dGraphControl.TabIndex = 120;
            this.dGraphControl.UseExtendedPrintDialog = true;
            // 
            // zGraphControl
            // 
            this.zGraphControl.Location = new System.Drawing.Point(386, 424);
            this.zGraphControl.Name = "zGraphControl";
            this.zGraphControl.ScrollGrace = 0D;
            this.zGraphControl.ScrollMaxX = 0D;
            this.zGraphControl.ScrollMaxY = 0D;
            this.zGraphControl.ScrollMaxY2 = 0D;
            this.zGraphControl.ScrollMinX = 0D;
            this.zGraphControl.ScrollMinY = 0D;
            this.zGraphControl.ScrollMinY2 = 0D;
            this.zGraphControl.Size = new System.Drawing.Size(460, 240);
            this.zGraphControl.TabIndex = 121;
            this.zGraphControl.UseExtendedPrintDialog = true;
            // 
            // xGraphControl
            // 
            this.xGraphControl.Location = new System.Drawing.Point(386, 178);
            this.xGraphControl.Name = "xGraphControl";
            this.xGraphControl.ScrollGrace = 0D;
            this.xGraphControl.ScrollMaxX = 0D;
            this.xGraphControl.ScrollMaxY = 0D;
            this.xGraphControl.ScrollMaxY2 = 0D;
            this.xGraphControl.ScrollMinX = 0D;
            this.xGraphControl.ScrollMinY = 0D;
            this.xGraphControl.ScrollMinY2 = 0D;
            this.xGraphControl.Size = new System.Drawing.Size(460, 240);
            this.xGraphControl.TabIndex = 122;
            this.xGraphControl.UseExtendedPrintDialog = true;
            // 
            // countCycle
            // 
            this.countCycle.BackColor = System.Drawing.SystemColors.Info;
            this.countCycle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countCycle.Location = new System.Drawing.Point(220, 305);
            this.countCycle.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.countCycle.Name = "countCycle";
            this.countCycle.Size = new System.Drawing.Size(112, 26);
            this.countCycle.TabIndex = 118;
            this.countCycle.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // countData
            // 
            this.countData.BackColor = System.Drawing.SystemColors.Info;
            this.countData.DecimalPlaces = 1;
            this.countData.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countData.Location = new System.Drawing.Point(220, 236);
            this.countData.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.countData.Name = "countData";
            this.countData.Size = new System.Drawing.Size(112, 26);
            this.countData.TabIndex = 117;
            this.countData.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // zBaundaryBox
            // 
            this.zBaundaryBox.BackColor = System.Drawing.SystemColors.Info;
            this.zBaundaryBox.DecimalPlaces = 1;
            this.zBaundaryBox.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.zBaundaryBox.Location = new System.Drawing.Point(317, 134);
            this.zBaundaryBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.zBaundaryBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zBaundaryBox.Name = "zBaundaryBox";
            this.zBaundaryBox.Size = new System.Drawing.Size(91, 26);
            this.zBaundaryBox.TabIndex = 109;
            this.zBaundaryBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // yBaundaryBox
            // 
            this.yBaundaryBox.BackColor = System.Drawing.SystemColors.Info;
            this.yBaundaryBox.DecimalPlaces = 1;
            this.yBaundaryBox.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yBaundaryBox.Location = new System.Drawing.Point(220, 133);
            this.yBaundaryBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.yBaundaryBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yBaundaryBox.Name = "yBaundaryBox";
            this.yBaundaryBox.Size = new System.Drawing.Size(91, 26);
            this.yBaundaryBox.TabIndex = 110;
            this.yBaundaryBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // xBaundaryBox
            // 
            this.xBaundaryBox.BackColor = System.Drawing.SystemColors.Info;
            this.xBaundaryBox.DecimalPlaces = 1;
            this.xBaundaryBox.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xBaundaryBox.Location = new System.Drawing.Point(123, 133);
            this.xBaundaryBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.xBaundaryBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xBaundaryBox.Name = "xBaundaryBox";
            this.xBaundaryBox.Size = new System.Drawing.Size(91, 26);
            this.xBaundaryBox.TabIndex = 112;
            this.xBaundaryBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // enterInterval
            // 
            this.enterInterval.BackColor = System.Drawing.SystemColors.Info;
            this.enterInterval.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.enterInterval.Location = new System.Drawing.Point(220, 273);
            this.enterInterval.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.enterInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterInterval.Name = "enterInterval";
            this.enterInterval.Size = new System.Drawing.Size(112, 26);
            this.enterInterval.TabIndex = 111;
            this.enterInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(26, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 22);
            this.label18.TabIndex = 113;
            this.label18.Text = "진입 후 측정 간격(ms)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(27, 338);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 22);
            this.label19.TabIndex = 114;
            this.label19.Text = "현재 측정 Cycle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(26, 309);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 22);
            this.label16.TabIndex = 116;
            this.label16.Text = "총 측정 Cycle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(26, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 115;
            this.label5.Text = "1회 데이터 측정 갯수";
            // 
            // currentCountCycleBox
            // 
            this.currentCountCycleBox.BackColor = System.Drawing.SystemColors.Info;
            this.currentCountCycleBox.Location = new System.Drawing.Point(220, 339);
            this.currentCountCycleBox.Name = "currentCountCycleBox";
            this.currentCountCycleBox.Size = new System.Drawing.Size(112, 21);
            this.currentCountCycleBox.TabIndex = 108;
            // 
            // dStdBox
            // 
            this.dStdBox.BackColor = System.Drawing.SystemColors.Info;
            this.dStdBox.Location = new System.Drawing.Point(1152, 115);
            this.dStdBox.Name = "dStdBox";
            this.dStdBox.Size = new System.Drawing.Size(100, 21);
            this.dStdBox.TabIndex = 107;
            this.dStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xMin
            // 
            this.xMin.BackColor = System.Drawing.SystemColors.Info;
            this.xMin.Location = new System.Drawing.Point(840, 52);
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(100, 21);
            this.xMin.TabIndex = 85;
            this.xMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // serialNumber
            // 
            this.serialNumber.BackColor = System.Drawing.SystemColors.Info;
            this.serialNumber.Location = new System.Drawing.Point(496, 84);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(191, 21);
            this.serialNumber.TabIndex = 106;
            // 
            // xStdBox
            // 
            this.xStdBox.BackColor = System.Drawing.SystemColors.Info;
            this.xStdBox.Location = new System.Drawing.Point(840, 115);
            this.xStdBox.Name = "xStdBox";
            this.xStdBox.Size = new System.Drawing.Size(100, 21);
            this.xStdBox.TabIndex = 87;
            this.xStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xMax
            // 
            this.xMax.BackColor = System.Drawing.SystemColors.Info;
            this.xMax.Location = new System.Drawing.Point(840, 85);
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(100, 21);
            this.xMax.TabIndex = 86;
            this.xMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // modelName
            // 
            this.modelName.BackColor = System.Drawing.SystemColors.Info;
            this.modelName.Location = new System.Drawing.Point(496, 54);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(191, 21);
            this.modelName.TabIndex = 105;
            // 
            // yMin
            // 
            this.yMin.BackColor = System.Drawing.SystemColors.Info;
            this.yMin.Location = new System.Drawing.Point(943, 52);
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(100, 21);
            this.yMin.TabIndex = 88;
            this.yMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yStdBox
            // 
            this.yStdBox.BackColor = System.Drawing.SystemColors.Info;
            this.yStdBox.Location = new System.Drawing.Point(943, 115);
            this.yStdBox.Name = "yStdBox";
            this.yStdBox.Size = new System.Drawing.Size(100, 21);
            this.yStdBox.TabIndex = 89;
            this.yStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentDate
            // 
            this.currentDate.BackColor = System.Drawing.SystemColors.Info;
            this.currentDate.Location = new System.Drawing.Point(496, 24);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(191, 21);
            this.currentDate.TabIndex = 104;
            // 
            // yMax
            // 
            this.yMax.BackColor = System.Drawing.SystemColors.Info;
            this.yMax.Location = new System.Drawing.Point(943, 85);
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(100, 21);
            this.yMax.TabIndex = 90;
            this.yMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zStdBox
            // 
            this.zStdBox.BackColor = System.Drawing.SystemColors.Info;
            this.zStdBox.Location = new System.Drawing.Point(1046, 115);
            this.zStdBox.Name = "zStdBox";
            this.zStdBox.Size = new System.Drawing.Size(100, 21);
            this.zStdBox.TabIndex = 84;
            this.zStdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dMin
            // 
            this.dMin.BackColor = System.Drawing.SystemColors.Info;
            this.dMin.Location = new System.Drawing.Point(1152, 52);
            this.dMin.Name = "dMin";
            this.dMin.Size = new System.Drawing.Size(100, 21);
            this.dMin.TabIndex = 91;
            this.dMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zMin
            // 
            this.zMin.BackColor = System.Drawing.SystemColors.Info;
            this.zMin.Location = new System.Drawing.Point(1046, 52);
            this.zMin.Name = "zMin";
            this.zMin.Size = new System.Drawing.Size(100, 21);
            this.zMin.TabIndex = 92;
            this.zMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dMax
            // 
            this.dMax.BackColor = System.Drawing.SystemColors.Info;
            this.dMax.Location = new System.Drawing.Point(1152, 85);
            this.dMax.Name = "dMax";
            this.dMax.Size = new System.Drawing.Size(100, 21);
            this.dMax.TabIndex = 82;
            this.dMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zMax
            // 
            this.zMax.BackColor = System.Drawing.SystemColors.Info;
            this.zMax.Location = new System.Drawing.Point(1046, 85);
            this.zMax.Name = "zMax";
            this.zMax.Size = new System.Drawing.Size(100, 21);
            this.zMax.TabIndex = 83;
            this.zMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.SeaGreen;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1152, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 19);
            this.label17.TabIndex = 101;
            this.label17.Text = "Distance";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SeaGreen;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1046, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 100;
            this.label9.Text = "Z";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SeaGreen;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(943, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 103;
            this.label8.Text = "Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SeaGreen;
            this.label12.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(427, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 98;
            this.label12.Text = "Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.SeaGreen;
            this.label13.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(427, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 19);
            this.label13.TabIndex = 97;
            this.label13.Text = "Model";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(710, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 95;
            this.label4.Text = "표준편차";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SeaGreen;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(710, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 19);
            this.label11.TabIndex = 96;
            this.label11.Text = "Max";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.SeaGreen;
            this.label14.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(427, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 19);
            this.label14.TabIndex = 94;
            this.label14.Text = "Serial";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.SeaGreen;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(710, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 19);
            this.label15.TabIndex = 93;
            this.label15.Text = "Error ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SeaGreen;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(710, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 102;
            this.label10.Text = "Min";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaGreen;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(840, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveResultBtn
            // 
            this.saveResultBtn.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveResultBtn.Location = new System.Drawing.Point(33, 542);
            this.saveResultBtn.Name = "saveResultBtn";
            this.saveResultBtn.Size = new System.Drawing.Size(131, 47);
            this.saveResultBtn.TabIndex = 78;
            this.saveResultBtn.Text = "결과데이터 \r\ncsv저장";
            this.saveResultBtn.UseVisualStyleBackColor = true;
            this.saveResultBtn.Click += new System.EventHandler(this.saveResultBtn_Click);
            // 
            // saveImage
            // 
            this.saveImage.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveImage.Location = new System.Drawing.Point(33, 595);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(131, 61);
            this.saveImage.TabIndex = 79;
            this.saveImage.Text = "현재화면저장";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // showResultBtn
            // 
            this.showResultBtn.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showResultBtn.Location = new System.Drawing.Point(203, 599);
            this.showResultBtn.Name = "showResultBtn";
            this.showResultBtn.Size = new System.Drawing.Size(129, 51);
            this.showResultBtn.TabIndex = 80;
            this.showResultBtn.Text = "결과창 열기";
            this.showResultBtn.UseVisualStyleBackColor = true;
            this.showResultBtn.Click += new System.EventHandler(this.showResultBtn_Click);
            // 
            // loadResultData
            // 
            this.loadResultData.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadResultData.Location = new System.Drawing.Point(203, 542);
            this.loadResultData.Name = "loadResultData";
            this.loadResultData.Size = new System.Drawing.Size(129, 51);
            this.loadResultData.TabIndex = 81;
            this.loadResultData.Text = "결과데이터\r\n불러오기";
            this.loadResultData.UseVisualStyleBackColor = true;
            this.loadResultData.Click += new System.EventHandler(this.loadResultData_Click);
            // 
            // stopVibeBtn
            // 
            this.stopVibeBtn.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopVibeBtn.Location = new System.Drawing.Point(203, 489);
            this.stopVibeBtn.Name = "stopVibeBtn";
            this.stopVibeBtn.Size = new System.Drawing.Size(129, 47);
            this.stopVibeBtn.TabIndex = 73;
            this.stopVibeBtn.Text = "상하진동측정중지";
            this.stopVibeBtn.UseVisualStyleBackColor = true;
            this.stopVibeBtn.Click += new System.EventHandler(this.stopVibeBtn_Click);
            // 
            // stopAccuracyBtn
            // 
            this.stopAccuracyBtn.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopAccuracyBtn.Location = new System.Drawing.Point(203, 383);
            this.stopAccuracyBtn.Name = "stopAccuracyBtn";
            this.stopAccuracyBtn.Size = new System.Drawing.Size(129, 47);
            this.stopAccuracyBtn.TabIndex = 72;
            this.stopAccuracyBtn.Text = "정지정밀도중지";
            this.stopAccuracyBtn.UseVisualStyleBackColor = true;
            this.stopAccuracyBtn.Click += new System.EventHandler(this.stopAccuracyBtn_Click);
            // 
            // stopStraightBtn
            // 
            this.stopStraightBtn.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopStraightBtn.Location = new System.Drawing.Point(203, 436);
            this.stopStraightBtn.Name = "stopStraightBtn";
            this.stopStraightBtn.Size = new System.Drawing.Size(129, 47);
            this.stopStraightBtn.TabIndex = 74;
            this.stopStraightBtn.Text = "직진정밀도중지";
            this.stopStraightBtn.UseVisualStyleBackColor = true;
            this.stopStraightBtn.Click += new System.EventHandler(this.stopStraightBtn_Click);
            // 
            // straightAccuracyStart
            // 
            this.straightAccuracyStart.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.straightAccuracyStart.Location = new System.Drawing.Point(33, 436);
            this.straightAccuracyStart.Name = "straightAccuracyStart";
            this.straightAccuracyStart.Size = new System.Drawing.Size(131, 47);
            this.straightAccuracyStart.TabIndex = 75;
            this.straightAccuracyStart.Text = "직진정밀도시작";
            this.straightAccuracyStart.UseVisualStyleBackColor = true;
            this.straightAccuracyStart.Click += new System.EventHandler(this.straightAccuracyStart_Click);
            // 
            // vibeAccuracyStart
            // 
            this.vibeAccuracyStart.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vibeAccuracyStart.Location = new System.Drawing.Point(33, 489);
            this.vibeAccuracyStart.Name = "vibeAccuracyStart";
            this.vibeAccuracyStart.Size = new System.Drawing.Size(131, 47);
            this.vibeAccuracyStart.TabIndex = 76;
            this.vibeAccuracyStart.Text = "상하진동 측정 시작";
            this.vibeAccuracyStart.UseVisualStyleBackColor = true;
            this.vibeAccuracyStart.Click += new System.EventHandler(this.vibeAccuracy_Click);
            // 
            // stopAccuracyStart
            // 
            this.stopAccuracyStart.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopAccuracyStart.Location = new System.Drawing.Point(33, 383);
            this.stopAccuracyStart.Name = "stopAccuracyStart";
            this.stopAccuracyStart.Size = new System.Drawing.Size(131, 47);
            this.stopAccuracyStart.TabIndex = 77;
            this.stopAccuracyStart.Text = "정지정밀도시작";
            this.stopAccuracyStart.UseVisualStyleBackColor = true;
            this.stopAccuracyStart.Click += new System.EventHandler(this.stopAccuracyStart_Click);
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.readBtn.Location = new System.Drawing.Point(28, 178);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(89, 56);
            this.readBtn.TabIndex = 69;
            this.readBtn.Text = "위치데이터\r\n읽기";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // originSetBtn
            // 
            this.originSetBtn.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.originSetBtn.Location = new System.Drawing.Point(121, 178);
            this.originSetBtn.Name = "originSetBtn";
            this.originSetBtn.Size = new System.Drawing.Size(88, 56);
            this.originSetBtn.TabIndex = 70;
            this.originSetBtn.Text = "원점설정";
            this.originSetBtn.UseVisualStyleBackColor = true;
            this.originSetBtn.Click += new System.EventHandler(this.originSetBtn_Click);
            // 
            // repeatRead
            // 
            this.repeatRead.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.repeatRead.Location = new System.Drawing.Point(301, 178);
            this.repeatRead.Name = "repeatRead";
            this.repeatRead.Size = new System.Drawing.Size(79, 56);
            this.repeatRead.TabIndex = 71;
            this.repeatRead.Text = "반복읽기";
            this.repeatRead.UseVisualStyleBackColor = true;
            this.repeatRead.Click += new System.EventHandler(this.repeatRead_Click);
            // 
            // originCancelBtn
            // 
            this.originCancelBtn.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.originCancelBtn.Location = new System.Drawing.Point(215, 178);
            this.originCancelBtn.Name = "originCancelBtn";
            this.originCancelBtn.Size = new System.Drawing.Size(79, 56);
            this.originCancelBtn.TabIndex = 71;
            this.originCancelBtn.Text = "원점취소";
            this.originCancelBtn.UseVisualStyleBackColor = true;
            this.originCancelBtn.Click += new System.EventHandler(this.originCancelBtn_Click);
            // 
            // xValueBox
            // 
            this.xValueBox.BackColor = System.Drawing.SystemColors.Info;
            this.xValueBox.Location = new System.Drawing.Point(123, 106);
            this.xValueBox.Name = "xValueBox";
            this.xValueBox.Size = new System.Drawing.Size(91, 21);
            this.xValueBox.TabIndex = 60;
            this.xValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yValueBox
            // 
            this.yValueBox.BackColor = System.Drawing.SystemColors.Info;
            this.yValueBox.Location = new System.Drawing.Point(220, 106);
            this.yValueBox.Name = "yValueBox";
            this.yValueBox.Size = new System.Drawing.Size(91, 21);
            this.yValueBox.TabIndex = 61;
            this.yValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zValueBox
            // 
            this.zValueBox.BackColor = System.Drawing.SystemColors.Info;
            this.zValueBox.Location = new System.Drawing.Point(317, 106);
            this.zValueBox.Name = "zValueBox";
            this.zValueBox.Size = new System.Drawing.Size(91, 21);
            this.zValueBox.TabIndex = 62;
            this.zValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Z";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.SeaGreen;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(21, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 25);
            this.label22.TabIndex = 68;
            this.label22.Text = "Baundary";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.SeaGreen;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(21, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 21);
            this.label21.TabIndex = 65;
            this.label21.Text = "현재값";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.SeaGreen;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 21);
            this.label20.TabIndex = 66;
            this.label20.Text = "Length";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portOpen
            // 
            this.portOpen.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portOpen.Location = new System.Drawing.Point(225, 20);
            this.portOpen.Name = "portOpen";
            this.portOpen.Size = new System.Drawing.Size(86, 47);
            this.portOpen.TabIndex = 59;
            this.portOpen.Text = "센서연결";
            this.portOpen.UseVisualStyleBackColor = true;
            this.portOpen.Click += new System.EventHandler(this.portOpen_Click);
            // 
            // portRefresh
            // 
            this.portRefresh.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portRefresh.Location = new System.Drawing.Point(317, 20);
            this.portRefresh.Name = "portRefresh";
            this.portRefresh.Size = new System.Drawing.Size(91, 47);
            this.portRefresh.TabIndex = 58;
            this.portRefresh.Text = "새로고침";
            this.portRefresh.UseVisualStyleBackColor = true;
            this.portRefresh.Click += new System.EventHandler(this.portRefresh_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(121, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "COM Port";
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.BackColor = System.Drawing.SystemColors.Info;
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(121, 47);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(98, 20);
            this.cmbComSelect.TabIndex = 56;
            // 
            // repeatTimer
            // 
            this.repeatTimer.Tick += new System.EventHandler(this.repeatTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 705);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Accuray Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBaundaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBaundaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBaundaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer stopAccuracyTimer;
        private System.Windows.Forms.Timer straightAccuracyTimer;
        private System.Windows.Forms.Timer vibeAccurayTimer;
        private System.Windows.Forms.Panel panel1;
        private ZedGraph.ZedGraphControl yGraphControl;
        private ZedGraph.ZedGraphControl dGraphControl;
        private ZedGraph.ZedGraphControl zGraphControl;
        private ZedGraph.ZedGraphControl xGraphControl;
        private System.Windows.Forms.NumericUpDown countCycle;
        private System.Windows.Forms.NumericUpDown countData;
        private System.Windows.Forms.NumericUpDown zBaundaryBox;
        private System.Windows.Forms.NumericUpDown yBaundaryBox;
        private System.Windows.Forms.NumericUpDown xBaundaryBox;
        private System.Windows.Forms.NumericUpDown enterInterval;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentCountCycleBox;
        private System.Windows.Forms.TextBox dStdBox;
        private System.Windows.Forms.TextBox xMin;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.TextBox xStdBox;
        private System.Windows.Forms.TextBox xMax;
        private System.Windows.Forms.TextBox modelName;
        private System.Windows.Forms.TextBox yMin;
        private System.Windows.Forms.TextBox yStdBox;
        private System.Windows.Forms.TextBox currentDate;
        private System.Windows.Forms.TextBox yMax;
        private System.Windows.Forms.TextBox zStdBox;
        private System.Windows.Forms.TextBox dMin;
        private System.Windows.Forms.TextBox zMin;
        private System.Windows.Forms.TextBox dMax;
        private System.Windows.Forms.TextBox zMax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveResultBtn;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button showResultBtn;
        private System.Windows.Forms.Button loadResultData;
        private System.Windows.Forms.Button stopVibeBtn;
        private System.Windows.Forms.Button stopAccuracyBtn;
        private System.Windows.Forms.Button stopStraightBtn;
        private System.Windows.Forms.Button straightAccuracyStart;
        private System.Windows.Forms.Button vibeAccuracyStart;
        private System.Windows.Forms.Button stopAccuracyStart;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button originSetBtn;
        private System.Windows.Forms.Button originCancelBtn;
        private System.Windows.Forms.TextBox xValueBox;
        private System.Windows.Forms.TextBox yValueBox;
        private System.Windows.Forms.TextBox zValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button portOpen;
        private System.Windows.Forms.Button portRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Button repeatRead;
        private System.Windows.Forms.Timer repeatTimer;
    }
}

