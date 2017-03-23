using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        //Declaramos un arreglo en el cual tenga las imagenes
        string[] imagenes = new string[5];
        string[] nombres = new string[5];
        int posicion = 0;
        public Form1()
        {
            InitializeComponent();
            //Para guardar la direccion de la imagen usamos @
            imagenes[0] = @"AllYues arcades.png";
            nombres[0] = "AllYues arcades";
            imagenes[1] = @"kfnh hqck.jpg";
            nombres[1] = "kfnh hqck";
            imagenes[2] = @"Levelers critic.jpg";
            nombres[2] = "Levelers critics";
            imagenes[3] = @"morning ovelooks.jpg";
            nombres[3] = "morning overlooks";
            imagenes[4] = @"nitz haiphong.jpg";
            nombres[4] = "nitz haiphong";
            Random r = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniciar();
        }
        private void iniciar()
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            int posicion2 = r.Next(0, 5);
            pictureBox1.ImageLocation = imagenes[posicion2];

        }

        private void recaptchabtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            posicion = r.Next(0, 5);
            //Imprime la imagen en la posicion 0
            pictureBox1.ImageLocation = imagenes[posicion];
        }
        private void final()
        {
            
            this.BackColor = Color.FromArgb(224, 224, 224);
            posicion = r.Next(0, 5);
            //Imprime la imagen en la posicion 0
            pictureBox1.ImageLocation = imagenes[posicion];
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Goods.wav");
            simpleSound.Play();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string aux1 = "";
            
            //string NombreArchivo = System.IO.Path.GetFileName(pictureBox1);
            aux1 = textBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (aux1 == nombres[0] && posicion == 0)
                {
                    this.BackColor = Color.Green;


                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Goods.wav";
                    player.Play();
                    textBox1.Text = "";
                    DialogResult result =MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if(result== DialogResult.OK)
                    {
                        final();
                    }
                }

                else if (aux1 == nombres[1] && posicion == 1)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result1 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else if (aux1 == nombres[2] && posicion == 2)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result2 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result2 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else if (aux1 == nombres[3] && posicion == 3)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result3 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result3 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else if (aux1 == nombres[4] && posicion == 4)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result4 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    if (result4 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else
                {
                    this.BackColor = Color.Red;
                    textBox1.Text = "";
                    DialogResult result5 = MessageBox.Show("You are a machine!!", "MACHINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result5 == DialogResult.OK)
                    {
                        final();
                    }
                }
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            string aux1 = "";
            //string NombreArchivo = System.IO.Path.GetFileName(pictureBox1);
            aux1 = textBox1.Text;
                if (aux1 == nombres[0] && posicion == 0)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        final();
                    }
                }

                else if (aux1 == nombres[1] && posicion == 1)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result1 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result1 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else if (aux1 == nombres[2] && posicion == 2)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result2 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result2 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else if (aux1 == nombres[3] && posicion == 3)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result3 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result3 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else if (aux1 == nombres[4] && posicion == 4)
                {
                    this.BackColor = Color.Green;
                    textBox1.Text = "";
                    DialogResult result4 = MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result4 == DialogResult.OK)
                    {
                        final();
                    }
                }
                else
                {
                    this.BackColor = Color.Red;
                    textBox1.Text = "";
                    DialogResult result5 = MessageBox.Show("You are a machine!!", "MACHINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result5 == DialogResult.OK)
                    {
                        final();
                    }
                }
            }
    }
}
