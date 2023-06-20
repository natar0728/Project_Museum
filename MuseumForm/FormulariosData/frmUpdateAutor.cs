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
    public partial class frmUpdateAutor : Form
    {
        public frmUpdateAutor()
        {
            InitializeComponent();
        }

        private void frmUpdateAutor_Load(object sender, EventArgs e)
        {
            lblId.Text = (frmAutore.autorToUpdate.Id).ToString();
            txtName.Text = frmAutore.autorToUpdate.Name;
            txtLastName.Text = frmAutore.autorToUpdate.LastName;
            txtEmail.Text = frmAutore.autorToUpdate.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //}
            //else ()
            //{

            //}
            UpdateAutor();
        }

        private async void UpdateAutor()
        {
            int id = int.Parse(lblId.Text);
            AutorUpdateDto autDto = new AutorUpdateDto();
            autDto.Id = int.Parse(lblId.Text);
            autDto.Name = txtName.Text;
            autDto.LastName = txtLastName.Text;
            autDto.Email = txtEmail.Text;



            using (var client = new HttpClient())
            {
                var a = JsonConvert.SerializeObject(autDto);
                var content = new StringContent(a, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Autors", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Autor actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Autor: {response.StatusCode}");
            }
            Clear();
            //Falta que al cerrar Actualice el DataGrid del otro form.
            this.Close();

        }
        private void Clear()
        {
            lblId.Text = "--";
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }
    }
}
