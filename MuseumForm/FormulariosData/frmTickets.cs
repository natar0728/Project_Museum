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
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        #region Variables del Form
        List<ClientDto> clts = new List<ClientDto>();
        List<TicketDto> tcks = new List<TicketDto>();

        #endregion

        #region Metodos del Form
        private void CreateColumnsTicket(DataGridView dg)
        {
            dg.Columns.Add("Id", "Id");
            dg.Columns.Add("Header", "Header");
            dg.Columns.Add("DateCompra", "Fecha compra");
            //Datos Cleinte
            dg.Columns.Add("Id_Cliente", "Id Cliente");
            dg.Columns.Add("NombreCliente", "Nombre");
        }

        private void ChargeRowsTicket(DataGridView dg, List<TicketDto> tck, List<ClientDto> clt)
        {


            dg.Columns.Clear();
            CreateColumnsTicket(dg);
            dg.Rows.Clear();
            //dg.DataSource = null;


            var result = from tc in tck
                         join cl in clt on tc.ClientId equals cl.Id into gj
                         select new
                         {
                             Id = tc.Id,
                             Header = tc.Header,
                             Fecha_Compra = tc.FechaCompra,
                             Cliente = gj

                         };


            foreach (var t in result)
            {
                foreach (var c in t.Cliente)
                {

                    int n = dg.Rows.Add();


                    dg.Rows[n].Cells[0].Value = t.Id;
                    dg.Rows[n].Cells[1].Value = t.Header;
                    dg.Rows[n].Cells[2].Value = t.Fecha_Compra.Date.ToShortDateString();

                    dg.Rows[n].Cells[3].Value = c.Id;
                    dg.Rows[n].Cells[4].Value = c.ClientName;

                }
            }
        }




        //-----------------------------
        private void CreateColumnsClient(DataGridView dg)
        {
            dg.Columns.Add("Id", "Id");
            dg.Columns.Add("Nobmre", "Header");
            dg.Columns.Add("DateCompra", "Fecha compra");
            //Datos Cleinte
            dg.Columns.Add("Id_Cliente", "Id Cliente");
            dg.Columns.Add("NombreCliente", "Nombre");
        }

        private void ChargeRowsCliente(DataGridView dg, List<ClientDto> clt)
        {
            dg.DataSource = clt;
        }

        //-----------------------------



        private void btnCargarTickets_Click(object sender, EventArgs e)
        {
            GetAllTicket();
            GetAllClientes();
            btnEliminarTickets.Enabled = false;
            btnEliminarTickets.Enabled = false;

        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            lblFechaHoy.Text = DateTime.Now.ToShortDateString();
            lblFechaNCl.Text = DateTime.Now.ToShortDateString();
            GetAllTicket();
            GetAllClientes();
        }

        private void btnCargarClients_Click(object sender, EventArgs e)
        {
            GetAllClientes();
        }

        #endregion

        #region Metodos de API TICKET


        private async void GetAllTicket()
        {




            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7092/api/Ticket"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var Tickets = await response.Content.ReadAsStringAsync();
                        var displaydata_tck = JsonConvert.DeserializeObject<List<TicketDto>>(Tickets);
                        tcks = displaydata_tck.ToList();

                        //dgvAutors.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Tickets: {response.StatusCode}");
                    }
                }
            }

            //var datos = new { };

            //hel.GetAllAutors_and_Obras();

            //auts = hel.returnAutors();
            //obrs = hel.returnObras();





        }

        #endregion

        #region MEtodos de API CLIENTES
        private async void GetAllClientes()
        {


            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7092/api/Cliente"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var clientes = await response.Content.ReadAsStringAsync();
                        var displaydata_Cl = JsonConvert.DeserializeObject<List<ClientDto>>(clientes);

                        clts = displaydata_Cl.ToList();
                        //dgvAutors.DataSource = displaydata_Au.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Clientes: {response.StatusCode}");
                    }
                }
            }

            ChargeRowsTicket(dgvTickets, tcks, clts);
            ChargeRowsCliente(dgvClients, clts);
            dgvSerchClient.DataSource = clts;


        }


        #endregion

        private void txtSerchClient_KeyUp(object sender, KeyEventArgs e)
        {
            querClient();
        }

        private void querClient()
        {
            var search = clts.Where(x => x.ClientName.ToUpper().Contains(txtSerchClient.Text.ToUpper())).
                Select(x => x);

            dgvSerchClient.DataSource = search.ToList();
        }

        int idClient_ToCreateTicket = 0;
        int idClient_ToUpdateTck = 0;
        int idTicket = 0;
        private void dgvSerchClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSerchClient.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    lblIdSelcted.Text = (row.Cells[0].Value.ToString());
                    int idCl = int.Parse(lblIdSelcted.Text);
                    idClient_ToCreateTicket = idCl;

                    GetClientById(idCl);

                    btnGenTicket.Enabled = true;
                }
            }
        }


        public static ClientDto cltToUpdate = new ClientDto();
        private async void GetClientById(int v)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Cliente", v));
                if (response.IsSuccessStatusCode)
                {
                    var Clt = await response.Content.ReadAsStringAsync();
                    ClientDto CltDto = JsonConvert.DeserializeObject<ClientDto>(Clt);
                    //txtStudentId.Text = studentDto.StudentId.ToString();
                    //txtStudentName.Text = studentDto.StudentName;
                    cltToUpdate = CltDto;


                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Cliente: {response.StatusCode}");
                }
            }
        }

        private void btnGenTicket_Click(object sender, EventArgs e)
        {
            AddTicketWExistClient();
        }


        private async void AddTicketWExistClient()
        {
            TicketCreateDto oTicket = new TicketCreateDto();
            oTicket.Header = "Acceso para el besto Museo";
            oTicket.FechaCompra = DateTime.Now;
            oTicket.ClientId = idClient_ToCreateTicket;




            using (var client = new HttpClient())
            {
                var serializedAutor = JsonConvert.SerializeObject(oTicket);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Ticket", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Ticket generado");
                else
                    MessageBox.Show($"Error al generar el ticket: {response.Content.ReadAsStringAsync().Result}");
            }

            //ShowAutors();
            //Clear();
            Console.WriteLine();
        }

        private void btnGTckAndNClient_Click(object sender, EventArgs e)
        {
            AddTicketWNewClient();
        }

        private async void AddTicketWNewClient(/*int idcl*/)
        {
            TicketCreateDto oTicket = new TicketCreateDto();
            oTicket.Header = "Acceso para el museo";
            oTicket.FechaCompra = DateTime.Now;


            ClientCreateDto oClient = new ClientCreateDto();
            oClient.ClientName = txtNombreNewClient.Text;
            oClient.PhoneNumber = txtPhoneNewClient.Text;

            using (var client = new HttpClient())
            {
                var serializedAutor = JsonConvert.SerializeObject(oClient);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Cliente", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente agregado");
                    GetAllClientes();

                }
                else
                    MessageBox.Show($"Error al guardar el Cliente: {response.Content.ReadAsStringAsync().Result}");
            }

            //hmm
            GetAllClientes();


            if (clts.LastOrDefault() == null)
            {
                oTicket.ClientId = 1;
            }
            else
            {
                oTicket.ClientId = clts.LastOrDefault().Id + 1;
            }

            using (var client = new HttpClient())
            {
                var serializedObra = JsonConvert.SerializeObject(oTicket);
                var content = new StringContent(serializedObra, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7092/api/Ticket", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Ticket generado");
                else
                    MessageBox.Show($"Error al generar el ticket: {response.Content.ReadAsStringAsync().Result}");
            }

        }

        private void btnEliminarTickets_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            DeleteTicket(idTicket);
        }

        private async void DeleteTicket(int id_Tck)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/api/Ticket");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7092/api/Ticket", id_Tck));

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Ticket eliminado.");
                else
                    MessageBox.Show($"No se pudo eliminar el Ticket: {response.StatusCode}");
            }
            //GetAllAutors_and_Obras();

        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTickets.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    lblIdTckSel.Text = "Id Selecionado: " + (row.Cells[0].Value.ToString());
                    idTicket = int.Parse(row.Cells[0].Value.ToString());

                    GetTicketById(idTicket);

                    btnEliminarTickets.Enabled = true;
                    btnEditarTickets.Enabled = true;
                }
            }

        }

        public static TicketDto tckToUpdate = new TicketDto();
        private async void GetTicketById(int idTicket)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7092/api/Ticket", idTicket));
                if (response.IsSuccessStatusCode)
                {
                    var Tck = await response.Content.ReadAsStringAsync();
                    TicketDto TckDto = JsonConvert.DeserializeObject<TicketDto>(Tck);
                    //txtStudentId.Text = studentDto.StudentId.ToString();
                    //txtStudentName.Text = studentDto.StudentName;
                    tckToUpdate = TckDto;


                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Ticket: {response.StatusCode}");
                }
            }
        }

        private void btnEliminarClients_Click(object sender, EventArgs e)
        {

            DeleteClient(id_Client);

            btnEditarTickets.Enabled=false;
            btnEliminarTickets.Enabled=true;

        }


        private async void DeleteClient(int id_Clt)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/api/Cliente");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7092/api/Cliente", id_Clt));

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente eliminado.");
                else
                    MessageBox.Show($"No se pudo eliminar el Cliente: {response.StatusCode}");
            }
            //GetAllAutors_and_Obras();

        }

        int id_Client = 0;


        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    lblIdSelecClient.Text = "Id Selecionado: " + (row.Cells[0].Value.ToString());
                    id_Client = int.Parse(row.Cells[0].Value.ToString());

                    GetClientById(id_Client);

                    btnEliminarClients.Enabled = true;
                    btnEditarClients.Enabled = true;
                }
            }
        }

        private void btnEditarClients_Click(object sender, EventArgs e)
        {
            GetClientById(id_Client);


            frmUpdateClient updaoClt = new frmUpdateClient();
            updaoClt.Show();


            btnEditarClients.Enabled = false;
            btnEliminarClients.Enabled = false;
        }

        private void btnEditarTickets_Click(object sender, EventArgs e)
        {
            GetTicketById(idTicket);


            frmUpdateTicket updaoTck = new frmUpdateTicket();
            updaoTck.Show();


            btnEditarTickets.Enabled = false;
            btnEliminarTickets.Enabled = false;
        }
    }
}
