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
    public partial class frmUpdateTicket : Form
    {
        public frmUpdateTicket()
        {
            InitializeComponent();
          
        }

        private void frmUpdateTicket_Load(object sender, EventArgs e)
        {
            lblId.Text = frmTickets.tckToUpdate.Id.ToString();
            txtHeader.Text = frmTickets.tckToUpdate.Header;
            dtpFecha.Value = frmTickets.tckToUpdate.FechaCompra;
            CltId = frmTickets.tckToUpdate.ClientId;
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCliente();
        }

        int CltId = 0;
        private async void UpdateCliente()
        {
            int id = int.Parse(lblId.Text);
            TicketUpdateDto TckDto = new TicketUpdateDto();
            TckDto.Id = int.Parse(lblId.Text);
            TckDto.Header = txtHeader.Text;
            TckDto.FechaCompra = dtpFecha.Value;
            TckDto.ClientId = CltId;

            using (var client = new HttpClient())
            {
                var cliente = JsonConvert.SerializeObject(TckDto);
                var content = new StringContent(cliente, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Ticket", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Ticket actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Ticket: {response.StatusCode}");
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
