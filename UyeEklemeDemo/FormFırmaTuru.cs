using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UyeEklemeDemo
{
    public partial class FormFırmaTuru : Form
    {
        public FormFırmaTuru()
        {
            InitializeComponent();
        }

        private void FormFırmaTuru_Load(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("server=(localdb)\\mssqllocaldb;initial catalog=firmaTuru;integrated security=true");
            SqlCommand command = new SqlCommand("Select* from firmaTuru", _connection);

            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From firmaTuru", _connection);
            sqlDataAdapter.Fill(tablo);
            cbxFırmaTuru.ValueMember = "Firma Türü";
            cbxFırmaTuru.DataSource= tablo;
        }
    }
}
