namespace MuseumForm.FormulariosData
{
    partial class frmTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            tabControl1 = new TabControl();
            tpWEClient = new TabPage();
            btnGenTicket = new Button();
            lblFechaHoy = new Label();
            lblIdSelcted = new Label();
            lblId = new Label();
            txtSerchClient = new TextBox();
            lblName = new Label();
            dgvSerchClient = new DataGridView();
            tpWNewClient = new TabPage();
            btnGTckAndNClient = new Button();
            lblFechaNCl = new Label();
            gbNewClient = new GroupBox();
            txtPhoneNewClient = new TextBox();
            lblPhnoe = new Label();
            txtNombreNewClient = new TextBox();
            lblNameClient = new Label();
            tpRegistroTickets = new TabPage();
            lblIdTckSel = new Label();
            btnEliminarTickets = new Button();
            btnEditarTickets = new Button();
            btnCargarTickets = new Button();
            dgvTickets = new DataGridView();
            tpRegistroClientes = new TabPage();
            lblIdSelecClient = new Label();
            btnEliminarClients = new Button();
            btnEditarClients = new Button();
            btnCargarClients = new Button();
            dgvClients = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tpWEClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSerchClient).BeginInit();
            tpWNewClient.SuspendLayout();
            gbNewClient.SuspendLayout();
            tpRegistroTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            tpRegistroClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpWEClient);
            tabControl1.Controls.Add(tpWNewClient);
            tabControl1.Controls.Add(tpRegistroTickets);
            tabControl1.Controls.Add(tpRegistroClientes);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 496);
            tabControl1.TabIndex = 0;
            // 
            // tpWEClient
            // 
            tpWEClient.BackColor = Color.FromArgb(247, 241, 232);
            tpWEClient.Controls.Add(btnGenTicket);
            tpWEClient.Controls.Add(lblFechaHoy);
            tpWEClient.Controls.Add(lblIdSelcted);
            tpWEClient.Controls.Add(lblId);
            tpWEClient.Controls.Add(txtSerchClient);
            tpWEClient.Controls.Add(lblName);
            tpWEClient.Controls.Add(dgvSerchClient);
            tpWEClient.Location = new Point(4, 24);
            tpWEClient.Name = "tpWEClient";
            tpWEClient.Padding = new Padding(3);
            tpWEClient.Size = new Size(890, 468);
            tpWEClient.TabIndex = 0;
            tpWEClient.Text = "Cliente existente";
            // 
            // btnGenTicket
            // 
            btnGenTicket.Location = new Point(357, 406);
            btnGenTicket.Name = "btnGenTicket";
            btnGenTicket.Size = new Size(109, 23);
            btnGenTicket.TabIndex = 6;
            btnGenTicket.Text = "Generar Ticket";
            btnGenTicket.UseVisualStyleBackColor = true;
            btnGenTicket.Click += btnGenTicket_Click;
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaHoy.Location = new Point(384, 24);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(58, 21);
            lblFechaHoy.TabIndex = 5;
            lblFechaHoy.Text = "--/--/--";
            // 
            // lblIdSelcted
            // 
            lblIdSelcted.AutoSize = true;
            lblIdSelcted.Location = new Point(425, 70);
            lblIdSelcted.Name = "lblIdSelcted";
            lblIdSelcted.Size = new Size(17, 15);
            lblIdSelcted.TabIndex = 4;
            lblIdSelcted.Text = "--";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(388, 70);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 3;
            lblId.Text = "Id:";
            // 
            // txtSerchClient
            // 
            txtSerchClient.Location = new Point(332, 109);
            txtSerchClient.Name = "txtSerchClient";
            txtSerchClient.Size = new Size(216, 23);
            txtSerchClient.TabIndex = 2;
            txtSerchClient.KeyUp += txtSerchClient_KeyUp;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(260, 112);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre:";
            // 
            // dgvSerchClient
            // 
            dgvSerchClient.AllowUserToAddRows = false;
            dgvSerchClient.AllowUserToDeleteRows = false;
            dgvSerchClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSerchClient.Location = new Point(191, 158);
            dgvSerchClient.Name = "dgvSerchClient";
            dgvSerchClient.ReadOnly = true;
            dgvSerchClient.RowTemplate.Height = 25;
            dgvSerchClient.Size = new Size(478, 225);
            dgvSerchClient.TabIndex = 0;
            dgvSerchClient.CellClick += dgvSerchClient_CellClick;
            // 
            // tpWNewClient
            // 
            tpWNewClient.BackColor = Color.FromArgb(247, 241, 232);
            tpWNewClient.Controls.Add(btnGTckAndNClient);
            tpWNewClient.Controls.Add(lblFechaNCl);
            tpWNewClient.Controls.Add(gbNewClient);
            tpWNewClient.Location = new Point(4, 24);
            tpWNewClient.Name = "tpWNewClient";
            tpWNewClient.Padding = new Padding(3);
            tpWNewClient.Size = new Size(890, 468);
            tpWNewClient.TabIndex = 1;
            tpWNewClient.Text = "Nuevo Cliente";
            // 
            // btnGTckAndNClient
            // 
            btnGTckAndNClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGTckAndNClient.Location = new Point(330, 321);
            btnGTckAndNClient.Name = "btnGTckAndNClient";
            btnGTckAndNClient.Size = new Size(126, 44);
            btnGTckAndNClient.TabIndex = 7;
            btnGTckAndNClient.Text = "Generar Ticket";
            btnGTckAndNClient.UseVisualStyleBackColor = true;
            btnGTckAndNClient.Click += btnGTckAndNClient_Click;
            // 
            // lblFechaNCl
            // 
            lblFechaNCl.AutoSize = true;
            lblFechaNCl.Location = new Point(757, 39);
            lblFechaNCl.Name = "lblFechaNCl";
            lblFechaNCl.Size = new Size(47, 15);
            lblFechaNCl.TabIndex = 6;
            lblFechaNCl.Text = "--/--/--";
            // 
            // gbNewClient
            // 
            gbNewClient.Controls.Add(txtPhoneNewClient);
            gbNewClient.Controls.Add(lblPhnoe);
            gbNewClient.Controls.Add(txtNombreNewClient);
            gbNewClient.Controls.Add(lblNameClient);
            gbNewClient.Location = new Point(257, 89);
            gbNewClient.Name = "gbNewClient";
            gbNewClient.Size = new Size(305, 200);
            gbNewClient.TabIndex = 2;
            gbNewClient.TabStop = false;
            gbNewClient.Text = "Agregar Cliente";
            // 
            // txtPhoneNewClient
            // 
            txtPhoneNewClient.Location = new Point(30, 142);
            txtPhoneNewClient.Name = "txtPhoneNewClient";
            txtPhoneNewClient.Size = new Size(110, 23);
            txtPhoneNewClient.TabIndex = 3;
            // 
            // lblPhnoe
            // 
            lblPhnoe.AutoSize = true;
            lblPhnoe.Location = new Point(30, 113);
            lblPhnoe.Name = "lblPhnoe";
            lblPhnoe.Size = new Size(52, 15);
            lblPhnoe.TabIndex = 2;
            lblPhnoe.Text = "Telefono";
            // 
            // txtNombreNewClient
            // 
            txtNombreNewClient.Location = new Point(30, 62);
            txtNombreNewClient.Name = "txtNombreNewClient";
            txtNombreNewClient.Size = new Size(226, 23);
            txtNombreNewClient.TabIndex = 1;
            // 
            // lblNameClient
            // 
            lblNameClient.AutoSize = true;
            lblNameClient.Location = new Point(30, 35);
            lblNameClient.Name = "lblNameClient";
            lblNameClient.Size = new Size(51, 15);
            lblNameClient.TabIndex = 0;
            lblNameClient.Text = "Nombre";
            // 
            // tpRegistroTickets
            // 
            tpRegistroTickets.BackColor = Color.FromArgb(247, 241, 232);
            tpRegistroTickets.Controls.Add(pictureBox1);
            tpRegistroTickets.Controls.Add(lblIdTckSel);
            tpRegistroTickets.Controls.Add(btnEliminarTickets);
            tpRegistroTickets.Controls.Add(btnEditarTickets);
            tpRegistroTickets.Controls.Add(btnCargarTickets);
            tpRegistroTickets.Controls.Add(dgvTickets);
            tpRegistroTickets.Location = new Point(4, 24);
            tpRegistroTickets.Name = "tpRegistroTickets";
            tpRegistroTickets.Padding = new Padding(3);
            tpRegistroTickets.Size = new Size(890, 468);
            tpRegistroTickets.TabIndex = 2;
            tpRegistroTickets.Text = "Registro Tickets";
            // 
            // lblIdTckSel
            // 
            lblIdTckSel.AutoSize = true;
            lblIdTckSel.Location = new Point(142, 130);
            lblIdTckSel.Name = "lblIdTckSel";
            lblIdTckSel.Size = new Size(27, 15);
            lblIdTckSel.TabIndex = 4;
            lblIdTckSel.Text = "----";
            // 
            // btnEliminarTickets
            // 
            btnEliminarTickets.Enabled = false;
            btnEliminarTickets.Location = new Point(552, 130);
            btnEliminarTickets.Name = "btnEliminarTickets";
            btnEliminarTickets.Size = new Size(75, 33);
            btnEliminarTickets.TabIndex = 3;
            btnEliminarTickets.Text = "Eliminar";
            btnEliminarTickets.UseVisualStyleBackColor = true;
            btnEliminarTickets.Click += btnEliminarTickets_Click;
            // 
            // btnEditarTickets
            // 
            btnEditarTickets.Enabled = false;
            btnEditarTickets.Location = new Point(424, 130);
            btnEditarTickets.Name = "btnEditarTickets";
            btnEditarTickets.Size = new Size(75, 33);
            btnEditarTickets.TabIndex = 2;
            btnEditarTickets.Text = "Editar";
            btnEditarTickets.UseVisualStyleBackColor = true;
            btnEditarTickets.Click += btnEditarTickets_Click;
            // 
            // btnCargarTickets
            // 
            btnCargarTickets.Location = new Point(288, 130);
            btnCargarTickets.Name = "btnCargarTickets";
            btnCargarTickets.Size = new Size(75, 33);
            btnCargarTickets.TabIndex = 1;
            btnCargarTickets.Text = "Cargar";
            btnCargarTickets.UseVisualStyleBackColor = true;
            btnCargarTickets.Click += btnCargarTickets_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Dock = DockStyle.Bottom;
            dgvTickets.Location = new Point(3, 193);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowTemplate.Height = 25;
            dgvTickets.Size = new Size(884, 272);
            dgvTickets.TabIndex = 0;
            dgvTickets.CellClick += dgvTickets_CellClick;
            // 
            // tpRegistroClientes
            // 
            tpRegistroClientes.BackColor = Color.FromArgb(247, 241, 232);
            tpRegistroClientes.Controls.Add(pictureBox2);
            tpRegistroClientes.Controls.Add(lblIdSelecClient);
            tpRegistroClientes.Controls.Add(btnEliminarClients);
            tpRegistroClientes.Controls.Add(btnEditarClients);
            tpRegistroClientes.Controls.Add(btnCargarClients);
            tpRegistroClientes.Controls.Add(dgvClients);
            tpRegistroClientes.Location = new Point(4, 24);
            tpRegistroClientes.Name = "tpRegistroClientes";
            tpRegistroClientes.Padding = new Padding(3);
            tpRegistroClientes.Size = new Size(890, 468);
            tpRegistroClientes.TabIndex = 3;
            tpRegistroClientes.Text = "Registro Clientes";
            // 
            // lblIdSelecClient
            // 
            lblIdSelecClient.AutoSize = true;
            lblIdSelecClient.Location = new Point(97, 156);
            lblIdSelecClient.Name = "lblIdSelecClient";
            lblIdSelecClient.Size = new Size(27, 15);
            lblIdSelecClient.TabIndex = 8;
            lblIdSelecClient.Text = "----";
            // 
            // btnEliminarClients
            // 
            btnEliminarClients.Enabled = false;
            btnEliminarClients.Location = new Point(506, 145);
            btnEliminarClients.Name = "btnEliminarClients";
            btnEliminarClients.Size = new Size(75, 37);
            btnEliminarClients.TabIndex = 7;
            btnEliminarClients.Text = "Eliminar";
            btnEliminarClients.UseVisualStyleBackColor = true;
            btnEliminarClients.Click += btnEliminarClients_Click;
            // 
            // btnEditarClients
            // 
            btnEditarClients.Enabled = false;
            btnEditarClients.Location = new Point(387, 145);
            btnEditarClients.Name = "btnEditarClients";
            btnEditarClients.Size = new Size(75, 37);
            btnEditarClients.TabIndex = 6;
            btnEditarClients.Text = "Editar";
            btnEditarClients.UseVisualStyleBackColor = true;
            btnEditarClients.Click += btnEditarClients_Click;
            // 
            // btnCargarClients
            // 
            btnCargarClients.Location = new Point(263, 145);
            btnCargarClients.Name = "btnCargarClients";
            btnCargarClients.Size = new Size(75, 37);
            btnCargarClients.TabIndex = 5;
            btnCargarClients.Text = "Historial";
            btnCargarClients.UseVisualStyleBackColor = true;
            btnCargarClients.Click += btnCargarClients_Click;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Dock = DockStyle.Bottom;
            dgvClients.Location = new Point(3, 193);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(884, 272);
            dgvClients.TabIndex = 4;
            dgvClients.CellClick += dgvClients_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(391, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 97);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(362, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 98);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // frmTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 500);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTickets";
            Text = "frmTickets";
            Load += frmTickets_Load;
            tabControl1.ResumeLayout(false);
            tpWEClient.ResumeLayout(false);
            tpWEClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSerchClient).EndInit();
            tpWNewClient.ResumeLayout(false);
            tpWNewClient.PerformLayout();
            gbNewClient.ResumeLayout(false);
            gbNewClient.PerformLayout();
            tpRegistroTickets.ResumeLayout(false);
            tpRegistroTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            tpRegistroClientes.ResumeLayout(false);
            tpRegistroClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpWEClient;
        private TabPage tpWNewClient;
        private TabPage tpRegistroTickets;
        private Button btnEliminarTickets;
        private Button btnEditarTickets;
        private Button btnCargarTickets;
        private DataGridView dgvTickets;
        private TabPage tpRegistroClientes;
        private Button btnEliminarClients;
        private Button btnEditarClients;
        private Button btnCargarClients;
        private DataGridView dgvClients;
        private Button btnGenTicket;
        private Label lblFechaHoy;
        private Label lblIdSelcted;
        private Label lblId;
        private TextBox txtSerchClient;
        private Label lblName;
        private DataGridView dgvSerchClient;
        private Button btnGTckAndNClient;
        private Label lblFechaNCl;
        private GroupBox gbNewClient;
        private TextBox txtPhoneNewClient;
        private Label lblPhnoe;
        private TextBox txtNombreNewClient;
        private Label lblNameClient;
        private Label lblIdTckSel;
        private Label lblIdSelecClient;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}