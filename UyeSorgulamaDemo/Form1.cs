using DocumentFormat.OpenXml.Drawing.Diagrams;
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

namespace UyeSorgulamaDemo
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
           
        }

        SqlConnection connection = new SqlConnection("server=(localdb)\\mssqllocaldb;initial catalog=UyeSorgulama;integrated security=true");

        


        public List<Uye> GetAll()
        {

            connection.Open();
            SqlCommand command = new SqlCommand("Select* from UyeSorgulamaEkranı", connection);

            //komutu calıstırma
            SqlDataReader reader = command.ExecuteReader();

            List<Uye> uyeler = new List<Uye>();

            while (reader.Read()) //okuyabildigin sürece döngüyü calıstır
            {
                Uye uye = new Uye
                {
                    OdaSicilNo = Convert.ToInt32(reader["OdaSicilNo"]),
                    İlceKodu = Convert.ToInt32(reader["İlceKodu"]),
                    TicaretSicilNo = null,
                    Unvan = reader["Unvan"].ToString()
                };

                uyeler.Add(uye);
            }
            reader.Close();
            connection.Close();
            return uyeler;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgwUyeler.DataSource = null;
        }

        //oda sicil no
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //ilçe kodu
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //ünvan
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnSorgula_Click(object sender, EventArgs e)
        {
            dgwUyeler.ClearSelection();

            if (!string.IsNullOrEmpty(tbxUnvan.Text) && !string.IsNullOrEmpty(tbxkod.Text))
            {
                SqlCommand command;
                if (!string.IsNullOrEmpty(tbxOdaSicil.Text))
                {
                    // Construct the SQL query with all three fields
                    command = new SqlCommand("SELECT * FROM UyeSorgulamaEkranı WHERE OdaSicilNo = " + tbxOdaSicil.Text + " AND Unvan = '" + tbxUnvan.Text + "' AND İlceKodu = '" + tbxkod.Text + "'", connection);
                }
                else
                {
                    // Show an error message if OdaSicilNo is empty
                    MessageBox.Show("Oda Sicil No alanı boş bırakılamaz");
                    return;
                }

                connection.Open(); // Open the connection before executing the command

                // Execute the SQL query and display the results
                SqlDataReader reader = command.ExecuteReader();
                List<Uye> uyeler = new List<Uye>();

                while (reader.Read())
                {
                    Uye uye;
                    if (reader["TicaretSicilNo"] != DBNull.Value)
                    {
                        uye = new Uye
                        {
                            OdaSicilNo = Convert.ToInt32(reader["OdaSicilNo"]),
                            İlceKodu = Convert.ToInt32(reader["İlceKodu"]),
                            TicaretSicilNo = Convert.ToInt32(reader["TicaretSicilNo"]),
                            Unvan = reader["Unvan"].ToString()
                        };
                    }
                    else
                    {
                        uye = new Uye
                        {
                            OdaSicilNo = Convert.ToInt32(reader["OdaSicilNo"]),
                            İlceKodu = Convert.ToInt32(reader["İlceKodu"]),
                            TicaretSicilNo = null,
                            Unvan = reader["Unvan"].ToString()
                        };
                    }

                    uyeler.Add(uye);
                }

                reader.Close();
                connection.Close();

                dgwUyeler.DataSource = uyeler;
            }
            if (string.IsNullOrEmpty(tbxUnvan.Text) && string.IsNullOrEmpty(tbxkod.Text) && string.IsNullOrEmpty(tbxOdaSicil.Text))
            {
                dgwUyeler.DataSource = GetAll();
            }
        }




        private void tbxsicilno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTicaretSicil_Click(object sender, EventArgs e)
        {

        }

        private void tbxkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxOdaSicil_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgwUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
