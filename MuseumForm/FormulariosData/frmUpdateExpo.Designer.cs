namespace MuseumForm.FormulariosData
{
    partial class frmUpdateExpo
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
            this.dtpFechaExpo = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.cmbAutors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaExpo
            // 
            this.dtpFechaExpo.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaExpo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaExpo.Location = new System.Drawing.Point(103, 119);
            this.dtpFechaExpo.Name = "dtpFechaExpo";
            this.dtpFechaExpo.Size = new System.Drawing.Size(105, 23);
            this.dtpFechaExpo.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(56, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(104, 72);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 23);
            this.txtPlace.TabIndex = 16;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(56, 75);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(40, 15);
            this.lblLugar.TabIndex = 15;
            this.lblLugar.Text = "Lugar:";
            // 
            // cmbAutors
            // 
            this.cmbAutors.FormattingEnabled = true;
            this.cmbAutors.Location = new System.Drawing.Point(99, 170);
            this.cmbAutors.Name = "cmbAutors";
            this.cmbAutors.Size = new System.Drawing.Size(187, 23);
            this.cmbAutors.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Autor:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(132, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Id:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateExpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpFechaExpo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.cmbAutors);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateExpo";
            this.Text = "frmUpdateExpo";
            this.Load += new System.EventHandler(this.frmUpdateExpo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpFechaExpo;
        private Label lblFecha;
        private TextBox txtPlace;
        private Label lblLugar;
        private ComboBox cmbAutors;
        private Label label1;
        private Button btnCancel;
        private Label lblId;
        private Label label2;
        private Button btnUpdate;
    }
}