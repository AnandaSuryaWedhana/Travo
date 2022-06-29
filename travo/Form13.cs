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
    public partial class FormAdminPelanggan : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formadmin formempatbelas;
        string id = "";
        int rowsCount = 0;
        public FormAdminPelanggan()
        {
            InitializeComponent();
        }

        private void FormAdminPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtpelanggan = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_PELANGGAN as `Id Pelanggan`,EMAIL_PELANGGAN as `Email`,NO_TELPHONE as `No Telp`,KEWARGANEGARAAN as `Kewarganegaraan`,NAMA_PELANGGAN as `Nama Pelanggan`,PASSWORD as `Password`,DELETE_PELANGGAN as `Delete` FROM pelanggan ";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpelanggan);
                dataGridView1.DataSource = dtpelanggan;
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
                if (tbnamapelanggan.Text != "")
                {
                    DataTable dtCount = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM pelanggan WHERE NAMA_PELANGGAN LIKE '" + tbnamapelanggan.Text.Substring(0, 1) + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCount);
                    
                    rowsCount = dtCount.Rows.Count;
                    rowsCount++;

                    string nol = "";
                    if (rowsCount < 1)
                    {
                        nol += "0";
                    }
                    id = tbnamapelanggan.Text.Substring(0, 1).ToUpper() + nol + rowsCount.ToString();
                    tbidpelanggan.Text = id;
                }
                query = "INSERT INTO pelanggan VALUES('" + id + "','" + tbemail.Text + "','" + tbnotelp.Text + "','"+cbkewarganegaraan.SelectedValue.ToString()+"','"+tbnamapelanggan.Text+"','"+tbpassword.Text+"',0)";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di Input");
                
                sqlConnect.Close();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            Finsertpelanggan datainsertpelanggan = new Finsertpelanggan();
            datainsertpelanggan.formtigabelas = this;
            datainsertpelanggan.Show();
        }

        private void DGV_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidpelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbnamapelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbnotelp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbemail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                tbpassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Data belum dipilih !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
            dtback.formtigabelas = this;
            dtback.Show();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formtigabelas = this;
            dtlogin.Show();
        }
    }
}
