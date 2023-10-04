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
            // Retrieve data from the database
            DataTable data = c.GetTestDataFromTestando();

            // Assuming 'tableview' is your DataGridView control
            tableview.DataSource = data;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adicionarCliente newForm = new adicionarCliente();
            newForm.DataInserted += AdicionarCliente_DataInserted; // Subscribe to the event
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
            // Check if a row is selected
            if (tableview.SelectedRows.Count > 0)
            {
                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = tableview.SelectedRows[0];

                    // Retrieve the client's name from the selected row's cells (assuming it's stored in a specific cell)
                    string clientName = selectedRow.Cells["Nome"].Value.ToString(); // Replace "ClientNameColumn" with the actual column name

                    // Create an instance of the DeleteData class
                    DeleteData deleteData = new DeleteData();

                    // Call the modified DeleteClientByName method that takes the client's name as a parameter
                    bool deletionSuccessful = deleteData.DeleteClientByName(clientName);

                    if (deletionSuccessful)
                    {
                        // Remove the selected row from the table
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
            // Check if a row is selected
            if (tableview.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = tableview.SelectedRows[0];

                // Retrieve data from the selected row's cells
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                string apelido = selectedRow.Cells["Apelido"].Value.ToString();
                string tservico = selectedRow.Cells["Tipo de Serviço"].Value.ToString();
                string clienteTipo = selectedRow.Cells["Tipo de Cliente"].Value.ToString();
                string região = selectedRow.Cells["Região"].Value.ToString();
                string endereço = selectedRow.Cells["Endereço"].Value.ToString();
                string pacote = selectedRow.Cells["Pacote"].Value.ToString();

                // Create an instance of the atualizarCliente form
                atualizarCliente updateForm = new atualizarCliente();

                // Populate the textboxes on the update form with the captured data
                updateForm.Nome = nome;
                updateForm.Nomee = nome;
                updateForm.Tserviço = tservico;
                updateForm.Apelido = apelido;
                updateForm.ClienteTipo = clienteTipo;
                updateForm.Região = região;
                updateForm.Pacote = pacote;
                updateForm.Endereço = endereço;

                // Show the atualizarCliente form
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
