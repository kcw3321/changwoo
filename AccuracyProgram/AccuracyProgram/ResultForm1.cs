using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ZedGraph;

namespace AccuracyProgram
{
    public partial class ResultForm1 : Form
    {
        public MainForm m;
        public LineItem xValueCurve;
        public LineItem yValueCurve;
        public LineItem zValueCurve;
        public LineItem dValueCurve;

        public List<double> xLengthList = new List<double>();
        public List<double> yLengthList = new List<double>();
        public List<double> zLengthList = new List<double>();
        public List<double> distanceList = new List<double>();

        public PointPairList xValueList = new PointPairList();
        public PointPairList yValueList = new PointPairList();
        public PointPairList zValueList = new PointPairList();
        public PointPairList dValueList = new PointPairList();
      
        public ResultForm1(MainForm m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetGraph()
        {
           
        }
        private void ResultForm1_Load(object sender, EventArgs e)
        {
            if (m.mode == 1)
            {
                testName.Text = "정지정밀도";
            }else if (m.mode == 2)
            {
                testName.Text = "직진정밀도";
            }else if (m.mode == 3)
            {
                testName.Text = "상하진동";
            }
            else
            {
                testName.Text = "검사";
            }
         
    
            xValueList = m.xValueList;
            yValueList = m.yValueList;
            zValueList = m.zValueList;
            dValueList = m.dValueList;

            xValueCurve = xGraphControl.GraphPane.AddCurve("x Distance", xValueList, Color.Red, SymbolType.Circle);
            yValueCurve = yGraphControl.GraphPane.AddCurve("y Distance", yValueList, Color.Red, SymbolType.Circle);
            zValueCurve = zGraphControl.GraphPane.AddCurve("z Distance", zValueList, Color.Red, SymbolType.Circle);
            dValueCurve = dGraphControl.GraphPane.AddCurve("d Distance", dValueList, Color.Red, SymbolType.Circle);
            xValueCurve.Line.IsVisible = false;
            yValueCurve.Line.IsVisible = false;
            zValueCurve.Line.IsVisible = false;
            dValueCurve.Line.IsVisible = false;

            xGraphControl.Invalidate();
            yGraphControl.Invalidate();
            zGraphControl.Invalidate();
            dGraphControl.Invalidate();
            xGraphControl.AxisChange();
            yGraphControl.AxisChange();
            zGraphControl.AxisChange();
            dGraphControl.AxisChange();
            xGraphControl.GraphPane.Title.Text = "X Distance";
            yGraphControl.GraphPane.Title.Text = "Y Distance";
            zGraphControl.GraphPane.Title.Text = "Z Distance";
            dGraphControl.GraphPane.Title.Text = "Distance";
            testDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            xMinBox.Text = m.xLengthList.Min().ToString("F4");
            yMinBox.Text = m.yLengthList.Min().ToString("F4");
            zMinBox.Text = m.zLengthList.Min().ToString("F4");
            dMinBox.Text = m.distanceList.Min().ToString("F4");

            xMaxBox.Text = m.xLengthList.Min().ToString("F4");
            yMaxBox.Text = m.yLengthList.Min().ToString("F4");
            zMaxBox.Text = m.zLengthList.Min().ToString("F4");
            dMaxBox.Text = m.distanceList.Max().ToString("F4");

            xStdBox.Text = m.GetStandardDeviation(m.xLengthList, m.xLengthList.Average()).ToString("F4");
            yStdBox.Text = m.GetStandardDeviation(m.yLengthList, m.yLengthList.Average()).ToString("F4");
            zStdBox.Text = m.GetStandardDeviation(m.zLengthList, m.zLengthList.Average()).ToString("F4");
            dStdBox.Text = m.GetStandardDeviation(m.distanceList, m.distanceList.Average()).ToString("F4");

        }

        private void saveResultImage_Click(object sender, EventArgs e)
        {
            string curTime = DateTime.Now.ToString("yyMMddHHmm");
            string strFileName = curTime + "_" + "정지정밀도" + "결과";
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

        private void saveResultData_Click(object sender, EventArgs e)
        {
            m.SaveResultData();
        }
    }
}
