using GestaoEAnaliseClientes.dao;
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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        QueriesSelect c = new QueriesSelect();

        public void LoadDataIntoDataGridView()
        {
            
            DataTable data = c.GetTestDataFromTestando();

            
            tableview.DataSource = data;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adicionarCliente newForm = new adicionarCliente();
            newForm.DataInserted += AdicionarCliente_DataInserted; 
            newForm.ShowDialog();
        }

        private void AdicionarCliente_DataInserted(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
        private void AtualizarCliente_DataUpdated(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void tableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            if (tableview.SelectedRows.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("Tem certeza que realmente quer apagar?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    DataGridViewRow selectedRow = tableview.SelectedRows[0];

                    
                    string clientName = selectedRow.Cells["Nome"].Value.ToString(); 

                    
                    DeleteData deleteData = new DeleteData();

                    
                    bool deletionSuccessful = deleteData.DeleteClientByName(clientName);

                    if (deletionSuccessful)
                    {
                        
                        tableview.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            
            if (tableview.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = tableview.SelectedRows[0];

                
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                string apelido = selectedRow.Cells["Apelido"].Value.ToString();
                string tservico = selectedRow.Cells["Tipo de Serviço"].Value.ToString();
                string clienteTipo = selectedRow.Cells["Tipo de Cliente"].Value.ToString();
                string região = selectedRow.Cells["Região"].Value.ToString();
                string endereço = selectedRow.Cells["Endereço"].Value.ToString();
                string pacote = selectedRow.Cells["Pacote"].Value.ToString();

                
                atualizarCliente updateForm = new atualizarCliente();

                
                updateForm.Nome = nome;
                updateForm.Nomee = nome;
                updateForm.Tserviço = tservico;
                updateForm.Apelido = apelido;
                updateForm.ClienteTipo = clienteTipo;
                updateForm.Região = região;
                updateForm.Pacote = pacote;
                updateForm.Endereço = endereço;

                
                updateForm.DataUpdated += AtualizarCliente_DataUpdated;
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a client to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        


    }
}
