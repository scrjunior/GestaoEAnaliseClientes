using GestaoEAnaliseClientes.dao;
using GestaoEAnaliseClientes.model;
using System;
using System.Windows.Forms;

namespace GestaoEAnaliseClientes
{
    public partial class atualizarCliente : Form
    {
        public event EventHandler DataUpdated;

        private Queries c = new Queries(); 

        public string Nome
        {
            get { return fname.Text; }
            set { fname.Text = value; }
        }

        public string Nomee
        {
            get { return fnamee.Text; }
            set { fnamee.Text = value; }
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
            
            string updatedNome = fnamee.Text;
            string originalNome = fname.Text;
            string updatedApelido = lname.Text;
            string updatedClienteTipo = clienteTipo.Text;
            string updatedRegião = regiao.Text;
            string updatedEndereço = address.Text;

            
            string serviceName = tservico.Text;
            string packageName = pacote.Text;

            
            if (string.IsNullOrEmpty(updatedNome) || string.IsNullOrEmpty(updatedApelido) || string.IsNullOrEmpty(updatedClienteTipo) || string.IsNullOrEmpty(updatedRegião) || string.IsNullOrEmpty(updatedEndereço) || string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            long clienteID = c.GetClienteIDByNome(originalNome); 
            Cliente updatedCliente = new Cliente
            {
                Nome = updatedNome,
                Apelido = updatedApelido,
                ClienteTipo = updatedClienteTipo,
                Região = updatedRegião,
                Endereço = updatedEndereço
            };

            

            c.UpdateDataInTestando(clienteID, updatedCliente, serviceName, packageName);

            OnDataUpdated(EventArgs.Empty);

            this.Close();
        }

        protected virtual void OnDataUpdated(EventArgs e)
        {
            if (DataUpdated != null)
            {
                DataUpdated(this, e);
            }
        }


    }
}
