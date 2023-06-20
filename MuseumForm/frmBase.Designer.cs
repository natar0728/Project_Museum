namespace MuseumForm
{
    partial class frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.btnObras = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.PictureBox();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnExpos = new System.Windows.Forms.Button();
            this.panelMenuMain = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBarr = new System.Windows.Forms.Panel();
            this.BtnRestaur = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOff)).BeginInit();
            this.panelMenuMain.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBarr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.DimGray;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(156, 35);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(886, 500);
            this.panelContenedor.TabIndex = 5;
            // 
            // btnLogo
            // 
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(13, 15);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(105, 84);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnObras
            // 
            this.btnObras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObras.FlatAppearance.BorderSize = 0;
            this.btnObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnObras.ForeColor = System.Drawing.Color.Firebrick;
            this.btnObras.Image = ((System.Drawing.Image)(resources.GetObject("btnObras.Image")));
            this.btnObras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObras.Location = new System.Drawing.Point(0, 233);
            this.btnObras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnObras.Name = "btnObras";
            this.btnObras.Size = new System.Drawing.Size(156, 51);
            this.btnObras.TabIndex = 6;
            this.btnObras.Text = "Obras";
            this.btnObras.UseVisualStyleBackColor = true;
            this.btnObras.Click += new System.EventHandler(this.btnObras_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAutores.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAutores.Image = ((System.Drawing.Image)(resources.GetObject("btnAutores.Image")));
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(0, 174);
            this.btnAutores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(156, 59);
            this.btnAutores.TabIndex = 4;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Firebrick;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 121);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 53);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOff
            // 
            this.btnOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.Location = new System.Drawing.Point(36, 844);
            this.btnOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(87, 113);
            this.btnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOff.TabIndex = 11;
            this.btnOff.TabStop = false;
            // 
            // btnTickets
            // 
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTickets.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnTickets.Image")));
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(0, 335);
            this.btnTickets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(156, 54);
            this.btnTickets.TabIndex = 10;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnExpos
            // 
            this.btnExpos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpos.FlatAppearance.BorderSize = 0;
            this.btnExpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExpos.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExpos.Image = ((System.Drawing.Image)(resources.GetObject("btnExpos.Image")));
            this.btnExpos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpos.Location = new System.Drawing.Point(0, 284);
            this.btnExpos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExpos.Name = "btnExpos";
            this.btnExpos.Size = new System.Drawing.Size(156, 51);
            this.btnExpos.TabIndex = 9;
            this.btnExpos.Text = "Eventos";
            this.btnExpos.UseVisualStyleBackColor = true;
            this.btnExpos.Click += new System.EventHandler(this.btnExpos_Click);
            // 
            // panelMenuMain
            // 
            this.panelMenuMain.AutoScroll = true;
            this.panelMenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.panelMenuMain.Controls.Add(this.btnOff);
            this.panelMenuMain.Controls.Add(this.btnTickets);
            this.panelMenuMain.Controls.Add(this.btnExpos);
            this.panelMenuMain.Controls.Add(this.btnObras);
            this.panelMenuMain.Controls.Add(this.btnAutores);
            this.panelMenuMain.Controls.Add(this.btnHome);
            this.panelMenuMain.Controls.Add(this.panelLogo);
            this.panelMenuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuMain.Location = new System.Drawing.Point(0, 35);
            this.panelMenuMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenuMain.Name = "panelMenuMain";
            this.panelMenuMain.Size = new System.Drawing.Size(156, 500);
            this.panelMenuMain.TabIndex = 4;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(156, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // panelBarr
            // 
            this.panelBarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.panelBarr.Controls.Add(this.BtnRestaur);
            this.panelBarr.Controls.Add(this.btnMaximize);
            this.panelBarr.Controls.Add(this.btnMinimize);
            this.panelBarr.Controls.Add(this.btnClose);
            this.panelBarr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarr.Location = new System.Drawing.Point(0, 0);
            this.panelBarr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBarr.Name = "panelBarr";
            this.panelBarr.Size = new System.Drawing.Size(1042, 35);
            this.panelBarr.TabIndex = 3;
            this.panelBarr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarr_MouseDown);
            // 
            // BtnRestaur
            // 
            this.BtnRestaur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaur.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestaur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaur.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnRestaur.ErrorImage")));
            this.BtnRestaur.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaur.Image")));
            this.BtnRestaur.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnRestaur.InitialImage")));
            this.BtnRestaur.Location = new System.Drawing.Point(970, 3);
            this.BtnRestaur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRestaur.Name = "BtnRestaur";
            this.BtnRestaur.Size = new System.Drawing.Size(29, 29);
            this.BtnRestaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaur.TabIndex = 7;
            this.BtnRestaur.TabStop = false;
            this.BtnRestaur.Visible = false;
            this.BtnRestaur.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(970, 3);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 29);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(932, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1009, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 535);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuMain);
            this.Controls.Add(this.panelBarr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase";
            this.Text = "FormBase2";
            this.Load += new System.EventHandler(this.FormBase2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOff)).EndInit();
            this.panelMenuMain.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelBarr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;

        private PictureBox btnLogo;
        private Button btnObras;
        private Button btnAutores;
        private Button btnHome;
        private PictureBox btnOff;
        private Button btnTickets;
        private Button btnExpos;
        private Panel panelMenuMain;
        private Panel panelLogo;
        private Panel panelBarr;

        private PictureBox btnMaximize;
        private PictureBox btnMinimize;
        private PictureBox pictureBox3;
        private PictureBox btnClose;
        private PictureBox BtnRestaur;
        private Button button1;
    }
}