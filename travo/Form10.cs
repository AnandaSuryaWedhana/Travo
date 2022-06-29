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
    public partial class FormAdminDaerah : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formadmin formempatbelas;
        DataTable dtNat = new DataTable();
        DataTable dtCount = new DataTable();
        DataTable dtCountdaerah = new DataTable();
        
        string id = "";
        int rowsCount = 0;
        public static string id_click;
        public Boolean inscek = true;
        public FormAdminDaerah()
        {
            InitializeComponent();
        }

        private void FormAdminDaerah_Load(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_DAERAH as `DELETE` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;

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
                if (tbnegarainsert.Text != "")
                {
                    dtCount = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM daerah WHERE NAMA_NEGARA LIKE '" + tbnegarainsert.Text.Substring(0, 1) + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCount);
                    dtCountdaerah = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM daerah WHERE NAMA_DAERAH LIKE '" + tbdaerahinsert.Text.Substring(0, 1) + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCountdaerah);
                    rowsCount = dtCountdaerah.Rows.Count;
                    rowsCount++;

                    string nol = "";
                    if (rowsCount < 1)
                    {
                        nol += "0";
                    }
                    id = tbnegarainsert.Text.Substring(0, 1).ToUpper() + tbdaerahinsert.Text.Substring(0, 1).ToUpper() + nol + rowsCount.ToString();
                    Tbidinsert.Text = id;
                }
                query = "INSERT INTO daerah VALUES('" + id + "','" + tbdaerahinsert.Text + "','" + tbnegarainsert.Text + "','" + tbkotainsert.Text + "',DELETE_DAERAH = 0)";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di Input");
                //daerah();
                sqlConnect.Close();
                

                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_DAERAH as `DELETE` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;
            }
            catch (Exception ex)
            {
                sqlConnect.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void tbnamanegara_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //public void daerah()
        //{
            
        //    DataTable dtdaerah = new DataTable();
        //    query = "SELECT * FROM daerah";
        //    sqlConnect = new MySqlConnection(stringConnect);
        //    sqlCommand = new MySqlCommand(query, sqlConnect);
        //    sqlAdapter = new MySqlDataAdapter(sqlCommand);
        //    sqlAdapter.Fill(dtdaerah);
        //    sqlCommand.ExecuteNonQuery();
        //    dataGridView1.DataSource = dtdaerah;
        //}

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "DELETE FROM daerah WHERE ID_DAERAH = '" + tbidupdate.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Delete");

                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_DAERAH as `DELETE` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbdaerahupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbkotaupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbnegaraupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                query ="UPDATE daerah SET NAMA_DAERAH = '"+tbdaerahupdate.Text.ToString() + "', NAMA_NEGARA ='"+tbnegaraupdate.Text.ToString()+"', NAMA_KOTA ='" + tbkotaupdate.Text.ToString() + "',DELETE_DAERAH = 0 WHERE ID_DAERAH = '" + tbidupdate.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Update");

                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_DAERAH as `DELETE` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;
            }
            catch (Exception ex)
            {

                sqlConnect.Close();
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void rbfalseinsert_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
           dtback.formsepuluh = this;
           dtback.Show();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formsepuluh = this;
            dtlogin.Show();
        }

        private void tbidupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbidinsert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
