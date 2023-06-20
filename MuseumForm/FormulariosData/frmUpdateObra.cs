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
using System.Xml.Linq;

namespace MuseumForm.FormulariosData
{
    public partial class frmUpdateObra : Form
    {
        public frmUpdateObra()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateObra();
        }

        private async void UpdateObra()
        {
            int id = int.Parse(lblId.Text);
            ObraUpdateDto ObrDto = new ObraUpdateDto();
            ObrDto.Id = int.Parse(lblId.Text);
            ObrDto.Titulo = txtTittle.Text;
            ObrDto.Descripcion = txtDesc.Text;
            ObrDto.Tipo = cmbTypes.Text;
            ObrDto.AuthorId = frmObra.ObraToUpdate.AuthorId;



            using (var client = new HttpClient())
            {
                var obra = JsonConvert.SerializeObject(ObrDto);
                var content = new StringContent(obra, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Obra", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("obra actualizado");
                else
                    MessageBox.Show($"Error al actualizar la obra: {response.StatusCode}");
            }
            Clear();
            //Falta que al cerrar Actualice el DataGrid del otro form.
            this.Close();

        }
        private void Clear()
        {
            lblId.Text = "--";
            txtTittle.Text = String.Empty;
            txtDesc.Text = String.Empty;
            cmbTypes.Text = String.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateObra_Load(object sender, EventArgs e)
        {
            lblId.Text = (frmObra.ObraToUpdate.Id).ToString();
            txtTittle.Text = frmObra.ObraToUpdate.Titulo;
            txtDesc.Text = frmObra.ObraToUpdate.Descripcion;
            cmbTypes.Text = frmObra.ObraToUpdate.Tipo;
        }
    }
}
