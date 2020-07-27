using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace AccuracyProgram
{
    public partial class ResultForm2 : Form
    {
        public MainForm m;
    
        public LineItem dValueCurve;
        public List<double> distanceList = new List<double>();
        public PointPairList dValueList = new PointPairList();

        public ResultForm2(MainForm m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void ResultForm2_Load(object sender, EventArgs e)
        {
            if (m.mode == 1)
            {
                testName.Text = "정지정밀도";
            }
            else if (m.mode == 2)
            {
                testName.Text = "직진정밀도";
            }
            else if (m.mode == 3)
            {
                testName.Text = "상하진동";
            }
            else
            {
                testName.Text = "검사";
            }
          
            //dValueCurve = dGraphControl.GraphPane.AddCurve("d Distance", dValueList, Color.Red);
            //dValueCurve.Line.IsVisible = false;
            dValueList = m.dValueList;
            dValueCurve= dGraphControl.GraphPane.AddCurve("d Distance", dValueList, Color.Red, SymbolType.Circle);
            dValueCurve.Line.IsVisible = false;
            dGraphControl.Invalidate();
            dGraphControl.AxisChange();
       
            dGraphControl.GraphPane.Title.Text = "Distance";
            testDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            try
            {

           
          
            dMinBox.Text = m.distanceList.Min().ToString("F4");

            dMaxBox.Text = m.distanceList.Max().ToString("F4");

            dStdBox.Text = m.GetStandardDeviation(m.distanceList, m.distanceList.Average()).ToString("F4");
            }
            catch
            {

            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveResultImage_Click(object sender, EventArgs e)
        {

            string curTime = DateTime.Now.ToString("yyMMddHHmm");
            string strFileName = curTime + "_" + testName.Text + "결과";
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
