using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SummerPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TableOfValuesDatagrid.EnableHeadersVisualStyles = false;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawAGraph()
        {
            Random Rand = new Random();
            double Innacurate = 0;
            GraphOfValues.Series[0].Points.Clear();
            GraphOfValues.Series[1].Points.Clear();
            GraphOfValues.Series[2].Points.Clear();
            GraphOfValues.Series[3].Points.Clear();
            GraphOfValues.Series[4].Points.Clear();
            GraphOfValues.Series[5].Points.Clear();
            double yA, yB = 0;
            int SkipFirst = 0;
            TableOfValuesDatagrid.RowCount = 21;
            TableOfValuesDatagrid.ColumnCount = 2;
            GraphOfValues.Series[1].Points.AddXY(0, 0);
            for (double i = 0; i < Convert.ToDouble(TimeForReaction.Value); i += Convert.ToDouble(TimeForReaction.Value) / 20)
            {
                SkipFirst++;
                yA = Convert.ToDouble(ConcentrationOfA.Value) * Math.Pow(Math.E, i * (-1) *(Convert.ToDouble(ReactSpeedKOne.Value)));
                Innacurate = (yA/100)*Rand.Next(Convert.ToInt32(MaximalInaccuracy.Value)-Convert.ToInt32(MinimalInaccuracy.Value), Convert.ToInt32(MaximalInaccuracy.Value));
                GraphOfValues.Series[0].Points.AddXY(i, yA);
                GraphOfValues.Series[3].Points.AddXY(i, yA+Innacurate);
                if (SkipFirst > 1)
                {
                    yB = (Convert.ToDouble(ConcentrationOfA.Value) - yA) * Math.Pow(Math.E, i * (-1) * (Convert.ToDouble(ReactSpeedKTwo.Value)));
                    GraphOfValues.Series[1].Points.AddXY(i, yB);
                    GraphOfValues.Series[4].Points.AddXY(i, yB + Innacurate);
                }

                GraphOfValues.Series[2].Points.AddXY(i, Convert.ToDouble(ConcentrationOfA.Value) - yA - yB);
                GraphOfValues.Series[5].Points.AddXY(i, Convert.ToDouble(ConcentrationOfA.Value) - yA - yB + Innacurate);
            }
        }
        
        private void DrawConcATable() {
            try
            {
                double yA;
                TableOfValuesDatagrid.RowHeadersVisible = false;
                int CurrentRow = 0;
                TableOfValuesDatagrid.RowCount = Convert.ToInt32(TimeForReaction.Value * 10);
                TableOfValuesDatagrid.ColumnCount = 2;
                for (double i = 0; i <= Convert.ToDouble(TimeForReaction.Value); i += Convert.ToDouble(TimeForReaction.Value) / 20)
                {
                    yA = Convert.ToDouble(ConcentrationOfA.Value) * Math.Pow(Math.E, i * (-1) * Convert.ToDouble(ReactSpeedKOne.Value));
                    TableOfValuesDatagrid.Rows[CurrentRow].Cells[0].Value = Math.Round(i, 2);
                    TableOfValuesDatagrid.Rows[CurrentRow].Cells[1].Value = Math.Round(yA, 2);
                    CurrentRow++;
                    TableOfValuesDatagrid.Columns[0].HeaderText = "Value of x";
                    TableOfValuesDatagrid.Columns[1].HeaderText = "Value of f(x)";

                }
            }
            catch (Exception)
            {
                
            }
        }
        private void DrawConcBTable()
        {
            try
            {
                double yA, yB = 0;
                TableOfValuesDatagrid.RowHeadersVisible = false;
                int CurrentRow = 0;
                int SkipFirst = 0;
                TableOfValuesDatagrid.RowCount = Convert.ToInt32(TimeForReaction.Value * 10); ;
                TableOfValuesDatagrid.ColumnCount = 2;
                for (double i = 0; i <= Convert.ToDouble(TimeForReaction.Value); i += Convert.ToDouble(TimeForReaction.Value) / 20)
                {
                    SkipFirst++;
                    yA = Convert.ToDouble(ConcentrationOfA.Value) * Math.Pow(Math.E, i * (-1) * Convert.ToDouble(ReactSpeedKOne.Value));
                    if (SkipFirst > 1)
                    {
                        yB = (Convert.ToDouble(ConcentrationOfA.Value) - yA) * Math.Pow(Math.E, i * (-1) * Convert.ToDouble(ReactSpeedKTwo.Value));
                    }
                    TableOfValuesDatagrid.Rows[CurrentRow].Cells[0].Value = Math.Round(i, 2);
                    TableOfValuesDatagrid.Rows[CurrentRow].Cells[1].Value = Math.Round(yB, 2);
                    CurrentRow++;
                    TableOfValuesDatagrid.Columns[0].HeaderText = "Value of x";
                    TableOfValuesDatagrid.Columns[1].HeaderText = "Value of f(x)";

                }
            }
            catch (Exception)
            {

            }
        }
        private void DrawConcCTable()
        {
            try
            {
                double yA, yB = 0;
                TableOfValuesDatagrid.RowHeadersVisible = false;
                int CurrentRow = 0;
                int SkipFirst = 0;
                TableOfValuesDatagrid.RowCount = Convert.ToInt32(TimeForReaction.Value * 10); ;
                TableOfValuesDatagrid.ColumnCount = 2;
                for (double i = 0; i <= Convert.ToDouble(TimeForReaction.Value); i += Convert.ToDouble(TimeForReaction.Value) / 20)
                {
                    SkipFirst++;
                    yA = Convert.ToDouble(ConcentrationOfA.Value) * Math.Pow(Math.E, i * (-1) * Convert.ToDouble(ReactSpeedKOne.Value));
                    if (SkipFirst > 1)
                    {
                        yB = (Convert.ToDouble(ConcentrationOfA.Value) - yA) * Math.Pow(Math.E, i * (-1) * Convert.ToDouble(ReactSpeedKTwo.Value));
                    }
                    TableOfValuesDatagrid.Rows[CurrentRow].Cells[0].Value = Math.Round(i, 2);
                    TableOfValuesDatagrid.Rows[CurrentRow].Cells[1].Value = Math.Round(Convert.ToDouble(ConcentrationOfA.Value)-yB-yA, 2);
                    CurrentRow++;
                    TableOfValuesDatagrid.Columns[0].HeaderText = "Value of x";
                    TableOfValuesDatagrid.Columns[1].HeaderText = "Value of f(x)";

                }
            }
            catch (Exception)
            {

            }
        }


        private void AnalyticButton_Click(object sender, EventArgs e)
        {
            DrawAGraph();
            if (ConcentrationAButton.Checked == true)
            {
                TableOfValuesDatagrid.Rows.Clear();
                DrawConcATable();
            }
            if (ConcentrationBButton.Checked == true)
            {
                TableOfValuesDatagrid.Rows.Clear();
                DrawConcBTable();
            }
            if (ConcentrationCButton.Checked == true)
            {
                TableOfValuesDatagrid.Rows.Clear();
                DrawConcCTable();
            }
        }

        private void GraphInFullscreenButton_Click(object sender, EventArgs e)
        {
           GraphGroupbox.Location = new Point(4, 28);
           GraphGroupbox.Width = 820; 
           GraphGroupbox.Height = 421;
           GraphOfValues.Width = 791;
           GraphOfValues.Height = 390;
           CloseFSButton.Visible = true;
        }

        private void CloseFSButton_Click(object sender, EventArgs e)
        {
            GraphGroupbox.Location = new Point(464, 28);
            GraphGroupbox.Width = 354;
            GraphGroupbox.Height = 253;
            GraphOfValues.Width = 340;
            GraphOfValues.Height = 216;
            CloseFSButton.Visible = false;//
        }

        private void ValueACheckedChanged(object sender, EventArgs e)
        {
            if (ConcentrationAButton.Checked == true)
                DrawConcATable();
        }

        private void ValueBCheckedChanged(object sender, EventArgs e)
        {
            if (ConcentrationBButton.Checked == true)
                DrawConcBTable();
        }

        private void ValueCCheckedChanged(object sender, EventArgs e)
        {
            if (ConcentrationCButton.Checked == true)
                DrawConcCTable();
        }
    }
}
