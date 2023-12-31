﻿using GestaoEAnaliseClientes.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEAnaliseClientes
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel1.Visible = false;

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new dashboard());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            loadform(new clientes());
        
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string usuario = usuariot.Text;
            string senha = senhat.Text;

            login loginDao = new login();

            if (loginDao.VerificarCredenciais(usuario, senha))
            {
               
                loadform(new dashboard());
                loginpanel.Visible = false;
                flowLayoutPanel1.Visible = true;


            }
            else
            {
                MessageBox.Show("Login falhou. Verifique suas credenciais e tente novamente.");
            }
        }




    }
}
