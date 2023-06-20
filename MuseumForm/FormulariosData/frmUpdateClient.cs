using Museum.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumForm.FormulariosData
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            txtNombre.Text = frmTickets.cltToUpdate.ClientName;
            TxtPhone.Text =  frmTickets.cltToUpdate.PhoneNumber;
            lblId.Text =  frmTickets.cltToUpdate.Id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCliente();
        }

        private async void UpdateCliente()
        {
            int id = int.Parse(lblId.Text);
            ClientUpdateDto CltDto = new ClientUpdateDto();
            CltDto.Id = int.Parse(lblId.Text);
            CltDto.ClientName = txtNombre.Text;
            CltDto.PhoneNumber = TxtPhone.Text;

            using (var client = new HttpClient())
            {
                var cliente = JsonConvert.SerializeObject(CltDto);
                var content = new StringContent(cliente, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Cliente", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Cliente: {response.StatusCode}");
            }
           
            //Falta que al cerrar Actualice el DataGrid del otro form.
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
