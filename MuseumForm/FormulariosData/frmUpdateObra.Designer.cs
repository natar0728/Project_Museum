namespace MuseumForm.FormulariosData
{
    partial class frmUpdateObra
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
            btnCancel = new Button();
            lblId = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            cmbTypes = new ComboBox();
            label3 = new Label();
            txtDesc = new TextBox();
            label4 = new Label();
            txtTittle = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(168, 62);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 24;
            lblId.Text = "--";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 62);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 23;
            label1.Text = "Id:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(91, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbTypes
            // 
            cmbTypes.FormattingEnabled = true;
            cmbTypes.Items.AddRange(new object[] { "Pintura al Oleo", "Escultura", "Otro" });
            cmbTypes.Location = new Point(152, 208);
            cmbTypes.Name = "cmbTypes";
            cmbTypes.Size = new Size(121, 23);
            cmbTypes.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 211);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 26;
            label3.Text = "Tipo:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(152, 168);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(100, 23);
            txtDesc.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 176);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 30;
            label4.Text = "Descripcion:";
            // 
            // txtTittle
            // 
            txtTittle.Location = new Point(152, 128);
            txtTittle.Name = "txtTittle";
            txtTittle.Size = new Size(100, 23);
            txtTittle.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 134);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 28;
            label5.Text = "Titulo:";
            // 
            // frmUpdateObra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 442);
            Controls.Add(txtDesc);
            Controls.Add(label4);
            Controls.Add(txtTittle);
            Controls.Add(label5);
            Controls.Add(cmbTypes);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(lblId);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Name = "frmUpdateObra";
            Text = "frmUpdateObra";
            Load += frmUpdateObra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Label lblId;
        private Label label1;
        private Button btnUpdate;
        private ComboBox cmbTypes;
        private Label label3;
        private TextBox txtDesc;
        private Label label4;
        private TextBox txtTittle;
        private Label label5;
    }
}