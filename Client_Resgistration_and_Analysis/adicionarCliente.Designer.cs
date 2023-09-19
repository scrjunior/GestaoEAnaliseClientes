namespace GestaoEAnaliseClientes
{
    partial class adicionarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.endereco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.clieeenteTipo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.xx = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.clienteTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tservico = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.regiao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pacote = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.address = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(267, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Clientes";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(781, -1);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.Red;
            this.guna2Button4.Size = new System.Drawing.Size(38, 41);
            this.guna2Button4.TabIndex = 8;
            this.guna2Button4.Text = "x";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // endereco
            // 
            this.endereco.BackColor = System.Drawing.Color.Transparent;
            this.endereco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(78, 256);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(72, 23);
            this.endereco.TabIndex = 15;
            this.endereco.Text = "Endereço";
            // 
            // clieeenteTipo
            // 
            this.clieeenteTipo.BackColor = System.Drawing.Color.Transparent;
            this.clieeenteTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clieeenteTipo.Location = new System.Drawing.Point(36, 208);
            this.clieeenteTipo.Name = "clieeenteTipo";
            this.clieeenteTipo.Size = new System.Drawing.Size(114, 23);
            this.clieeenteTipo.TabIndex = 13;
            this.clieeenteTipo.Text = "Tipo de Cliente";
            // 
            // xx
            // 
            this.xx.BackColor = System.Drawing.Color.Transparent;
            this.xx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xx.Location = new System.Drawing.Point(89, 153);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(61, 23);
            this.xx.TabIndex = 11;
            this.xx.Text = "Apelido";
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.DefaultText = "";
            this.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Black;
            this.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.Location = new System.Drawing.Point(157, 101);
            this.fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.PlaceholderText = "";
            this.fname.SelectedText = "";
            this.fname.Size = new System.Drawing.Size(204, 29);
            this.fname.TabIndex = 20;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(102, 107);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(48, 23);
            this.guna2HtmlLabel1.TabIndex = 19;
            this.guna2HtmlLabel1.Text = "Nome";
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.DefaultText = "";
            this.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Black;
            this.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lname.Location = new System.Drawing.Point(157, 147);
            this.lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.PlaceholderText = "";
            this.lname.SelectedText = "";
            this.lname.Size = new System.Drawing.Size(204, 29);
            this.lname.TabIndex = 21;
            // 
            // clienteTipo
            // 
            this.clienteTipo.BackColor = System.Drawing.Color.Transparent;
            this.clienteTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clienteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteTipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clienteTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clienteTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clienteTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.clienteTipo.ItemHeight = 23;
            this.clienteTipo.Items.AddRange(new object[] {
            "SA",
            "E.Publica",
            "Individual",
            "ONG"});
            this.clienteTipo.Location = new System.Drawing.Point(157, 202);
            this.clienteTipo.Name = "clienteTipo";
            this.clienteTipo.Size = new System.Drawing.Size(204, 29);
            this.clienteTipo.TabIndex = 24;
            // 
            // tservico
            // 
            this.tservico.BackColor = System.Drawing.Color.Transparent;
            this.tservico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tservico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tservico.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tservico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tservico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tservico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tservico.ItemHeight = 23;
            this.tservico.Items.AddRange(new object[] {
            "Bandalarga",
            "Circuito Alugado",
            "Internet Dedicada"});
            this.tservico.Location = new System.Drawing.Point(532, 101);
            this.tservico.Name = "tservico";
            this.tservico.Size = new System.Drawing.Size(204, 29);
            this.tservico.TabIndex = 26;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(408, 107);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(117, 23);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "Tipo de Serviço";
            // 
            // regiao
            // 
            this.regiao.BackColor = System.Drawing.Color.Transparent;
            this.regiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.regiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regiao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regiao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regiao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.regiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.regiao.ItemHeight = 23;
            this.regiao.Items.AddRange(new object[] {
            "Chimoio",
            "Beira",
            "Tete",
            "Nacala",
            "Maputo",
            "Manica",
            "Matola"});
            this.regiao.Location = new System.Drawing.Point(532, 147);
            this.regiao.Name = "regiao";
            this.regiao.Size = new System.Drawing.Size(204, 29);
            this.regiao.TabIndex = 28;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(471, 153);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 23);
            this.guna2HtmlLabel3.TabIndex = 27;
            this.guna2HtmlLabel3.Text = "Região";
            // 
            // pacote
            // 
            this.pacote.BackColor = System.Drawing.Color.Transparent;
            this.pacote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pacote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacote.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pacote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pacote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pacote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.pacote.ItemHeight = 23;
            this.pacote.Items.AddRange(new object[] {
            "Ilimitado",
            "Limitado",
            "Ilimitado Simples",
            "Pequeno",
            "Medio",
            "Grande"});
            this.pacote.Location = new System.Drawing.Point(532, 202);
            this.pacote.Name = "pacote";
            this.pacote.Size = new System.Drawing.Size(204, 29);
            this.pacote.TabIndex = 30;
            this.pacote.SelectedIndexChanged += new System.EventHandler(this.pacote_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(472, 208);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(53, 23);
            this.guna2HtmlLabel4.TabIndex = 29;
            this.guna2HtmlLabel4.Text = "Pacote";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(216, 465);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "Cadastrar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(422, 465);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 32;
            this.guna2Button2.Text = "Cancelar";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // address
            // 
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.DefaultText = "";
            this.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.address.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.address.ForeColor = System.Drawing.Color.Black;
            this.address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.address.Location = new System.Drawing.Point(157, 250);
            this.address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.PlaceholderText = "";
            this.address.SelectedText = "";
            this.address.Size = new System.Drawing.Size(204, 71);
            this.address.TabIndex = 18;
            // 
            // adicionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 532);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pacote);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.regiao);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.tservico);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.clienteTipo);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.clieeenteTipo);
            this.Controls.Add(this.xx);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adicionarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adicionarCliente";
            this.Load += new System.EventHandler(this.adicionarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2HtmlLabel endereco;
        private Guna.UI2.WinForms.Guna2HtmlLabel clieeenteTipo;
        private Guna.UI2.WinForms.Guna2HtmlLabel xx;
        private Guna.UI2.WinForms.Guna2TextBox fname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox lname;
        private Guna.UI2.WinForms.Guna2ComboBox clienteTipo;
        private Guna.UI2.WinForms.Guna2ComboBox tservico;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox regiao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox pacote;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox address;
    }
}