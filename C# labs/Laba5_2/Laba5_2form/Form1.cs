using System;
using Laba5_2lib;
using System.Windows.Forms;

namespace Laba5_2form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            double x1 = Convert.ToDouble(x1TextBox.Text);
            double x2 = Convert.ToDouble(x2TextBox.Text);
            double dx = Convert.ToDouble(dxTextBox.Text);
            double epx = Convert.ToDouble(epsTextBox.Text);

            if (x1 > x2)
            {
                MessageBox.Show(this, "Error","X1 must be lower than X2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (x1 <= -1 || x2 > 1)
            {
                MessageBox.Show(this,"Error", "X must be greater than -1 and lower than 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dx <= 0)
            {
                MessageBox.Show(this, "Error", "dX must be greater than 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var myMath = new MathTaylor();
            myMath.eps = epx;

            while (x1 <= x2)
            {
                double y = myMath.Calculate(x1);
                double math = Math.Log(x1 + 1);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView ,x1, y, math, String.Format("{0:F9}", math-y), myMath.count);
                dataGridView.Rows.Add(row);
                x1 += dx;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
