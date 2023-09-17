using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEAnaliseClientes.model
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private string apelido;
        private string clienteTipo;

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public Cliente()
        {
            // Construtor vazio
        }

        public Cliente(int id, string nome, string apelido, string clienteTipo)
        {
            this.id = id;
            this.nome = nome;
            this.apelido = apelido;
            this.clienteTipo = clienteTipo;
        }
    }
}

