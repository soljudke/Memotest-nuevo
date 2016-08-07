﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memotest
{
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
            MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }
        Jugador jug = new Jugador();
        private void Niveles_Load(object sender, EventArgs e)
        {
            jug.Traemelo(Jugador.username);
                    switch (jug.nivelmemo)
                    {
                        case 1:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/2b.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/3b.png");
                            pic1.Enabled = true;
                            break;
                        case 2:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/3b.png");
                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            break;
                        case 3:
                            this.pic1.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/1.png");
                            this.pic2.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/2.png");
                            this.pic3.Image = System.Drawing.Image.FromFile(Configuracion.RootFolder + "/IMGS/Niveles/3.png");

                            pic1.Enabled = true;
                            pic2.Enabled = true;
                            pic3.Enabled = true;
                            break;

                        default:
                            break;
                    
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Tarjetas.Actual = 1;
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            Tarjetas.Actual = 2;
            Form2 frm1 = new Form2();
            frm1.Show();
            this.Hide();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Tarjetas.Actual = 3;
            Form3 frm1 = new Form3();
            frm1.Show();
            this.Hide();
        }
    }
}
