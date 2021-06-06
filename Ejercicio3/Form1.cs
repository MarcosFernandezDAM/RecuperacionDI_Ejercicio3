using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EntraRatonButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aqua;
        }

        private void SaleRatonButton(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = default;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            try
            {
                int r = Convert.ToInt32(textBoxColor1.Text);
                int g = Convert.ToInt32(textBoxColor2.Text);
                int b = Convert.ToInt32(textBoxColor3.Text);
                this.BackgroundImage = default;
                this.BackColor = Color.FromArgb(r, g, b);

            }
            catch (ArgumentException )
            {
                this.BackColor = default;
            }
            catch (FormatException )
            {
                this.BackColor = default;
            }
            catch (OverflowException )
            {
                this.BackColor = default;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T)
            {
                this.Text = "Colores e Imágenes";
            }
        }

        private void EnterBoxes(object sender, EventArgs e)
        {
            if ((TextBox)sender == textBoxPath)
            {
                AcceptButton = btnPath;
            }
            else
            {
                AcceptButton = btnColor;
            }
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = default;
                this.BackgroundImage = Image.FromFile(textBoxPath.Text);
            }
            catch (ArgumentException ex)
            {
                this.BackgroundImage = default;
            }
            catch (FileNotFoundException ex2)
            {
                this.BackgroundImage = default;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Colores e Imágenes";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender == this)
            {
                int x = e.Location.X;
                int y = e.Location.Y;
                String text = "X: " + x + " Y: " + y;
                this.Text = text;
            }
            else
            {
                int x = 0;
                int y = 0;
                Control c = (Control)sender;
                x = c.Location.X + e.Location.X;
                y = c.Location.Y + e.Location.Y;
                this.Text = "X: " + x + " Y: " + y;
            }
        }
    }
}
