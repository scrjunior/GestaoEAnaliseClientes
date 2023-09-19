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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Capture the selected service and package names from your user interface controls
            string serviceName = tservico.Text;
            string packageName = pacote.Text;



            // Create a new instance of the Cliente class
            Cliente novoCliente = new Cliente
            {
                Nome = fname.Text,
                Apelido = lname.Text,
                ClienteTipo = clienteTipo.Text,
                Região = regiao.Text,
                Endereço = address.Text
            };

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(novoCliente.Nome) || string.IsNullOrEmpty(novoCliente.Apelido) || string.IsNullOrEmpty(novoCliente.ClienteTipo) || string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the client data into the 'clientes' table and associate with the service and package
            c.InsertDataIntoTestando(novoCliente, serviceName, packageName);

            // Trigger the DataInserted event
            OnDataInserted(EventArgs.Empty);

            // Close the adicionarCliente form
            this.Close();
        }



        protected virtual void OnDataInserted(EventArgs e)
        {
            if (DataInserted != null)
            {
                DataInserted(this, e);
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            // Fazer alguma coisa
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
