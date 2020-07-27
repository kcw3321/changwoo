using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace AccuracyProgram
{
    public partial class MainForm : Form
    {
        private Thread readDataThread;
        SerialPort sp = new SerialPort();
        private const int MODE_STOP_ACCURACY = 1;
        private const int MODE_STRAIGHT_ACCURACY = 2;
        private const int MODE_VIBE_ACCURACY = 3;
        private const int MODE_REPEAT_READ = 4;


        public List<double> xLengthList = new List<double>();
        public List<double> yLengthList = new List<double>();
        public List<double> zLengthList = new List<double>();
        public List<double> distanceList = new List<double>();
        double originX = 0;
        double originY = 0;
        double originZ = 0;
        double repeatTargetCount = 0;
        double xLength = 0;
        double yLength = 0;
        double zLength = 0;

        double xBaundaryLength = 0;
        double yBaundaryLength = 0;
        double zBaundaryLength = 0;

        public PointPairList xValueList = new PointPairList();
        public PointPairList yValueList = new PointPairList();
        public PointPairList zValueList = new PointPairList();
        public PointPairList dValueList = new PointPairList();
        public LineItem xValueCurve;
        public LineItem yValueCurve;
        public LineItem zValueCurve;
        public LineItem dValueCurve;


        bool outValFlag = false;
        bool enterSensorFlag = false;
        bool outSensorFlag = false;
        bool cycleFinishFlag = false;
        int countDataCycle = 0;
        int currentCountCycle = 0;
        DateTime timeStart;
        DateTime preTime;
        public int mode = 0;
        int modeCount = 0;
        string lastCheck = "정밀도";

        bool xDataFlag = false;
        bool yDataFlag = false;
        bool zDataFlag = false;
        bool finishFlag = true;
        TimeSpan intervalTest;
        double preTimeOffset = 0;
        bool showResultFlag = false;
        string timeInterval = "";
        //bool readFlag = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void portOpen_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
            {
                if (cmbComSelect.SelectedItem == null)
                    return;

                sp.PortName = cmbComSelect.SelectedItem.ToString();
                sp.Open();

                if(sp.IsOpen)
                { 
                    readDataThread = new Thread(serialRead);
                    readDataThread.Start();
                    portOpen.Text = "연결됨";
                }
            }
        }

        public void serialRead()
        {

            while (true)
            {
                int errorNum = 0;
                sp.NewLine = "\r";
                string data = sp.ReadLine();
                //  MessageBox.Show(data.ToString());
                try
                {
                    if (data.Contains("$"))
                    {

                        this.Invoke(new MethodInvoker(
                          delegate ()
                          {
                              try
                              {
                                  string[] param = data.Split("$RMD".ToCharArray());
                                  if (param[0] == "%01")
                                  {
                                      xDataFlag = false;
                                      xLength = double.Parse(param[4].ToCharArray()[0].ToString() + param[4].ToCharArray()[1].ToString() + param[4].ToCharArray()[2].ToString() + param[4].ToCharArray()[3].ToString() + "." + param[4].ToCharArray()[4] + param[4].ToCharArray()[5] + param[4].ToCharArray()[6]) - originX;

                                  }
                                  else if (param[0] == "%02")
                                  {
                                      yDataFlag = false;
                                      yLength = double.Parse(param[4].ToCharArray()[0].ToString() + param[4].ToCharArray()[1].ToString() + param[4].ToCharArray()[2].ToString() + param[4].ToCharArray()[3].ToString() + "." + param[4].ToCharArray()[4] + param[4].ToCharArray()[5] + param[4].ToCharArray()[6]) - originY;
                                  }
                                  else if (param[0] == "%03")
                                  {
                                      zDataFlag = false;
                                      zLength = double.Parse(param[4].ToCharArray()[0].ToString() + param[4].ToCharArray()[1].ToString() + param[4].ToCharArray()[2].ToString() + param[4].ToCharArray()[3].ToString() + "." + param[4].ToCharArray()[4] + param[4].ToCharArray()[5] + param[4].ToCharArray()[6]) - originZ;
                                  }


                                  if (!(xDataFlag && yDataFlag && zDataFlag))
                                  {
                                      xValueBox.Text = (xLength).ToString();
                                      yValueBox.Text = (yLength).ToString();
                                      zValueBox.Text = (zLength).ToString();

                                      if (mode == MODE_STOP_ACCURACY)
                                      {
                                          StopAccuracy_Fun();
                                      }
                                      else if (mode == MODE_STRAIGHT_ACCURACY)
                                      {
                                          StraightAccuracy_Fun();
                                      }
                                      else if (mode == MODE_VIBE_ACCURACY)
                                      {
                                          VibeAccuracy_Fun();
                                      }
                                      else if(mode==MODE_REPEAT_READ)
                                      {
                                          RepeatAccuracy_Fun();
                                          //TimeSpan temp = DateTime.Now - timeStart;
                                          //temp = DateTime.Now - preTime;
                                          //timeInterval += temp.TotalMilliseconds.ToString() + "\r\n";
                                          //preTime = DateTime.Now;
                                      }
                                  }

                                  if (finishFlag == true)
                                  {
                                      if (MODE_STOP_ACCURACY == mode)
                                      {
                                          stopAccuracyTimer.Stop();
                                          Make_Result();
                                      }
                                      else if (mode == MODE_STRAIGHT_ACCURACY)
                                      {
                                          straightAccuracyTimer.Stop();
                                          Make_Result();
                                      }
                                      else if (mode == MODE_VIBE_ACCURACY)
                                      {
                                          vibeAccurayTimer.Stop();
                                          Make_Result();
                                      }
                                      else
                                      {

                                      }
                                      //MessageBox.Show("Finish");
                                  }

                              }
                              catch (Exception e)
                              {

                              }
                          }));
                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        public void StopAccuracy_Fun()
        {
            if (xLength < xBaundaryLength && yLength < yBaundaryLength && zLength < zBaundaryLength)
            {
                outSensorFlag = false;
                if (enterSensorFlag == false)
                {
                    enterSensorFlag = true;
                    timeStart = DateTime.Now;
                }
                else
                {
                    TimeSpan temp = DateTime.Now - timeStart;

                    if (temp.TotalMilliseconds >= Decimal.ToDouble(enterInterval.Value) && cycleFinishFlag == false)
                    {

                        xLengthList.Add(xLength);
                        yLengthList.Add(yLength);
                        zLengthList.Add(zLength);
                        double distance = Math.Sqrt(Math.Pow(xLength, 2) + Math.Pow(yLength, 2) + Math.Pow(zLength, 2));
                        distanceList.Add(distance);
                        //xValueList.Add(new PointPair(distanceList.Count, xLength));
                        //yValueList.Add(new PointPair(distanceList.Count, yLength));
                        //zValueList.Add(new PointPair(distanceList.Count, zLength));
                        //dValueList.Add(new PointPair(distanceList.Count, distance));
                        xValueList.Add(new PointPair(temp.TotalMilliseconds+ preTimeOffset, xLength));
                        yValueList.Add(new PointPair(temp.TotalMilliseconds+ preTimeOffset, yLength));
                        zValueList.Add(new PointPair(temp.TotalMilliseconds+ preTimeOffset, zLength));
                        dValueList.Add(new PointPair(temp.TotalMilliseconds+ preTimeOffset, distance));


                        xMin.Text = xLengthList.Min().ToString("F2");
                        yMin.Text = yLengthList.Min().ToString("F2");
                        zMin.Text = zLengthList.Min().ToString("F2");

                        xMax.Text = xLengthList.Max().ToString("F2");
                        yMax.Text = yLengthList.Max().ToString("F2");
                        zMax.Text = zLengthList.Max().ToString("F2");

                        dMin.Text = distanceList.Min().ToString("F2");
                        dMax.Text = distanceList.Max().ToString("F2");

                        if (distanceList.Count % 25 == 0)
                        {
                            xGraphControl.Invalidate();
                            xGraphControl.AxisChange();
                            yGraphControl.Invalidate();
                            yGraphControl.AxisChange();
                            zGraphControl.Invalidate();
                            zGraphControl.AxisChange();
                            dGraphControl.Invalidate();
                            dGraphControl.AxisChange();
                        }
                        countDataCycle++;

                        if (countDataCycle >= countData.Value)
                        {
                            xGraphControl.Invalidate();
                            xGraphControl.AxisChange();
                            yGraphControl.Invalidate();
                            yGraphControl.AxisChange();
                            zGraphControl.Invalidate();
                            zGraphControl.AxisChange();
                            dGraphControl.Invalidate();
                            dGraphControl.AxisChange();
                            cycleFinishFlag = true;
                            currentCountCycle++;
                            preTimeOffset += temp.TotalMilliseconds;
                            countDataCycle = 0;
                            currentCountCycleBox.Text = currentCountCycle.ToString();
                            if (currentCountCycle >= countCycle.Value)
                            {
                                finishFlag = true;
                            }
                        }
                    }
                }
            }
            else
            {
                enterSensorFlag = false;
                outSensorFlag = true;
                cycleFinishFlag = false;
            }
        }

        public void RepeatAccuracy_Fun()
        {
            if (xLength < xBaundaryLength && yLength < yBaundaryLength && zLength < zBaundaryLength)
            {
                outSensorFlag = false;
                if (enterSensorFlag == false)
                {
                    enterSensorFlag = true;
                    timeStart = DateTime.Now;
                }
                else
                {
                    TimeSpan temp = DateTime.Now - timeStart;

                    if (temp.TotalMilliseconds >= Decimal.ToDouble(enterInterval.Value) && cycleFinishFlag == false)
                    {
                        xLengthList.Add(xLength);
                        yLengthList.Add(yLength);
                        zLengthList.Add(zLength);
                        double distance = Math.Sqrt(Math.Pow(xLength, 2) + Math.Pow(yLength, 2) + Math.Pow(zLength, 2));
                        distanceList.Add(distance);
                        xValueList.Add(new PointPair(distanceList.Count, xLength));
                        yValueList.Add(new PointPair(distanceList.Count, yLength));
                        zValueList.Add(new PointPair(distanceList.Count, zLength));
                        dValueList.Add(new PointPair(distanceList.Count, distance));


                        xMin.Text = xLengthList.Min().ToString("F2");
                        yMin.Text = yLengthList.Min().ToString("F2");
                        zMin.Text = zLengthList.Min().ToString("F2");

                        xMax.Text = xLengthList.Max().ToString("F2");
                        yMax.Text = yLengthList.Max().ToString("F2");
                        zMax.Text = zLengthList.Max().ToString("F2");

                        dMin.Text = distanceList.Min().ToString("F2");
                        dMax.Text = distanceList.Max().ToString("F2");

                        if (distanceList.Count % 25 == 0)
                        {
                            xGraphControl.Invalidate();
                            xGraphControl.AxisChange();
                            yGraphControl.Invalidate();
                            yGraphControl.AxisChange();
                            zGraphControl.Invalidate();
                            zGraphControl.AxisChange();
                            dGraphControl.Invalidate();
                            dGraphControl.AxisChange();
                        }
                        countDataCycle++;

                        if (countDataCycle >= countData.Value)
                        {
                            xGraphControl.Invalidate();
                            xGraphControl.AxisChange();
                            yGraphControl.Invalidate();
                            yGraphControl.AxisChange();
                            zGraphControl.Invalidate();
                            zGraphControl.AxisChange();
                            dGraphControl.Invalidate();
                            dGraphControl.AxisChange();
                            cycleFinishFlag = true;
                            currentCountCycle++;
                            countDataCycle = 0;
                            currentCountCycleBox.Text = currentCountCycle.ToString();
                            if (currentCountCycle >= countCycle.Value)
                            {
                                finishFlag = true;
                            }
                        }
                    }
                }
            }
            else
            {
                enterSensorFlag = false;
                outSensorFlag = true;
                cycleFinishFlag = false;
            }
        }
        public void StraightAccuracy_Fun()
        {
            if (yLength < yBaundaryLength)
            {
                outSensorFlag = false;
                if (enterSensorFlag == false)
                {
                    enterSensorFlag = true;
                    timeStart = DateTime.Now;
                }
                else
                {
                    TimeSpan temp = DateTime.Now - timeStart;
                    if (temp.TotalMilliseconds >= Decimal.ToDouble(enterInterval.Value) && cycleFinishFlag == false)
                    {
                       
                        yLengthList.Add(yLength);
                        double distance = yLength;
                        distanceList.Add(distance);
                        yValueList.Add(new PointPair(temp.TotalMilliseconds + preTimeOffset, yLength));
                        dValueList.Add(new PointPair(temp.TotalMilliseconds + preTimeOffset, distance));
                        yMin.Text = yLengthList.Min().ToString("F2");
                        yMax.Text = yLengthList.Max().ToString("F2");
                        dMin.Text = distanceList.Min().ToString("F2");
                        dMax.Text = distanceList.Max().ToString("F2");

                        if (distanceList.Count % 5 == 0)
                        {

                            yGraphControl.Invalidate();
                            yGraphControl.AxisChange();

                            dGraphControl.Invalidate();
                            dGraphControl.AxisChange();
                        }
                        countDataCycle++;

                        if (countDataCycle >= countData.Value)
                        {
                            cycleFinishFlag = true;
                            currentCountCycle++;
                            preTimeOffset += temp.TotalMilliseconds;
                            countDataCycle = 0;
                            currentCountCycleBox.Text = currentCountCycle.ToString();
                            if (currentCountCycle >= countCycle.Value)
                            {
                                finishFlag = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (enterSensorFlag == true)
                {
                    enterSensorFlag = false;
                    cycleFinishFlag = false;
                }
                outSensorFlag = true;
            }
        }

        public void VibeAccuracy_Fun()
        {
            if (zLength < zBaundaryLength)
            {
                outSensorFlag = false;
                if (enterSensorFlag == false)
                {
                    enterSensorFlag = true;
                    timeStart = DateTime.Now;
                }
                else
                {
                    TimeSpan temp = DateTime.Now - timeStart;
                    if (temp.TotalMilliseconds >= Decimal.ToDouble(enterInterval.Value) && cycleFinishFlag == false)
                    {

                        zLengthList.Add(zLength);
                        double distance = zLength;
                        distanceList.Add(distance);
                        zValueList.Add(new PointPair(temp.TotalMilliseconds + preTimeOffset, zLength));
                        dValueList.Add(new PointPair(temp.TotalMilliseconds + preTimeOffset, distance));
                        zMin.Text = zLengthList.Min().ToString("F2");
                        zMax.Text = zLengthList.Max().ToString("F2");
                        dMin.Text = distanceList.Min().ToString("F2");
                        dMax.Text = distanceList.Max().ToString("F2");

                        zGraphControl.Invalidate();
                            zGraphControl.AxisChange();

                            dGraphControl.Invalidate();
                            dGraphControl.AxisChange();
                        
                        countDataCycle++;

                        if (countDataCycle >= countData.Value)
                        {
                            cycleFinishFlag = true;
                            currentCountCycle++;
                            countDataCycle = 0;
                            currentCountCycleBox.Text = currentCountCycle.ToString();
                            preTimeOffset += temp.TotalMilliseconds;
                            if (currentCountCycle >= countCycle.Value)
                            {
                                finishFlag = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (enterSensorFlag == true)
                {
                    enterSensorFlag = false;
                    cycleFinishFlag = false;
                }
                outSensorFlag = true;
            }
        }

        public void Make_Result()
        {
            xGraphControl.Invalidate();
            xGraphControl.AxisChange();
            yGraphControl.Invalidate();
            yGraphControl.AxisChange();
            zGraphControl.Invalidate();
            zGraphControl.AxisChange();
            dGraphControl.Invalidate();
            dGraphControl.AxisChange();

            if (mode == MODE_STOP_ACCURACY)
            {
                xStdBox.Text = (GetStandardDeviation(xLengthList, xLengthList.Average())).ToString("F4");
                yStdBox.Text = (GetStandardDeviation(yLengthList, yLengthList.Average())).ToString("F4");
                zStdBox.Text = (GetStandardDeviation(zLengthList, zLengthList.Average())).ToString("F4");
                dStdBox.Text = (GetStandardDeviation(distanceList, distanceList.Average())).ToString("F4");

            }
            else if (mode == MODE_STRAIGHT_ACCURACY)
            {
                yStdBox.Text = (GetStandardDeviation(yLengthList, yLengthList.Average())).ToString("F4");
                dStdBox.Text = (GetStandardDeviation(distanceList, distanceList.Average())).ToString("F4");
            }
            else if (mode == MODE_VIBE_ACCURACY)
            {
                zStdBox.Text = (GetStandardDeviation(zLengthList, zLengthList.Average())).ToString("F4");
                dStdBox.Text = (GetStandardDeviation(distanceList, distanceList.Average())).ToString("F4");
            }

            if (showResultFlag == false)
            {
                showResultFlag = true;
                showResultBtn_Click(null, null);
            }
        }

        public double GetStandardDeviation(List<double> valueList, double average)
        {
            double variance = 0;
            foreach (double value in valueList)
            {
                variance += Math.Pow(value - average, 2);
            }
            return Math.Sqrt(variance / valueList.Count);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            sp.BaudRate = 38400;

            string[] ports = SerialPort.GetPortNames();

            // Add all port names to the combo box:
            foreach (string port in ports)
            {
                cmbComSelect.Items.Add(port);
            }

            xValueCurve = xGraphControl.GraphPane.AddCurve("x Distance", xValueList, Color.Red, SymbolType.Circle);
            yValueCurve = yGraphControl.GraphPane.AddCurve("y Distance", yValueList, Color.Red);
            zValueCurve = zGraphControl.GraphPane.AddCurve("z Distance", zValueList, Color.Red);
            dValueCurve = dGraphControl.GraphPane.AddCurve("d Distance", dValueList, Color.Red);
            xValueCurve.Line.IsVisible = false;
            yValueCurve.Line.IsVisible = false;
            zValueCurve.Line.IsVisible = false;
            dValueCurve.Line.IsVisible = false;

            xGraphControl.GraphPane.Title.Text = "X Distance";
            yGraphControl.GraphPane.Title.Text = "Y Distance";
            zGraphControl.GraphPane.Title.Text = "Z Distance";
            dGraphControl.GraphPane.Title.Text = "Distance";
            currentDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            xBaundaryLength = Decimal.ToDouble(xBaundaryBox.Value);
            yBaundaryLength = Decimal.ToDouble(yBaundaryBox.Value);
            zBaundaryLength = Decimal.ToDouble(zBaundaryBox.Value);
        }

        private void initDataFunc()
        {
            showResultFlag = false;
            preTimeOffset = 0;
            xValueList.Clear();
            yValueList.Clear();
            zValueList.Clear();
            dValueList.Clear();

            //resultBox.Clear();
            xLengthList.Clear();
            yLengthList.Clear();
            zLengthList.Clear();
            distanceList.Clear();

            xGraphControl.Invalidate();
            yGraphControl.Invalidate();
            zGraphControl.Invalidate();
            dGraphControl.Invalidate();

            xMax.Text = "";
            yMax.Text = "";
            zMax.Text = "";
            
            xMin.Text = "";
            yMin.Text = "";
            zMin.Text = "";


            currentCountCycle = 0;
            xStdBox.Text = "";
            yStdBox.Text = "";
            zStdBox.Text = "";
            dStdBox.Text = "";
        }

        private void stopAccuracyStart_Click(object sender, EventArgs e)
        {

            if (finishFlag == true)
            {
                initDataFunc();
                mode = MODE_STOP_ACCURACY;
                finishFlag = false;
                enterSensorFlag = false;
                outSensorFlag = false;
                cycleFinishFlag = false;
                currentCountCycle = 0;
                currentCountCycleBox.Text = currentCountCycle.ToString();
                stopAccuracyTimer.Interval = 1;
                stopAccuracyTimer.Start();
            }
            else
            {
                MessageBox.Show("측정 중 입니다.");
            }

        }
        private void straightAccuracyStart_Click(object sender, EventArgs e)
        {
            if (finishFlag == true)
            {
                initDataFunc();
                mode = MODE_STRAIGHT_ACCURACY;
                finishFlag = false;
                enterSensorFlag = false;
                outSensorFlag = false;
                cycleFinishFlag = false;
                currentCountCycle = 0;
                currentCountCycleBox.Text = currentCountCycle.ToString();
                straightAccuracyTimer.Interval = 5;
                straightAccuracyTimer.Start();
            }
            else
            {
                MessageBox.Show("측정 중 입니다.");
            }
        }

        private void vibeAccuracy_Click(object sender, EventArgs e)
        {
            if (finishFlag == true)
            {
                initDataFunc();
                mode = MODE_VIBE_ACCURACY;
                finishFlag = false;
                enterSensorFlag = false;
                outSensorFlag = false;
                cycleFinishFlag = false;
                currentCountCycle = 0;
                currentCountCycleBox.Text = currentCountCycle.ToString();
                vibeAccurayTimer.Interval = 5;
                vibeAccurayTimer.Start();
            }
            else
            {
                MessageBox.Show("측정 중 입니다.");
            }
        }

        private void stopAccuracyTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
                return;
            if (!xDataFlag && !yDataFlag && !zDataFlag)
            {
                sp.Write("%01#RMD**\r");
                Thread.Sleep(10);
                sp.Write("%02#RMD**\r");
                Thread.Sleep(10);
                sp.Write("%03#RMD**\r");
                xDataFlag = true;
                yDataFlag = true;
                zDataFlag = true;
            }
        }

        private void Baundary_ValueChanged(object sender, EventArgs e)
        {
            xBaundaryLength = Decimal.ToDouble(xBaundaryBox.Value);
            yBaundaryLength = Decimal.ToDouble(yBaundaryBox.Value);
            zBaundaryLength = Decimal.ToDouble(zBaundaryBox.Value);
        }

        private void stopAccuracyBtn_Click(object sender, EventArgs e)
        {
            finishFlag = true;
            stopAccuracyTimer.Stop();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            finishFlag = true;
            straightAccuracyTimer.Stop();
        }

        private void stopVibeBtn_Click(object sender, EventArgs e)
        {
            finishFlag = true;

            vibeAccurayTimer.Stop();
        }

        private void straightAccuracyTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
                return;
            if (!xDataFlag && !yDataFlag && !zDataFlag)
            {
              //  sp.Write("%01#RMD**\r");
             //   Thread.Sleep(10);
                sp.Write("%02#RMD**\r");
                Thread.Sleep(1);
            //    sp.Write("%03#RMD**\r");
             //   xDataFlag = true;
                yDataFlag = true;
             //   zDataFlag = true;
            }
        }

        private void vibeAccurayTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
                return;
            if (!xDataFlag && !yDataFlag && !zDataFlag)
            {
                //sp.Write("%01#RMD**\r");
                //Thread.Sleep(5);
                //sp.Write("%02#RMD**\r");
                //Thread.Sleep(5);
                sp.Write("%03#RMD**\r");
                Thread.Sleep(1);
                //xDataFlag = true;
                //yDataFlag = true;
                zDataFlag = true;
            }
        }

        private void saveResultBtn_Click(object sender, EventArgs e)
        {
            SaveResultData();
        }

        public void SaveResultData()
        {
            string curTime = DateTime.Now.ToString("yyMMddHHmm");
            string[] tempName = { "", "정지정밀도", "직진정밀도", "상하진동" };
            string strFileName = curTime + "_" + tempName[mode] + "결과";
            SaveFileDialog m = new SaveFileDialog();
            m.FileName = strFileName;
            m.Filter = "Excel File (*.csv)|*.csv";

            if (m.ShowDialog() != DialogResult.Cancel)
            {
                StreamWriter sw = new StreamWriter(m.FileName, false, Encoding.Unicode);
                sw.Write("검사일자" + "\t" + currentDate.Text.ToString() + "\n");
                sw.Write("모델명" + "\t" + modelName.Text.ToString() + "\n");
                sw.Write("시리얼넘버" + "\t" + serialNumber.Text.ToString() + "\n");
               
                sw.Write("검사항목" + "\t" + tempName[mode] + "\n");
                sw.Write("Cycle 횟수 " + "\t" + countCycle.Value.ToString() + "\n");
                sw.Write("Cycle 1회 데이터 수" + "\t" + countData.Value.ToString() + "\n");
                sw.Write("\nindex\tx\ty\tz\tdistance\n");

                string str = "";
                try
                {
                    
                    for (int i = 0; i < distanceList.Count; i++)
                    {
                        if (mode == MODE_STOP_ACCURACY)
                        {
                            str += (i + 1).ToString() + "\t" + xLengthList[i].ToString() + "\t" + yLengthList[i].ToString() + "\t" + zLengthList[i].ToString() + "\t" + distanceList[i].ToString() + "\n";
                        }
                        else if (mode == MODE_STRAIGHT_ACCURACY)
                        {
                            str += (i + 1).ToString() + "\t" + " "+ "\t" + yLengthList[i].ToString() + "\t" + " " + "\t" + distanceList[i].ToString() + "\n";
                        }
                        else if (mode == MODE_VIBE_ACCURACY)
                        {
                            str += (i + 1).ToString() + "\t" + " " + "\t" + " " + "\t" + zLengthList[i].ToString() + "\t" + distanceList[i].ToString() + "\n";
                        }
                    }
                    //str += xMin.Text.ToString() + "\t" + yMin.Text.ToString() + "\t" + zMin.Text.ToString() + "\n";
                    //str += xMax.Text.ToString() + "\t" + yMax.Text.ToString() + "\t" + zMax.Text.ToString() + "\n";

                    sw.Write(str);
                }catch(Exception)
                {

                }
                sw.Close();
            }
        }

        private void loadResultData_Click(object sender, EventArgs e)
        {
            OpenFileDialog m = new OpenFileDialog();

            if (m.ShowDialog() != DialogResult.Cancel)
            {
                string data = "";
                try
                {
                    data = File.ReadAllText(m.FileName);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
                //  MessageBox.Show(data);

                string[] line = data.Split('\n');

                for (int i = 0; i < line.Length && line[i] != ""; i++)
                {
                    string[] value = line[i].Split('\t');
                    if (value[0] == "검사일자")
                    {
                        currentDate.Text = value[1];
                    }
                    else if (value[0] == "모델명")
                    {
                        modelName.Text = value[1];
                    }
                    else if (value[0] == "시리얼넘버")
                    {
                        serialNumber.Text = value[1];
                    }
                    else if (value[0] == "검사항목")
                    {
                        if(value[1].Equals("정지정밀도"))
                        {
                            mode = MODE_STOP_ACCURACY;
                        }else if (value[1].Equals("직진정밀도"))
                        {
                            mode = MODE_STRAIGHT_ACCURACY;
                        }else if (value[1].Equals("상하진동"))
                        {
                            mode = MODE_VIBE_ACCURACY;
                        }
                    }
                    else if (value[0].Contains("Cycle 횟수"))
                    {
                        
                    }
                    else if (value[0].Contains("Cycle 1회 데이터 수"))
                    {
                        
                    }
                    else if (value.Length == 5 && (value[0] != "index" && value[0] !="" ))
                    {

                        if (mode == MODE_STOP_ACCURACY)
                        { 
                            xValueCurve.AddPoint(i, double.Parse(value[1].ToString()));
                            yValueCurve.AddPoint(i, double.Parse(value[2].ToString()));
                            zValueCurve.AddPoint(i, double.Parse(value[3].ToString()));
                            dValueCurve.AddPoint(i, double.Parse(value[4].ToString()));
                            xLengthList.Add(double.Parse(value[1].ToString()));
                            yLengthList.Add(double.Parse(value[2].ToString()));
                            zLengthList.Add(double.Parse(value[3].ToString()));
                        }
                        else if (mode == MODE_STRAIGHT_ACCURACY)
                        {
                            yValueCurve.AddPoint(i, double.Parse(value[2].ToString()));
                            dValueCurve.AddPoint(i, double.Parse(value[4].ToString()));
                            yLengthList.Add(double.Parse(value[2].ToString()));
                            distanceList.Add(double.Parse(value[4].ToString()));
                        }else if(mode == MODE_VIBE_ACCURACY)
                        {
                            zValueCurve.AddPoint(i, double.Parse(value[3].ToString()));
                            dValueCurve.AddPoint(i, double.Parse(value[4].ToString()));
                            zLengthList.Add(double.Parse(value[3].ToString()));
                            distanceList.Add(double.Parse(value[4].ToString()));
                        }
                    }
                }

                xGraphControl.Invalidate();
                yGraphControl.Invalidate();
                zGraphControl.Invalidate();
                dGraphControl.Invalidate();
                xGraphControl.AxisChange();
                yGraphControl.AxisChange();
                zGraphControl.AxisChange();
                dGraphControl.AxisChange();

                try
                {
                    xMin.Text = xLengthList.Min().ToString("F4");
                    yMin.Text = yLengthList.Min().ToString("F4");
                    zMin.Text = zLengthList.Min().ToString("F4");
                    dMin.Text = distanceList.Min().ToString("F4");
                    xMax.Text = xLengthList.Max().ToString("F4");
                    yMax.Text = yLengthList.Max().ToString("F4");
                    zMax.Text = zLengthList.Max().ToString("F4");
                    dMax.Text = distanceList.Max().ToString("F4");

                    dStdBox.Text = (GetStandardDeviation(distanceList, distanceList.Average())).ToString("F4");
                    xStdBox.Text = (GetStandardDeviation(xLengthList, xLengthList.Average())).ToString("F4");
                    yStdBox.Text = (GetStandardDeviation(yLengthList, yLengthList.Average())).ToString("F4");
                    zStdBox.Text = (GetStandardDeviation(zLengthList, zLengthList.Average())).ToString("F4");

                }
                catch (Exception)
                {

                }
            }
        }

        private void originCancelBtn_Click(object sender, EventArgs e)
        {
            originX = 0;
            originY = 0;
            originZ = 0;
            readBtn_Click(readBtn, EventArgs.Empty);
        }

        private void originSetBtn_Click(object sender, EventArgs e)
        {
            if (xValueBox.Text != "")
                originX = double.Parse(xValueBox.Text.ToString());
            if (yValueBox.Text != "")
                originY = double.Parse(yValueBox.Text.ToString());
            if (zValueBox.Text != "")
                originZ = double.Parse(zValueBox.Text.ToString());
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
                return;
            mode = 0;
          
            sp.Write("%01#RMD**\r");
            Thread.Sleep(10);
          
            sp.Write("%02#RMD**\r");
            Thread.Sleep(10);
           
            sp.Write("%03#RMD**\r");
        }

        private void showResultBtn_Click(object sender, EventArgs e)
        {
            
            ResultForm1 m1 = new ResultForm1(this);
            ResultForm2 m2 = new ResultForm2(this);
            if (mode == MODE_STOP_ACCURACY)
            {
                m1.ShowDialog();
            }else if(mode == MODE_STRAIGHT_ACCURACY || mode == MODE_VIBE_ACCURACY)
            {
                m2.ShowDialog();
            }
            else
            {
                
            }
          


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (readDataThread != null)
                readDataThread.Abort();
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            string curTime = DateTime.Now.ToString("yyMMddHHmm");
            string strFileName = curTime + "_" + lastCheck + "결과";
            SaveFileDialog m = new SaveFileDialog();
            m.FileName = strFileName;

            // MessageBox.Show(this.Top.ToString()+","+this.Location.Y);
            m.DefaultExt = "png";
            if (m.ShowDialog() != DialogResult.Cancel)
            {
                Thread.Sleep(500);
                //Copy(m.FileName);
                ScreenCapture(this.Width, this.Height, this.Location, m.FileName);
                // CaptureScreen(this, m.FileName);
            }
        }
        public void ScreenCapture(int width, int height, Point ptSource, string outputFilename)
        {
            Bitmap bitmap = new Bitmap(this.Bounds.Width, this.Bounds.Height);
            Graphics g = Graphics.FromImage(bitmap);
            //       g.CopyFromScreen(new Point(this.Bounds.X, this.Bounds.Y), Point.Empty, new Size(this.Bounds.Width, this.Bounds.Height));
            g.CopyFromScreen(panel1.PointToScreen(Point.Empty), Point.Empty, panel1.Size);
            bitmap.Save(outputFilename);
        }

        private void stopAccuracy_Click(object sender, EventArgs e)
        {

        }

    

        private void portRefresh_Click(object sender, EventArgs e)
        {
            cmbComSelect.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            // Add all port names to the combo box:
            foreach (string port in ports)
            {
                cmbComSelect.Items.Add(port);
            }
        }

        private void stopStraightBtn_Click(object sender, EventArgs e)
        {
            finishFlag = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timeInterval);
        }

        private void repeatTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
                return;
            if (!xDataFlag && !yDataFlag && !zDataFlag)
            {
                sp.Write("%01#RMD**\r");
                Thread.Sleep(10);
                sp.Write("%02#RMD**\r");
                Thread.Sleep(10);
                sp.Write("%03#RMD**\r");
                xDataFlag = true;
                yDataFlag = true;
                zDataFlag = true;
            }
        }

        private void repeatRead_Click(object sender, EventArgs e)
        {
            repeatTimer.Interval = 5;
            mode = MODE_REPEAT_READ;
            if(repeatTimer.Enabled)
                repeatTimer.Stop();
            else
                repeatTimer.Start();
        }
    }
}
