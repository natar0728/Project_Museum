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
    public partial class frmAutore : Form
    {
        //-------------------------------------------------------------------------------

        

        //-------------------------------------------------------------------------------
        public frmAutore()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            GetAllAutors_and_Obras();

            btnEditar.Enabled = false;
            //dgvAutor_Obra.Visible = true;
            dgvAutores.Visible = false;
        }

        private void CreateColumns(DataGridView dg)
        {
            dg.Columns.Add("Id", "Id");
            dg.Columns.Add("Name", "Nombre");
            dg.Columns.Add("Lastname", "Apellido");
            dg.Columns.Add("Email", "Email");
           


        }

        private void ChargeRows(DataGridView dg, List<AutorDto> auts, List<ObraDto> obrs)
        {

            //Probamos muchas cosas profo;(  //

            //dg.Columns.Clear();
            //CreateColumns(dg);
            //dg.Rows.Clear();
            ////dg.DataSource = null;

            ////dgvAutor_Obra.Visible = true;
            //dgvAutores.Visible = false;


            //var result = from Aut in auts
            //             join Obr in obrs on Aut.Id equals Obr.AuthorId into gj
            //             select new
            //             {
            //                 Id = Aut.Id,
            //                 Nombre = Aut.Name,
            //                 Apellido = Aut.LastName,
            //                 Email = Aut.Email,
            //                 Obras = gj

            //             };


            //foreach (var a in result)
            //{
            //    foreach (var o in a.Obras)
            //    {

            //        int n = dg.Rows.Add();


            //        dg.Rows[n].Cells[0].Value = a.Id;
            //        dg.Rows[n].Cells[1].Value = a.Nombre;
            //        dg.Rows[n].Cells[2].Value = a.Apellido;
            //        dg.Rows[n].Cells[3].Value = a.Email;

            //        dg.Rows[n].Cells[4].Value = o.Id;
            //        dg.Rows[n].Cells[5].Value = o.Titulo;
            //        dg.Rows[n].Cells[6].Value = o.Descripcion;
            //        dg.Rows[n].Cells[7].Value = o.Tipo;

            //    }
            //}
        }

        private async void GetAllAutors_and_Obras()
        {


        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            AddAutor();

            btnEditar.Enabled = false;
            dgvAutores.Visible = true;
        }

        private async void AddAutor()
        {
            AutorCreateDto oAutor = new AutorCreateDto();
            oAutor.Name = txtName.Text;
            oAutor.LastName = txtLastName.Text;
            oAutor.Email = txtEmail.Text;




            using (var client = new HttpClient())
            {
                var serializedAutor = JsonConvert.SerializeObject(oAutor);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Autors", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Autor agregado");
                else
                    MessageBox.Show($"Error al guardar el Autor: {response.Content.ReadAsStringAsync().Result}");
            }

            ShowAutors();
            Clear();
            Console.WriteLine();
        }

        private void Clear()
        {
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        private void btnMostAutors_Click(object sender, EventArgs e)
        {
            dgvAutores.Visible = true;
            ShowAutors();
            btnEditar.Enabled = false;

        }

        private async void ShowAutors()
        {
            dgvAutores.Columns.Clear();
            dgvAutores.Rows.Clear();

            using (var client = new HttpClient())
            {

                using (var response = await client.GetAsync("https://localhost:7092/api/Autors"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var autores = await response.Content.ReadAsStringAsync();
                        var displaydata_Au = JsonConvert.DeserializeObject<List<AutorDto>>(autores);


                        //dgvAutores.DataSource = displaydata_Au.ToList();
                        dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                        CreateColumns(dgvAutores);


                        foreach (var o in displaydata_Au.ToList())
                        {
                           

                                int n = dgvAutores.Rows.Add();

                            //Obra
                            dgvAutores.Rows[n].Cells[0].Value = o.Id;
                            dgvAutores.Rows[n].Cells[1].Value = o.Name;
                            dgvAutores.Rows[n].Cells[2].Value = o.LastName;
                            dgvAutores.Rows[n].Cells[3].Value = o.Email;

                               
                        }


                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Autores: {response.StatusCode}");
                    }
                }
            }


        }

        



        //----------------------------------------

        int id_form = 0;
        private async void GetAutorById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Autors", id));
                if (response.IsSuccessStatusCode)
                {
                    var Aut = await response.Content.ReadAsStringAsync();
                    AutorDto autorDto = JsonConvert.DeserializeObject<AutorDto>(Aut);
                    //txtStudentId.Text = studentDto.StudentId.ToString();
                    //txtStudentName.Text = studentDto.StudentName;
                    autorToUpdate = autorDto;


                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Autor: {response.StatusCode}");
                }
            }
        }







        //----------------------------------------

        Helpers.Helpers hel = new Helpers.Helpers();

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAutores.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id_form = int.Parse(row.Cells[0].Value.ToString());
                    //GetAutorById(id_form);

                    hel.GetAutorById(id_form);



                    autorToUpdate = hel.RetornarAutorActual();

                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }

        }


        static public AutorDto autorToUpdate = null;
        private void btnEditar_Click(object sender, EventArgs e)
        {

            //hel.GetAutorById(id_form);

            autorToUpdate = hel.RetornarAutorActual();
            frmUpdateAutor updafrm = new frmUpdateAutor();
            updafrm.ShowDialog();


            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void dgvAutor_Obra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id_form != 0)
                DeleteAutor(id_form);
        }

        private async void DeleteAutor(int id_form)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/api/Autors");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7092/api/Autors", id_form));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Autor eliminado.");
                else
                    MessageBox.Show($"No se pudo eliminar el autor: {response.StatusCode}");
            }
            Clear();
            //GetAllAutors_and_Obras();

        }




        #region cosos que di por accidente
        private void tpAddAutor_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void frmAutore_Load(object sender, EventArgs e)
        {
            ShowAutors();
        }
    }
}
