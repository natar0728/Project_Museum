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
    public partial class frmExposiciones : Form
    {


        int id_exp = 0;
        static public ExposicionDto ExpoToUpdate = null;
        List<AutorDto> listaAutores = new List<AutorDto>();



        public frmExposiciones()
        {
            InitializeComponent();
            dtpFechaExpo.MinDate = DateTime.Now;
        }

        private void btnSeeExpos_Click(object sender, EventArgs e)
        {
            GetAllExpos();

            btnDeleteExpo.Enabled = false;
            btnEditExpo.Enabled = false;

        }

        private void btnEditExpo_Click(object sender, EventArgs e)
        {
            GetExpoById(id_exp);


            frmUpdateExpo updaoexp = new frmUpdateExpo();
            updaoexp.Show();


            btnEditExpo.Enabled = false;
            btnDeleteExpo.Enabled = false;

        }

        private void btnDeleteExpo_Click(object sender, EventArgs e)
        {
            DeleteExpo(id_exp);
            btnEditExpo.Enabled = false;
            btnDeleteExpo.Enabled = false;
        }

        private void btnRegistWithAut_Click(object sender, EventArgs e)
        {
            var LastAutor = listaAutores.LastOrDefault();
            int idNewAut = LastAutor.Id + 1;

            AddExpoWExistAu();//hmmmmmmm
        }


        public async void GetExpoById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Exposicion", id));
                if (response.IsSuccessStatusCode)
                {
                    var exp = await response.Content.ReadAsStringAsync();
                    ExposicionDto expDto = JsonConvert.DeserializeObject<ExposicionDto>(exp);
                    //txtStudentId.Text = studentDto.StudentId.ToString();
                    //txtStudentName.Text = studentDto.StudentName;
                    ExpoToUpdate = expDto;


                }
                else
                {
                    MessageBox.Show($"No se puede obtener la Exposicion: {response.StatusCode}");
                }
            }
        }


        private void CreateColumns(DataGridView dg)
        {
            //Datos obra
            dg.Columns.Add("Id_Expo", "Id Expo");
            dg.Columns.Add("Sala", "Sala");
            dg.Columns.Add("Fecha", "Fecha");

            dg.Columns.Add("Name", "Nombre Autor");
            dg.Columns.Add("Lastname", "Apellido Autor");
        }

        private void ChargeRows(DataGridView dg, List<AutorDto> auts, List<ExposicionDto> expos)
        {


            dg.Columns.Clear();
            CreateColumns(dg);
            dg.Rows.Clear();
            //dg.DataSource = null;

            var result = from exp in expos
                         join aut in auts on exp.AuthorId equals aut.Id into gj
                         select new
                         {
                             Id = exp.Id,
                             Lugar = exp.Place,
                             Fecha = exp.Date,
                             Autor = gj

                         };




            foreach (var e in result)
            {
                foreach (var a in e.Autor)
                {

                    int n = dg.Rows.Add();

                    //Obra
                    dg.Rows[n].Cells[0].Value = e.Id.ToString();
                    dg.Rows[n].Cells[1].Value = e.Lugar;
                    dg.Rows[n].Cells[2].Value = e.Fecha.ToShortDateString().ToString();

                    //Autor
                    dg.Rows[n].Cells[3].Value = a.Name;
                    dg.Rows[n].Cells[4].Value = a.LastName;

                }
            }
        }


        private async void GetAllExpos()
        {

            List<AutorDto> auts = new List<AutorDto>();
            List<ExposicionDto> exps = new List<ExposicionDto>();

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
                using (var response = await client.GetAsync("https://localhost:7092/api/Exposicion"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var expos = await response.Content.ReadAsStringAsync();
                        var displaydata_exps = JsonConvert.DeserializeObject<List<ExposicionDto>>(expos);
                        exps = displaydata_exps.ToList();

                        //dgvAutors.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Exposiciones: {response.StatusCode}");
                    }
                }
            }

            //var datos = new { };

            ChargeRows(dgvExpos, auts, exps);


        }


        public static List<int> datasourceToFrmUpdateExp = new List<int>();
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
                        datasourceToFrmUpdateExp = Ids.ToList();

                        cmbAutors.DataSource = Ids.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Autores: {response.StatusCode}");
                    }
                }
            }

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



        private async void AddExpoWExistAu()
        {
            ExposicionCreateDto oExpo = new ExposicionCreateDto();
            oExpo.Place = txtPlace.Text;
            oExpo.Date = dtpFechaExpo.Value.Date;

            oExpo.AuthorId = int.Parse(cmbAutors.Text);

            using (var client = new HttpClient())
            {
                var serializedObra = JsonConvert.SerializeObject(oExpo);
                var content = new StringContent(serializedObra, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Exposicion", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Exposicion agregada");
                else
                    MessageBox.Show($"Error al guardar la Exposicion: {response.Content.ReadAsStringAsync().Result}");
            }
        }


        private async void DeleteExpo(int id_toElim)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/api/Exposicion");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7092/api/Exposicion", id_toElim));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Exposicion eliminada.");
                else
                    MessageBox.Show($"No se pudo eliminar la Exposicion: {response.StatusCode}");
            }
            //Clear();

        }

        private void frmExposiciones_Load(object sender, EventArgs e)
        {
            GetAllAutors();
        }

        private void dgvExpos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvExpos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id_exp = int.Parse(row.Cells[0].Value.ToString());
                    //GetAutorById(id_form);




                    lblIdSelected.Text = row.Cells[0].Value.ToString();
                    GetExpoById(id_exp);

                    btnEditExpo.Enabled = true;
                    btnDeleteExpo.Enabled = true;
                }
            }
            btnDeleteExpo.Enabled = true;

            btnEditExpo.Enabled = true;

        }
    }
}
