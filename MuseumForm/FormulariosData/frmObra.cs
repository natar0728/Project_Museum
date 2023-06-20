using Museum.Models.Dto;
using MuseumForm.Helpers;
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

    /*u
     */
    public partial class frmObra : Form
    {
        public frmObra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Boton Registrar
        {

            var LastAutor = listaAutores.LastOrDefault();
            int idNewAut = LastAutor.Id;

            AddObraWNewAu(idNewAut);

        }


        private async void AddObraWNewAu(int idAutN)
        {
            ObraCreateDto oObra = new ObraCreateDto();
            oObra.Titulo = txtTittleNAut.Text;
            oObra.Tipo = cmbTypesNewAut.Text;
            oObra.Descripcion = txtDescNAut.Text;


            AutorCreateDto oAutor = new AutorCreateDto();
            oAutor.Name = txtNameAut.Text;
            oAutor.LastName = txtLastNameAut.Text;
            oAutor.Email = txtEmailAut.Text;

            using (var client = new HttpClient())
            {
                var serializedAutor = JsonConvert.SerializeObject(oAutor);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Autors", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Autor agregado");
                    GetAllAutors();

                }
                else
                    MessageBox.Show($"Error al guardar el Autor: {response.Content.ReadAsStringAsync().Result}");
            }


            oObra.AuthorId = listaAutores.LastOrDefault().Id + 1;

            using (var client = new HttpClient())
            {
                var serializedObra = JsonConvert.SerializeObject(oObra);
                var content = new StringContent(serializedObra, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Obra", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Obra agregada");
                else
                    MessageBox.Show($"Error al guardar la obra: {response.Content.ReadAsStringAsync().Result}");
            }

        }


        int id_obr = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
        }


        static public ObraDto ObraToUpdate = null;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //hel.GetAutorById(id_form);

            GetObraById(id_obr);


            frmUpdateObra updaobr = new frmUpdateObra();
            updaobr.Show();


            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        public async void GetObraById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Obra", id));
                if (response.IsSuccessStatusCode)
                {
                    var obe = await response.Content.ReadAsStringAsync();
                    ObraDto obraDto = JsonConvert.DeserializeObject<ObraDto>(obe);
                    //txtStudentId.Text = studentDto.StudentId.ToString();
                    //txtStudentName.Text = studentDto.StudentName;
                    ObraToUpdate = obraDto;


                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Autor: {response.StatusCode}");
                }
            }
        }



        #region Cosos que di por accidente
        #endregion


        private void btnSeeObrs_Click(object sender, EventArgs e)
        {
            GetAllObras();

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;


        }

        private void CreateColumns(DataGridView dg)
        {
            //Datos obra
            dg.Columns.Add("Id_Obra", "Id Obra");
            dg.Columns.Add("Title", "Titulo");
            dg.Columns.Add("Descript", "Descripcion");
            dg.Columns.Add("Type", "Tipo");



            dg.Columns.Add("Name", "Nombre Autor");
            dg.Columns.Add("Lastname", "Apellido Autor");
        }

        private void ChargeRows(DataGridView dg, List<AutorDto> auts, List<ObraDto> obrs)
        {


            dg.Columns.Clear();
            CreateColumns(dg);
            dg.Rows.Clear();
            //dg.DataSource = null;

            var result = from obr in obrs
                         join aut in auts on obr.AuthorId equals aut.Id into gj
                         select new
                         {
                             Id = obr.Id,
                             Tittle = obr.Titulo,
                             Descrip = obr.Descripcion,
                             Type = obr.Tipo,
                             Autor = gj

                         };




            foreach (var o in result)
            {
                foreach (var a in o.Autor)
                {

                    int n = dg.Rows.Add();

                    //Obra
                    dg.Rows[n].Cells[0].Value = o.Id;
                    dg.Rows[n].Cells[1].Value = o.Tittle;
                    dg.Rows[n].Cells[2].Value = o.Descrip;
                    dg.Rows[n].Cells[3].Value = o.Type;

                    //Autor
                    dg.Rows[n].Cells[4].Value = a.Name;
                    dg.Rows[n].Cells[5].Value = a.LastName;

                }
            }
        }


        private async void GetAllObras()
        {

            List<AutorDto> auts = new List<AutorDto>();
            List<ObraDto> obrs = new List<ObraDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7092/api/Autors"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var autores = await response.Content.ReadAsStringAsync();
                        var displaydata_Au = JsonConvert.DeserializeObject<List<AutorDto>>(autores);

                        auts = displaydata_Au.ToList();
                        //dgvAutors.DataSource = displaydata_Au.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Autores: {response.StatusCode}");
                    }
                }
            }

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7092/api/Obra"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var obras = await response.Content.ReadAsStringAsync();
                        var displaydata_ob = JsonConvert.DeserializeObject<List<ObraDto>>(obras);
                        obrs = displaydata_ob.ToList();

                        //dgvAutors.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de obras: {response.StatusCode}");
                    }
                }
            }

            //var datos = new { };

            ChargeRows(dgvObras, auts, obrs);


        }


        //List<AutorDto> listAutores = new List<AutorDto>();

        List<AutorDto> listaAutores = new List<AutorDto>();
        private void frmObra_Load(object sender, EventArgs e)
        {

            GetAllAutors();


        }

        public async void GetAllAutors()
        {
            List<AutorDto> auts = new List<AutorDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7092/api/Autors"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var autores = await response.Content.ReadAsStringAsync();
                        var displaydata_Au = JsonConvert.DeserializeObject<List<AutorDto>>(autores);

                        auts = displaydata_Au.ToList();
                        listaAutores = auts;

                        var Ids = from aut in listaAutores select aut.Id;

                        cmbAutors.DataSource = Ids.ToList();

                        //var Ids = from aut in auts select aut.Id;

                        //cmbAutors.DataSource = Ids.ToList();

                        //dgvAutors.DataSource = displaydata_Au.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Autores: {response.StatusCode}");
                    }
                }
            }

        }

        private void cmbAutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAutorById(int.Parse(cmbAutors.Text));
            txtNameAut.Text = aut.Name;
        }

        AutorDto aut = new AutorDto();
        public async void GetAutorById(int id)
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

                    aut = autorDto;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Autor: {response.StatusCode}");
                }
            }
        }

        private void btnRegistWithAut_Click(object sender, EventArgs e)
        {
            AddObraWExistAu();
        }

        private async void AddObraWExistAu()
        {
            ObraCreateDto oObra = new ObraCreateDto();
            oObra.Titulo = txtTittleWAut.Text;
            oObra.Tipo = cmbTypesWithAut.Text;
            oObra.Descripcion = txtDescWAu.Text;
            oObra.AuthorId = int.Parse(cmbAutors.Text);

            using (var client = new HttpClient())
            {
                var serializedObra = JsonConvert.SerializeObject(oObra);
                var content = new StringContent(serializedObra, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Obra", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Obra agregada");
                else
                    MessageBox.Show($"Error al guardar la obra: {response.Content.ReadAsStringAsync().Result}");
            }
        }




        //int id_ObEditElim = 0;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id_obr != 0)
            {
                DeleteObra(id_obr);
            }
        }
        private async void DeleteObra(int id_toElim)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/api/Obra");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7092/api/Obra", id_toElim));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Obra eliminada.");
                else
                    MessageBox.Show($"No se pudo eliminar la Obra: {response.StatusCode}");
            }
            //Clear();

        }

        private void dgvObras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvObras.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id_obr = int.Parse(row.Cells[0].Value.ToString());
                    //GetAutorById(id_form);




                    lblIdSelected.Text = row.Cells[0].Value.ToString();
                    GetObraById(id_obr);

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            btnDelete.Enabled = true;

            btnEdit.Enabled = true;

        }
    }
}
