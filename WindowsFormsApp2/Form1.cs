using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData myData = new MyData();
            myData.AddN(200);

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < myData.X.Count; i++ )
            {
                chart1.Series[0].Points.AddXY(myData.X[i], myData.Y[i]);
            }
        }
    }
}
