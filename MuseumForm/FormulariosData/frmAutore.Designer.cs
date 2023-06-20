namespace MuseumForm.FormulariosData
{
    partial class frmAutore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutore));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddAutor = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tpSeeAutor = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnMostAutors = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpAddAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpSeeAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAddAutor);
            this.tabControl1.Controls.Add(this.tpSeeAutor);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAddAutor
            // 
            this.tpAddAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.tpAddAutor.Controls.Add(this.pictureBox1);
            this.tpAddAutor.Controls.Add(this.txtEmail);
            this.tpAddAutor.Controls.Add(this.lblEmail);
            this.tpAddAutor.Controls.Add(this.txtLastName);
            this.tpAddAutor.Controls.Add(this.lblLastName);
            this.tpAddAutor.Controls.Add(this.txtName);
            this.tpAddAutor.Controls.Add(this.lblName);
            this.tpAddAutor.Controls.Add(this.btnSave);
            this.tpAddAutor.Location = new System.Drawing.Point(4, 24);
            this.tpAddAutor.Name = "tpAddAutor";
            this.tpAddAutor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddAutor.Size = new System.Drawing.Size(890, 468);
            this.tpAddAutor.TabIndex = 0;
            this.tpAddAutor.Text = "Añadir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(357, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(301, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(386, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(301, 219);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 23);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(371, 191);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellido:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(371, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(340, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Registrar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tpSeeAutor
            // 
            this.tpSeeAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.tpSeeAutor.Controls.Add(this.pictureBox2);
            this.tpSeeAutor.Controls.Add(this.btnEliminar);
            this.tpSeeAutor.Controls.Add(this.btnEditar);
            this.tpSeeAutor.Controls.Add(this.btnMostAutors);
            this.tpSeeAutor.Controls.Add(this.dgvAutores);
            this.tpSeeAutor.Location = new System.Drawing.Point(4, 24);
            this.tpSeeAutor.Name = "tpSeeAutor";
            this.tpSeeAutor.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeeAutor.Size = new System.Drawing.Size(890, 468);
            this.tpSeeAutor.TabIndex = 1;
            this.tpSeeAutor.Text = "Registro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(381, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 78);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(504, 97);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 51);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Autor Seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(299, 97);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 51);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Autor Seleccionado";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnMostAutors
            // 
            this.btnMostAutors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostAutors.Location = new System.Drawing.Point(86, 97);
            this.btnMostAutors.Name = "btnMostAutors";
            this.btnMostAutors.Size = new System.Drawing.Size(149, 51);
            this.btnMostAutors.TabIndex = 2;
            this.btnMostAutors.Text = "Mostrar Registro de Autores";
            this.btnMostAutors.UseVisualStyleBackColor = true;
            this.btnMostAutors.Click += new System.EventHandler(this.btnMostAutors_Click);
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAutores.Location = new System.Drawing.Point(3, 165);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowTemplate.Height = 25;
            this.dgvAutores.Size = new System.Drawing.Size(884, 300);
            this.dgvAutores.TabIndex = 0;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            // 
            // frmAutore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutore";
            this.Text = "frmAutore";
            this.Load += new System.EventHandler(this.frmAutore_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAddAutor.ResumeLayout(false);
            this.tpAddAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpSeeAutor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAddAutor;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtName;
        private Label lblName;
        private Button btnSave;
        private TabPage tpSeeAutor;
        private DataGridView dgvAutores;
        private Button btnMostAutors;
        private Button btnEditar;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}