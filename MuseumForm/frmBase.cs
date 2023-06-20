using MuseumForm.FormulariosData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumForm
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        #region Open Forms
        private Form formActivo = null;
        private void AbrirNewForm(Form newForm)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(newForm);
            panelContenedor.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();

        }
        #endregion


        #region Opciones de ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //btnRestaur-------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Talvez cambiar esto con otro tipo....
            //De obtener la locacion y size antes de maximizar......
            btnMaximize.Visible = true;
            BtnRestaur.Visible = false;
            this.WindowState = FormWindowState.Normal;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            btnMaximize.Visible = false;
            BtnRestaur.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }


        private void panelBarr_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        #endregion

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirNewForm(new frmAutore());
        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            AbrirNewForm(new frmObra());
        }

        private void btnExpos_Click(object sender, EventArgs e)
        {
            AbrirNewForm(new frmExposiciones());
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            AbrirNewForm(new frmTickets());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirNewForm(new Home());
        }

        private void FormBase2_Load(object sender, EventArgs e)
        {
            AbrirNewForm(new Home());
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            AbrirNewForm(new Home());
        }
    }
}
