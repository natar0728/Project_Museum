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
    public partial class frmUpdateExpo : Form
    {
        public frmUpdateExpo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateExpo();
        }
        private async void UpdateExpo()
        {
            int id = int.Parse(lblId.Text);
            ExposicionUpdateDto ExpDto = new ExposicionUpdateDto();
            ExpDto.Id = int.Parse(lblId.Text);
            ExpDto.Place = txtPlace.Text;
            ExpDto.Date = dtpFechaExpo.Value.Date;

            ExpDto.AuthorId = int.Parse(cmbAutors.Text);



            using (var client = new HttpClient())
            {
                var obra = JsonConvert.SerializeObject(ExpDto);
                var content = new StringContent(obra, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Exposicion", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Exposicion actualizada");
                else
                    MessageBox.Show($"Error al actualizar la Exposicion: {response.StatusCode}");
            }
            Clear();
            //Falta que al cerrar Actualice el DataGrid del otro form.
            this.Close();

        }







        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Clear()
        {
            lblId.Text = "--";
            txtPlace.Text = String.Empty;
            dtpFechaExpo.Value = DateTime.Now;
            cmbAutors.Text = String.Empty;
        }


        private void frmUpdateExpo_Load(object sender, EventArgs e)
        {
            lblId.Text = (frmExposiciones.ExpoToUpdate.Id).ToString();
            txtPlace.Text = frmExposiciones.ExpoToUpdate.Place;
            dtpFechaExpo.Value = frmExposiciones.ExpoToUpdate.Date;
            cmbAutors.DataSource = frmExposiciones.datasourceToFrmUpdateExp;
        }
    }
}
