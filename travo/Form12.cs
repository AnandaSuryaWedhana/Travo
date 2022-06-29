using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace travo
{
    public partial class FormAdminPaketTour : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formadmin formempatbelas;
        public Finsertpakettour formlimabelas;
        public FormAdminPaketTour()
        {
            InitializeComponent();
        }

        private void FormAdminPaketTour_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtpaketour = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_PAKET_TOUR as `ID Paket Tour`,ID_DAERAH as `ID daerah`,ID_KATEGORI as `ID Kategori`,NAMA_PAKET_TOUR as `Nama Paket Tour`,KETENTUAN as `Ketentuan`,KENDARAAN as `Kendaraan`,DETAIL as `Detail`,HARGA_TOUR_ORG as `Harga Tour`,FOTO as `Foto`,DELETE_PELANGGAN as `Delete` FROM paket__tour";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpaketour);
                dataGridView1.DataSource = dtpaketour;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidpaket.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               tbdaerah.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbnamapaket.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbketentuan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbkendaraan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbdetail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbharga.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            Finsertpakettour datainsertPT = new Finsertpakettour();
            datainsertPT.formduabelas = this;
            datainsertPT.Show();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "DELETE FROM paket__tour WHERE ID_PAKET_TOUR = '" + tbidpaket.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Delete");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
            dtback.formduabelas = this;
            dtback.Show();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formduabelas = this;
            dtlogin.Show();
        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                query = "UPDATE paket__tour SET NAMA_PAKET_TOUR = '" + tbnamapaket.Text.ToString() + "', KETENTUAN ='" + tbketentuan.Text.ToString() + "', KENDARAAN ='" + tbkendaraan.Text.ToString() + "','"+tbdetail.Text.ToString()+"','"+tbharga.Text.ToString()+"', DELETE_DAERAH = 0 WHERE ID_PAKET_TOUR = '" + tbidpaket.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
