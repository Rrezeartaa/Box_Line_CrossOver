using System;
using System.Windows.Forms;

namespace box_line_crossover
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            crossoverTypeCombo.SelectedIndex = 0;
        }

        private void crossoverButton_Click(object sender, EventArgs e)
        {
            float x1 = (float)Double.Parse(x1Tb.Text);
            float x2 = (float)Double.Parse(x2Tb.Text);
            float y1 = (float)Double.Parse(y1Tb.Text);
            float y2 = (float)Double.Parse(y2Tb.Text);
            double alfa = Double.Parse(alfaTb.Text);
            float[] parents = { x1, x2, y1, y2};
            int crossoverType = crossoverTypeCombo.SelectedIndex + 1;

            ChildForm resultForm = new ChildForm(parents, crossoverType, alfa);
            resultForm.ShowDialog();
        }

        private void crossoverTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (crossoverTypeCombo.SelectedIndex == 0 || crossoverTypeCombo.SelectedIndex == 2)
            {
                alfaTb.Text = "0";
                alfaTb.Enabled = false;
            }
            else
            {
                alfaTb.Text = "0.1";
                alfaTb.Enabled = true;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void y2Tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
