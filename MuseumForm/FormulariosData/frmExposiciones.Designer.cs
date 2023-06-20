namespace MuseumForm.FormulariosData
{
    partial class frmExposiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExposiciones));
            tabControl1 = new TabControl();
            tpAddObr_NewAut = new TabPage();
            pictureBox1 = new PictureBox();
            dtpFechaExpo = new DateTimePicker();
            lblFecha = new Label();
            txtPlace = new TextBox();
            lblLugar = new Label();
            cmbAutors = new ComboBox();
            label1 = new Label();
            btnRegistWithAut = new Button();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            lblIdSelected = new Label();
            label2 = new Label();
            btnDeleteExpo = new Button();
            btnEditExpo = new Button();
            btnSeeExpos = new Button();
            dgvExpos = new DataGridView();
            tabControl1.SuspendLayout();
            tpAddObr_NewAut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAddObr_NewAut);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 496);
            tabControl1.TabIndex = 2;
            // 
            // tpAddObr_NewAut
            // 
            tpAddObr_NewAut.BackColor = Color.FromArgb(247, 241, 232);
            tpAddObr_NewAut.Controls.Add(pictureBox1);
            tpAddObr_NewAut.Controls.Add(dtpFechaExpo);
            tpAddObr_NewAut.Controls.Add(lblFecha);
            tpAddObr_NewAut.Controls.Add(txtPlace);
            tpAddObr_NewAut.Controls.Add(lblLugar);
            tpAddObr_NewAut.Controls.Add(cmbAutors);
            tpAddObr_NewAut.Controls.Add(label1);
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
            pictureBox1.Location = new Point(349, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 119);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // dtpFechaExpo
            // 
            dtpFechaExpo.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaExpo.Format = DateTimePickerFormat.Short;
            dtpFechaExpo.Location = new Point(359, 235);
            dtpFechaExpo.Name = "dtpFechaExpo";
            dtpFechaExpo.Size = new Size(105, 23);
            dtpFechaExpo.TabIndex = 12;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(389, 217);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha:";
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(302, 167);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(221, 23);
            txtPlace.TabIndex = 10;
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.Location = new Point(389, 149);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(40, 15);
            lblLugar.TabIndex = 9;
            lblLugar.Text = "Lugar:";
            // 
            // cmbAutors
            // 
            cmbAutors.FormattingEnabled = true;
            cmbAutors.Location = new Point(325, 310);
            cmbAutors.Name = "cmbAutors";
            cmbAutors.Size = new Size(187, 23);
            cmbAutors.TabIndex = 8;
            cmbAutors.KeyDown += cmbAutors_KeyDown;
            cmbAutors.KeyPress += cmbAutors_KeyPress;
            cmbAutors.KeyUp += cmbAutors_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 281);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 7;
            label1.Text = "Seleccione Autor:";
            // 
            // btnRegistWithAut
            // 
            btnRegistWithAut.Location = new Point(373, 380);
            btnRegistWithAut.Name = "btnRegistWithAut";
            btnRegistWithAut.Size = new Size(95, 39);
            btnRegistWithAut.TabIndex = 0;
            btnRegistWithAut.Text = "Registrar";
            btnRegistWithAut.UseVisualStyleBackColor = true;
            btnRegistWithAut.Click += btnRegistWithAut_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(247, 241, 232);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(lblIdSelected);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnDeleteExpo);
            tabPage1.Controls.Add(btnEditExpo);
            tabPage1.Controls.Add(btnSeeExpos);
            tabPage1.Controls.Add(dgvExpos);
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
            pictureBox2.Location = new Point(345, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 119);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // lblIdSelected
            // 
            lblIdSelected.AutoSize = true;
            lblIdSelected.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdSelected.Location = new Point(378, 152);
            lblIdSelected.Name = "lblIdSelected";
            lblIdSelected.Size = new Size(21, 19);
            lblIdSelected.TabIndex = 5;
            lblIdSelected.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(255, 152);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 4;
            label2.Text = "Id Seleccionado:";
            // 
            // btnDeleteExpo
            // 
            btnDeleteExpo.Enabled = false;
            btnDeleteExpo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteExpo.Location = new Point(681, 133);
            btnDeleteExpo.Name = "btnDeleteExpo";
            btnDeleteExpo.Size = new Size(94, 51);
            btnDeleteExpo.TabIndex = 3;
            btnDeleteExpo.Text = "Eliminar Evento";
            btnDeleteExpo.UseVisualStyleBackColor = true;
            btnDeleteExpo.Click += btnDeleteExpo_Click;
            // 
            // btnEditExpo
            // 
            btnEditExpo.Enabled = false;
            btnEditExpo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditExpo.Location = new Point(560, 133);
            btnEditExpo.Name = "btnEditExpo";
            btnEditExpo.Size = new Size(92, 51);
            btnEditExpo.TabIndex = 2;
            btnEditExpo.Text = "Editar Evento";
            btnEditExpo.UseVisualStyleBackColor = true;
            btnEditExpo.Click += btnEditExpo_Click;
            // 
            // btnSeeExpos
            // 
            btnSeeExpos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeeExpos.Location = new Point(49, 133);
            btnSeeExpos.Name = "btnSeeExpos";
            btnSeeExpos.Size = new Size(112, 51);
            btnSeeExpos.TabIndex = 1;
            btnSeeExpos.Text = "Mostrar Eventos";
            btnSeeExpos.UseVisualStyleBackColor = true;
            btnSeeExpos.Click += btnSeeExpos_Click;
            // 
            // dgvExpos
            // 
            dgvExpos.AllowUserToAddRows = false;
            dgvExpos.AllowUserToDeleteRows = false;
            dgvExpos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpos.Dock = DockStyle.Bottom;
            dgvExpos.Location = new Point(3, 199);
            dgvExpos.Name = "dgvExpos";
            dgvExpos.ReadOnly = true;
            dgvExpos.RowTemplate.Height = 25;
            dgvExpos.Size = new Size(884, 266);
            dgvExpos.TabIndex = 0;
            dgvExpos.CellClick += dgvExpos_CellClick;
            // 
            // frmExposiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 500);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExposiciones";
            Text = "frmExposiciones";
            Load += frmExposiciones_Load;
            tabControl1.ResumeLayout(false);
            tpAddObr_NewAut.ResumeLayout(false);
            tpAddObr_NewAut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAddObr_NewAut;
        private ComboBox cmbAutors;
        private Label label1;
        private Button btnRegistWithAut;
        private TabPage tabPage1;
        private Label lblIdSelected;
        private Label label2;
        private Button btnDeleteExpo;
        private Button btnEditExpo;
        private Button btnSeeExpos;
        private DataGridView dgvExpos;
        private DateTimePicker dtpFechaExpo;
        private Label lblFecha;
        private TextBox txtPlace;
        private Label lblLugar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}