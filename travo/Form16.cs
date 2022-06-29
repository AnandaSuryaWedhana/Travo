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
    public partial class Finsertpelanggan : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;

        public FormAdminPelanggan formtigabelas;
        public Finsertpelanggan()
        {
            InitializeComponent();
        }

        private void Finsertpelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
