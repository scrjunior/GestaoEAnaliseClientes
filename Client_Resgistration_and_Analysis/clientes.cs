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

        private void tableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle DataGridView cell click events if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
