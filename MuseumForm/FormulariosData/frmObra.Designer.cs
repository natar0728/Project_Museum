namespace MuseumForm.FormulariosData
{
    partial class frmObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObra));
            tabControl1 = new TabControl();
            tpAddObr_NewAut = new TabPage();
            pictureBox1 = new PictureBox();
            cmbAutors = new ComboBox();
            label1 = new Label();
            cmbTypesWithAut = new ComboBox();
            lblType = new Label();
            txtDescWAu = new TextBox();
            lblDescrp = new Label();
            txtTittleWAut = new TextBox();
            lblTitulo = new Label();
            btnRegistWithAut = new Button();
            tpAddObr_exstAut = new TabPage();
            gbAutInfo = new GroupBox();
            txtEmailAut = new TextBox();
            lblEmail = new Label();
            txtLastNameAut = new TextBox();
            lblLastName = new Label();
            txtNameAut = new TextBox();
            lblName = new Label();
            cmbTypesNewAut = new ComboBox();
            label3 = new Label();
            txtDescNAut = new TextBox();
            label4 = new Label();
            txtTittleNAut = new TextBox();
            label5 = new Label();
            btnRegistNewAut = new Button();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            lblIdSelected = new Label();
            label2 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSeeObrs = new Button();
            dgvObras = new DataGridView();
            tabControl1.SuspendLayout();
            tpAddObr_NewAut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpAddObr_exstAut.SuspendLayout();
            gbAutInfo.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvObras).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAddObr_NewAut);
            tabControl1.Controls.Add(tpAddObr_exstAut);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 496);
            tabControl1.TabIndex = 1;
            // 
            // tpAddObr_NewAut
            // 
            tpAddObr_NewAut.BackColor = Color.FromArgb(247, 241, 232);
            tpAddObr_NewAut.Controls.Add(pictureBox1);
            tpAddObr_NewAut.Controls.Add(cmbAutors);
            tpAddObr_NewAut.Controls.Add(label1);
            tpAddObr_NewAut.Controls.Add(cmbTypesWithAut);
            tpAddObr_NewAut.Controls.Add(lblType);
            tpAddObr_NewAut.Controls.Add(txtDescWAu);
            tpAddObr_NewAut.Controls.Add(lblDescrp);
            tpAddObr_NewAut.Controls.Add(txtTittleWAut);
            tpAddObr_NewAut.Controls.Add(lblTitulo);
            tpAddObr_NewAut.Controls.Add(btnRegistWithAut);
            tpAddObr_NewAut.Location = new Point(4, 24);
            tpAddObr_NewAut.Name = "tpAddObr_NewAut";
            tpAddObr_NewAut.Padding = new Padding(3);
            tpAddObr_NewAut.Size = new Size(890, 468);
            tpAddObr_NewAut.TabIndex = 0;
            tpAddObr_NewAut.Text = "Añadir con Autor existente";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(497, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 465);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cmbAutors
            // 
            cmbAutors.FormattingEnabled = true;
            cmbAutors.Location = new Point(113, 275);
            cmbAutors.Name = "cmbAutors";
            cmbAutors.Size = new Size(172, 23);
            cmbAutors.TabIndex = 8;
            cmbAutors.SelectedIndexChanged += cmbAutors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 283);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Autor:";
            // 
            // cmbTypesWithAut
            // 
            cmbTypesWithAut.FormattingEnabled = true;
            cmbTypesWithAut.Items.AddRange(new object[] { "Pintura al Oleo", "Escultura", "Otro" });
            cmbTypesWithAut.Location = new Point(113, 215);
            cmbTypesWithAut.Name = "cmbTypesWithAut";
            cmbTypesWithAut.Size = new Size(121, 23);
            cmbTypesWithAut.TabIndex = 6;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(45, 218);
            lblType.Name = "lblType";
            lblType.Size = new Size(33, 15);
            lblType.TabIndex = 5;
            lblType.Text = "Tipo:";
            // 
            // txtDescWAu
            // 
            txtDescWAu.Location = new Point(113, 104);
            txtDescWAu.Multiline = true;
            txtDescWAu.Name = "txtDescWAu";
            txtDescWAu.Size = new Size(255, 83);
            txtDescWAu.TabIndex = 4;
            // 
            // lblDescrp
            // 
            lblDescrp.AutoSize = true;
            lblDescrp.Location = new Point(25, 104);
            lblDescrp.Name = "lblDescrp";
            lblDescrp.Size = new Size(72, 15);
            lblDescrp.TabIndex = 3;
            lblDescrp.Text = "Descripcion:";
            // 
            // txtTittleWAut
            // 
            txtTittleWAut.Location = new Point(113, 51);
            txtTittleWAut.Name = "txtTittleWAut";
            txtTittleWAut.Size = new Size(175, 23);
            txtTittleWAut.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(45, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo:";
            // 
            // btnRegistWithAut
            // 
            btnRegistWithAut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistWithAut.Location = new Point(113, 347);
            btnRegistWithAut.Name = "btnRegistWithAut";
            btnRegistWithAut.Size = new Size(103, 45);
            btnRegistWithAut.TabIndex = 0;
            btnRegistWithAut.Text = "Registrar";
            btnRegistWithAut.UseVisualStyleBackColor = true;
            btnRegistWithAut.Click += btnRegistWithAut_Click;
            // 
            // tpAddObr_exstAut
            // 
            tpAddObr_exstAut.BackColor = Color.FromArgb(247, 241, 232);
            tpAddObr_exstAut.Controls.Add(gbAutInfo);
            tpAddObr_exstAut.Controls.Add(cmbTypesNewAut);
            tpAddObr_exstAut.Controls.Add(label3);
            tpAddObr_exstAut.Controls.Add(txtDescNAut);
            tpAddObr_exstAut.Controls.Add(label4);
            tpAddObr_exstAut.Controls.Add(txtTittleNAut);
            tpAddObr_exstAut.Controls.Add(label5);
            tpAddObr_exstAut.Controls.Add(btnRegistNewAut);
            tpAddObr_exstAut.Location = new Point(4, 24);
            tpAddObr_exstAut.Name = "tpAddObr_exstAut";
            tpAddObr_exstAut.Padding = new Padding(3);
            tpAddObr_exstAut.Size = new Size(890, 468);
            tpAddObr_exstAut.TabIndex = 1;
            tpAddObr_exstAut.Text = "Añadir con Autor nuevo";
            // 
            // gbAutInfo
            // 
            gbAutInfo.Controls.Add(txtEmailAut);
            gbAutInfo.Controls.Add(lblEmail);
            gbAutInfo.Controls.Add(txtLastNameAut);
            gbAutInfo.Controls.Add(lblLastName);
            gbAutInfo.Controls.Add(txtNameAut);
            gbAutInfo.Controls.Add(lblName);
            gbAutInfo.Location = new Point(444, 96);
            gbAutInfo.Name = "gbAutInfo";
            gbAutInfo.Size = new Size(315, 165);
            gbAutInfo.TabIndex = 16;
            gbAutInfo.TabStop = false;
            gbAutInfo.Text = "Autor Info:";
            // 
            // txtEmailAut
            // 
            txtEmailAut.Location = new Point(121, 98);
            txtEmailAut.Name = "txtEmailAut";
            txtEmailAut.Size = new Size(173, 23);
            txtEmailAut.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // txtLastNameAut
            // 
            txtLastNameAut.Location = new Point(121, 61);
            txtLastNameAut.Name = "txtLastNameAut";
            txtLastNameAut.Size = new Size(173, 23);
            txtLastNameAut.TabIndex = 10;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(35, 64);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(54, 15);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Apellido:";
            // 
            // txtNameAut
            // 
            txtNameAut.Location = new Point(121, 21);
            txtNameAut.Name = "txtNameAut";
            txtNameAut.Size = new Size(173, 23);
            txtNameAut.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Nombre:";
            // 
            // cmbTypesNewAut
            // 
            cmbTypesNewAut.FormattingEnabled = true;
            cmbTypesNewAut.Items.AddRange(new object[] { "Pintura al Oleo", "Escultura", "Otro" });
            cmbTypesNewAut.Location = new Point(21, 277);
            cmbTypesNewAut.Name = "cmbTypesNewAut";
            cmbTypesNewAut.Size = new Size(121, 23);
            cmbTypesNewAut.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 246);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo:";
            // 
            // txtDescNAut
            // 
            txtDescNAut.Location = new Point(21, 113);
            txtDescNAut.Multiline = true;
            txtDescNAut.Name = "txtDescNAut";
            txtDescNAut.Size = new Size(218, 122);
            txtDescNAut.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 89);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 12;
            label4.Text = "Descripcion:";
            // 
            // txtTittleNAut
            // 
            txtTittleNAut.Location = new Point(21, 49);
            txtTittleNAut.Name = "txtTittleNAut";
            txtTittleNAut.Size = new Size(141, 23);
            txtTittleNAut.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 28);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Titulo:";
            // 
            // btnRegistNewAut
            // 
            btnRegistNewAut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistNewAut.Location = new Point(374, 361);
            btnRegistNewAut.Name = "btnRegistNewAut";
            btnRegistNewAut.Size = new Size(113, 47);
            btnRegistNewAut.TabIndex = 9;
            btnRegistNewAut.Text = "Registrar Obra";
            btnRegistNewAut.UseVisualStyleBackColor = true;
            btnRegistNewAut.Click += button1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(247, 241, 232);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(lblIdSelected);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnSeeObrs);
            tabPage1.Controls.Add(dgvObras);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(890, 468);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Registro";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(367, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 60);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblIdSelected
            // 
            lblIdSelected.AutoSize = true;
            lblIdSelected.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdSelected.Location = new Point(133, 142);
            lblIdSelected.Name = "lblIdSelected";
            lblIdSelected.Size = new Size(21, 19);
            lblIdSelected.TabIndex = 5;
            lblIdSelected.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 142);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 4;
            label2.Text = "Id Seleccionado:";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(610, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 42);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(465, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 42);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSeeObrs
            // 
            btnSeeObrs.BackColor = Color.Transparent;
            btnSeeObrs.Location = new Point(324, 130);
            btnSeeObrs.Name = "btnSeeObrs";
            btnSeeObrs.Size = new Size(104, 42);
            btnSeeObrs.TabIndex = 1;
            btnSeeObrs.Text = "Mostrar Tabla";
            btnSeeObrs.UseVisualStyleBackColor = false;
            btnSeeObrs.Click += btnSeeObrs_Click;
            // 
            // dgvObras
            // 
            dgvObras.AllowUserToAddRows = false;
            dgvObras.AllowUserToDeleteRows = false;
            dgvObras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvObras.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvObras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObras.Dock = DockStyle.Bottom;
            dgvObras.Location = new Point(3, 188);
            dgvObras.Name = "dgvObras";
            dgvObras.ReadOnly = true;
            dgvObras.RowTemplate.Height = 25;
            dgvObras.Size = new Size(884, 277);
            dgvObras.TabIndex = 0;
            dgvObras.CellClick += dgvObras_CellClick;
            // 
            // frmObra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 500);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmObra";
            Text = "frmObra";
            Load += frmObra_Load;
            tabControl1.ResumeLayout(false);
            tpAddObr_NewAut.ResumeLayout(false);
            tpAddObr_NewAut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpAddObr_exstAut.ResumeLayout(false);
            tpAddObr_exstAut.PerformLayout();
            gbAutInfo.ResumeLayout(false);
            gbAutInfo.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvObras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAddObr_NewAut;
        private Label lblType;
        private TextBox txtDescWAu;
        private Label lblDescrp;
        private TextBox txtTittleWAut;
        private Label lblTitulo;
        private Button btnRegistWithAut;
        private TabPage tpAddObr_exstAut;
        private ComboBox cmbAutors;
        private Label label1;
        private ComboBox cmbTypesWithAut;
        private TabPage tabPage1;
        private GroupBox gbAutInfo;
        private ComboBox cmbTypesNewAut;
        private Label label3;
        private TextBox txtDescNAut;
        private Label label4;
        private TextBox txtTittleNAut;
        private Label label5;
        private Button btnRegistNewAut;
        private TextBox txtEmailAut;
        private Label lblEmail;
        private TextBox txtLastNameAut;
        private Label lblLastName;
        private TextBox txtNameAut;
        private Label lblName;
        private DataGridView dgvObras;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSeeObrs;
        private Label lblIdSelected;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}