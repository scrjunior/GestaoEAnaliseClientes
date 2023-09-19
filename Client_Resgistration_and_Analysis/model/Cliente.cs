using System;

namespace GestaoEAnaliseClientes.model
{
    internal class Cliente
    {
        private int clienteID;
        private string nome;
        private string apelido;
        private string clienteTipo;
        private string região;
        private string endereço;
        private int pacoteID; 
        private int serviçoID; 

        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        public string ClienteTipo
        {
            get { return clienteTipo; }
            set { clienteTipo = value; }
        }

        public string Região
        {
            get { return região; }
            set { região = value; }
        }

        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }

        public int PacoteID 
        {
            get { return pacoteID; }
            set { pacoteID = value; }
        }

        public int ServiçoID 
        {
            get { return serviçoID; }
            set { serviçoID = value; }
        }

        public Cliente()
        {
            // Constructor
        }

        public Cliente(int clienteID, string nome, string apelido, string clienteTipo, string região, string endereço, int pacoteID, int serviçoID) 
        {
            this.clienteID = clienteID;
            this.nome = nome;
            this.apelido = apelido;
            this.clienteTipo = clienteTipo;
            this.região = região;
            this.endereço = endereço;
            this.pacoteID = pacoteID; 
            this.serviçoID = serviçoID; 
            
        }
    }
}
