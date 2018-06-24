using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FillMatrix : Form
    {
        public bool Canceled = false;

        public FillMatrix()
        {
            InitializeComponent();
            textBox_start.Text = trackBar_Start.Value.ToString();
            textBox_end.Text = trackBar_End.Value.ToString();
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Canceled = true;
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_start.Text))
            {
                MessageBox.Show("Не ок",
                "Завершение работы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            } else
            {
                Close();
            }

        }

        private void trackBar_Start_Scroll(object sender, EventArgs e)
        {
            textBox_start.Text = trackBar_Start.Value.ToString();
        }

        private void trackBar_End_Scroll(object sender, EventArgs e)
        {
            textBox_end.Text = trackBar_End.Value.ToString();
        }
    }
}
