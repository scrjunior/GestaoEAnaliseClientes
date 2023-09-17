using GestaoEAnaliseClientes.dao;
using GestaoEAnaliseClientes.model;
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
    public partial class adicionarCliente : Form
    {

        public event EventHandler DataInserted;
        public adicionarCliente()
        {
            InitializeComponent();
        }

        Queries c = new Queries();

        private void adicionarCliente_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Criar um objeto Cliente com os valores dos campos
            Cliente novoCliente = new Cliente
            {
                Nome = fname.Text,
                Apelido = lname.Text,
                ClienteTipo = clienteTipo.Text
            };

            // Chamar o método InsertDataIntoTestando com o objeto Cliente
            c.InsertDataIntoTestando(novoCliente);

            OnDataInserted(EventArgs.Empty);

            this.Close(); // Fechar o formulário adicionarCliente
        }



        protected virtual void OnDataInserted(EventArgs e)
        {
            DataInserted?.Invoke(this, e);
        }


    }
}
