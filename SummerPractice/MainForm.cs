using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummerPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AnalyseInformation();
            ValueADatagrid.EnableHeadersVisualStyles = false;


        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AnalyseInformation()
        {
            double y, y1;
            ValueADatagrid.RowHeadersVisible = false;
 
            //chart1.Series[0].Points.Clear();
            //chart1.Series[1].Points.Clear();
            //chart1.Series[2].Points.Clear();
            //radioButton1.Checked = true;
           
            int columm = 0;
            int row = 0;
            int check = 0;
            ValueADatagrid.RowCount = 21;
            ValueADatagrid.ColumnCount = 2;
            //ValueBDatagrid.RowCount = 22;
            //ValueBDatagrid.ColumnCount = 2;
            // ValueBDatagrid.Rows[0].Cells[0].Value = "x";
            // ValueBDatagrid.Rows[0].Cells[1].Value = "f(x)";
            //ValueCDatagrid.RowCount = 22;
            // ValueCDatagrid.ColumnCount = 2;
            //  ValueCDatagrid.Rows[0].Cells[0].Value = "x";
            // ValueCDatagrid.Rows[0].Cells[1].Value = "f(x)";
            //chart1.Series[1].Points.AddXY(0, 0);
            for (double i = 0; i < 2.1; i += 2.0 / 20)
            {
                check++;
                y = 100 * Math.Pow(Math.E, i * (-5));
                //chart1.Series[0].Points.AddXY(Math.Round(i, 2), Math.Round(y, 2));
                if (check > 1) { 
                    y1 = (100 - y) * Math.Pow(Math.E, i * (-3));
                //chart1.Series[1].Points.AddXY(Math.Round(i, 2), Math.Round(y1, 2));
                }

                //chart1.Series[2].Points.AddXY(Math.Round(i, 2), 100 - y - y1);
               
                if (columm == 0)
                {
                    ValueADatagrid.Rows[row].Cells[columm].Value = Math.Round(i, 2);
                    columm++;
                }
                if (columm == 1)
                {
                    ValueADatagrid.Rows[row].Cells[columm].Value = Math.Round(y, 2);
                    columm--;
                }
                if (columm == 0)
                {
                   // ValueBDatagrid.Rows[row].Cells[columm].Value = Math.Round(i, 2);
                    columm++;
                }
                if (columm == 1)
                {
                   // ValueBDatagrid.Rows[row].Cells[columm].Value = Math.Round(y1, 2);
                    columm--;
                }
                if (columm == 0)
                {
                   // ValueCDatagrid.Rows[row].Cells[columm].Value = Math.Round(i, 2);
                    columm++;
                }
                if (columm == 1)
                {
                    //ValueCDatagrid.Rows[row].Cells[columm].Value = Math.Round(100 - y - y1, 2);
                    columm--;
                }
                row++;
                ValueADatagrid.Columns[0].HeaderText = "Value of x";
                ValueADatagrid.Columns[1].HeaderText = "Value of f(x)";

            }
        }
    }
}
