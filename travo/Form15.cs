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
    public partial class Finsertpakettour : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        DataTable dtkategori = new DataTable();
        public FormAdminPaketTour formduabelas;
        string id = "";
        int rowsCount = 0;
        public Finsertpakettour()
        {
            InitializeComponent();
        }

        private void Finsertpakettour_Load(object sender, EventArgs e)
        {
            try
            {
                tbidpaket.Enabled = false;
                tbiddaerahinsert.Enabled = false;
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_KATEGORI as `Id Kategori`,JENIS_KATEGORI as `Jenis Kategori` FROM kategori";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtkategori);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg;*.jpeg)|*.jpg;*.jpeg";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pbinsertfoto.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            FormAdminPaketTour dtback = new FormAdminPaketTour();
            dtback.formlimabelas = this;
            dtback.Show();
        }

        private void tbidpaket_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (idkategori.Text.ToString() != "")
                {

                    DataTable dtCount = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM kategori WHERE JENIS_KATEGORI LIKE '" + idkategori.Text.Substring(0, 1) + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCount);
                    DataTable dtCountkategori = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM kategori WHERE JENIS_KATEGORI LIKE '%" + idkategori.Text.Substring(0, 1) + "';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCountkategori);
                    rowsCount = dtCountkategori.Rows.Count;

                    string nol = "";
                    rowsCount++;
                    if (rowsCount < 1)
                    {
                        nol += "0";
                    }
                    id = idkategori.Text.Substring(0,1).ToUpper();
                    tbidpaket.Text = id;
                }
                query = "INSERT INTO paket__tour VALUES('" + id + "','" + tbiddaerahinsert.Text + "','" + idkategori.Text.ToString() + "','" + tbnamapinsert.Text + "','" + tbketentuaninsert.Text + "','" + tbkendaraaninsert.Text + "','" + tbdetailinsert.Text + "','" + tbhargainsert.Text + "',',0)";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di Input");
                sqlConnect.Close();
                
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbnamapinsert_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
