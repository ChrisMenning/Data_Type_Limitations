using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleVsDecimal
{
    public partial class Form1 : Form
    {
        int numAsInt;
        double numAsDouble;
        decimal numAsDecimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearResults()
        {
            textBoxOutInt.Clear();
            textBoxOutDouble.Clear();
            textBoxOutDecimal.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearResults();

            if (int.TryParse(textBoxInput.Text, out numAsInt))
            {
                textBoxOutInt.Text = numAsInt.ToString();
            }
            else
            {
                MessageBox.Show("Failed to parse int.");
            }

            if (double.TryParse(textBoxInput.Text, out numAsDouble))
            {
                textBoxOutDouble.Text = numAsDouble.ToString();
            }
            else
            {
                MessageBox.Show("Failed to parse double.");
            }

            if (decimal.TryParse(textBoxInput.Text, out numAsDecimal))
            {
                textBoxOutDecimal.Text = numAsDecimal.ToString();
            }
            else
            {
                MessageBox.Show("Failed to parse decimal.");
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
