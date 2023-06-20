using Museum.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumForm.Helpers
{
    public class Helpers
    {
        #region Autor



        static AutorDto autorToUpdate = new AutorDto();
        static List<AutorDto> listaAutores = new List<AutorDto>();


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

                        //dgvAutors.DataSource = displaydata_Au.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Autores: {response.StatusCode}");
                    }
                }
            }
           
        }

        public List<AutorDto> returnListAutor()
        {
            return listaAutores;
        }


            List<AutorDto> auts = new List<AutorDto>();
            List<ObraDto> obrs = new List<ObraDto>();

        public async void GetAllAutors_and_Obras()
        {

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

            

            
        }

        public List<AutorDto> returnAutors()
        {
            return auts;
        }

        public List<ObraDto> returnObras()
        {
            return obrs;
        }

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
                    autorToUpdate = autorDto;


                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Autor: {response.StatusCode}");
                }
            }
        }

        public AutorDto RetornarAutorActual()
        {
            return autorToUpdate;
        }
        #endregion



        public async void GetAllObras()
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








        }
    }
}
