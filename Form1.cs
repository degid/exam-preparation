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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

            try
            {
                if (textBox1.Text == "NYA")
                {
                    label1.Text = textBox1.Text;
                }
                else
                {
                    throw new Exception("Только NYA!!!!");
                }
            }

            catch (Exception) when (label1.Text == "nya") // фильтр
            {
                label1.Text = "Надо капс";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void SetClick(object sender, EventArgs e)
        {
            FillMatrix MatrixWindow = new FillMatrix();
            MatrixWindow.ShowDialog();

            //&& !string.IsNullOrEmpty(MatrixWindow.textBox_start.Text
            if (MatrixWindow.Canceled)
            {
                return;
            }

            Random rnd = new Random();
            textBox1.Text = rnd.Next(int.Parse(MatrixWindow.textBox_start.Text), int.Parse(MatrixWindow.textBox_end.Text)).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Выполнить выход?",
                "Завершение работы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
