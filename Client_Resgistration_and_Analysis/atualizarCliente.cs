using GestaoEAnaliseClientes.dao;
using GestaoEAnaliseClientes.model;
using System;
using System.Windows.Forms;

namespace GestaoEAnaliseClientes
{
    public partial class atualizarCliente : Form
    {
        private Queries c = new Queries(); // Initialize the Queries class

        public string Nome
        {
            get { return fname.Text; }
            set { fname.Text = value; }
        }

        public string Apelido
        {
            get { return lname.Text; }
            set { lname.Text = value; }
        }

        public string ClienteTipo
        {
            get { return clienteTipo.Text; }
            set { clienteTipo.Text = value; }
        }

        public string Região
        {
            get { return regiao.Text; }
            set { regiao.Text = value; }
        }

        public string Endereço
        {
            get { return address.Text; }
            set { address.Text = value; }
        }

        public string Tserviço
        {
            get { return tservico.Text; }
            set { tservico.Text = value; }
        }

        public string Pacote
        {
            get { return pacote.Text; }
            set { pacote.Text = value; }
        }

        public atualizarCliente()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Capture the updated client data from your user interface controls
            string updatedNome = fnamee.Text;
            string originalNome = fname.Text;
            string updatedApelido = lname.Text;
            string updatedClienteTipo = clienteTipo.Text;
            string updatedRegião = regiao.Text;
            string updatedEndereço = address.Text;

            // Capture the selected service and package names from your user interface controls
            string serviceName = tservico.Text;
            string packageName = pacote.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(updatedNome) || string.IsNullOrEmpty(updatedApelido) || string.IsNullOrEmpty(updatedClienteTipo) || string.IsNullOrEmpty(updatedRegião) || string.IsNullOrEmpty(updatedEndereço) || string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the UpdateDataInTestando method to update the client data and associations
            long clienteID = c.GetClienteIDByNome(originalNome); // Use originalNome here to locate the client
            Cliente updatedCliente = new Cliente
            {
                Nome = updatedNome,
                Apelido = updatedApelido,
                ClienteTipo = updatedClienteTipo,
                Região = updatedRegião,
                Endereço = updatedEndereço
            };

            // Perform the update in the 'clientes' table (update the name here)

            c.UpdateDataInTestando(clienteID, updatedCliente, serviceName, packageName);

            

            this.Close();
        }

    }
}
