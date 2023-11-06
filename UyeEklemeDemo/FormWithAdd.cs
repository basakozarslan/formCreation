using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace UyeEklemeDemo
{
    public partial class FormWithAdd : Form
    {
        public FormWithAdd()
        {
            InitializeComponent();
            monthCalendar1.DateSelected += monthCalendar1_DateChanged;
            monthCalendar2.DateSelected += monthCalendar1_DateChanged;

            // Define your list of strings
            string[] tescilturu = { "Red", "Onayli", "Beklemede" };
            string[] kapanıssebebi = { "Devir", "Uygunsuz" };
            string[] altsirket = { "Limited", "Anonim", "Şahıs" };
            // Add each string to the ComboBox

            foreach (string item in tescilturu)
            {
                cbxTescilTuru.Items.Add(item);
            }
            foreach (string item in kapanıssebebi)
            {
                cbxKapanısSebebi.Items.Add(item);
            }
            foreach (string item in altsirket)
            {
                cbxAltSirket.Items.Add(item);
            }


        }
        SqlConnection _connection = new SqlConnection("server=(localdb)\\mssqllocaldb;initial catalog=UyeEkleme;integrated security=true");

        public List<UyeEkleme> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT U.*, M.IL, F.FIRMATURU FROM UYEEKLEME U, MERKEZSUBE M, FIRMATURU F " +
                "WHERE U.FIRMATURUID = F.ID AND U.MERKEZSUBEPLAKA = M.PLAKA", _connection);

            //komutu calıstırma
            SqlDataReader reader = command.ExecuteReader();

            List<UyeEkleme> uyeler = new List<UyeEkleme>();

            while (reader.Read())
            {
                UyeEkleme uyeEkleme = new UyeEkleme
                {
                    OdaSicilNo = Convert.ToInt32(reader["OdaSicilNo"]),
                    Ilce = Convert.ToInt32(reader["Ilce"]),
                    TescilTarihi = Convert.ToDateTime(reader["TescilTarihi"]),
                    Yetkili = reader["Yetkili"].ToString(),
                    merkezSubePlaka = reader["il"].ToString(),
                    firmaTuruId = reader["firmaTuru"].ToString(),
                    KlasorNo = Convert.ToInt32(reader["KlasorNo"]),
                    TescilTuru = reader["TescilTuru"].ToString(),
                    KapanısTarihi = Convert.ToDateTime(reader["KapanısTarihi"]),
                    KapanısSebebi = reader["KapanısSebebi"].ToString(),
                    AltSırketTipi = reader["AltSırketTipi"].ToString(),
                    FaaliyetSuresi = Convert.ToInt32(reader["FaaliyetSuresi"])
                };

                uyeler.Add(uyeEkleme);
            }

            reader.Close();

            command = new SqlCommand("SELECT CONCAT(plaka, CONCAT('-',il)) as il from merkezsube", _connection);
            SqlDataReader reader2 = command.ExecuteReader();

            while (reader2.Read())
            {
                cbxMerkezSube.Items.Add(reader2["il"]);
            }

            reader2.Close();
            // clear the items collection of the combobox before adding data
            cbxFırmaTuru.Items.Clear();

            command = new SqlCommand("SELECT CONCAT(Id, CONCAT('-',firmaTuru)) as firmaTuru from firmaTuru", _connection);
            SqlDataReader reader3 = command.ExecuteReader();

            while (reader3.Read())
            {
                cbxFırmaTuru.Items.Add(reader3["firmaTuru"].ToString());
            }

            reader3.Close();
            _connection.Close();
            return uyeler;
        }




        private List<string> GetDataFromDatabase(string sqlQuery)
        {
            List<string> data = new List<string>();

            ConnectionControl();

            SqlCommand command = new SqlCommand(sqlQuery, _connection);
            SqlDataReader reader3 = command.ExecuteReader();

            while (reader3.Read())
            {
                data.Add(reader3[0].ToString());
            }

            reader3.Close();
            _connection.Close();

            return data;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(UyeEkleme uyeEkleme)
        {
            ConnectionControl();
            //SqlCommand command = new SqlCommand("", _connection);
            //command.CommandText = "SET IDENTITY_INSERT UyeEkleme ON";
            //command.ExecuteNonQuery();

            SqlCommand command = new SqlCommand("INSERT INTO UyeEkleme values (@OdaSicilNo, @Ilce, @TescilTarihi, @Yetkili, @merkezsubeplaka, @firmaTuruId, @KlasorNo, @TescilTuru, @KapanısTarihi, @KapanısSebebi, @AltSırketTipi, @FaaliyetSuresi)", _connection);

            command.Parameters.AddWithValue("@OdaSicilNo", uyeEkleme.OdaSicilNo);
            command.Parameters.AddWithValue("@Ilce", uyeEkleme.Ilce);
            command.Parameters.AddWithValue("@TescilTarihi", uyeEkleme.TescilTarihi);
            command.Parameters.AddWithValue("@Yetkili", uyeEkleme.Yetkili);
            command.Parameters.AddWithValue("@merkezsubeplaka", ExtractInteger(cbxMerkezSube.SelectedItem.ToString()));
            command.Parameters.AddWithValue("@firmaTuruId", ExtractInteger(cbxFırmaTuru.SelectedItem.ToString()));
            command.Parameters.AddWithValue("@KlasorNo", uyeEkleme.KlasorNo);
            command.Parameters.AddWithValue("@TescilTuru", uyeEkleme.TescilTuru);
            command.Parameters.AddWithValue("@KapanısTarihi", uyeEkleme.KapanısTarihi);
            command.Parameters.AddWithValue("@KapanısSebebi", uyeEkleme.KapanısSebebi);
            command.Parameters.AddWithValue("@AltSırketTipi", uyeEkleme.AltSırketTipi);
            command.Parameters.AddWithValue("@FaaliyetSuresi", uyeEkleme.FaaliyetSuresi);

            command.ExecuteNonQuery();

            // command.CommandText = "SET IDENTITY_INSERT UyeEkleme OFF";
            //command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(UyeEkleme uyeEkleme)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("", _connection);

            // Disable identity insert during update
            command.CommandText = "SET IDENTITY_INSERT UyeEkleme ON";
            command.ExecuteNonQuery();

            // Update the record based on the OdaSicilNo value
            command = new SqlCommand("UPDATE UyeEkleme SET Ilce=@Ilce, TescilTarihi=@TescilTarihi, Yetkili=@Yetkili, merkezsubeplaka=@MerkezSube, firmaTuruId=@firmaTuruId, KlasorNo=@KlasorNo, TescilTuru=@TescilTuru, KapanısTarihi=@KapanısTarihi, KapanısSebebi=@KapanısSebebi, AltSırketTipi=@AltSırketTipi, FaaliyetSuresi=@FaaliyetSuresi WHERE OdaSicilNo=@OdaSicilNo", _connection);
            command.Parameters.AddWithValue("@OdaSicilNo", uyeEkleme.OdaSicilNo);
            command.Parameters.AddWithValue("@Ilce", uyeEkleme.Ilce);
            command.Parameters.AddWithValue("@TescilTarihi", uyeEkleme.TescilTarihi);
            command.Parameters.AddWithValue("@Yetkili", uyeEkleme.Yetkili);
            command.Parameters.AddWithValue("@merkezsubeplaka", ExtractInteger(cbxMerkezSube.SelectedItem.ToString()));
            command.Parameters.AddWithValue("@firmaTuruId", ExtractInteger(cbxFırmaTuru.SelectedItem.ToString()));
            command.Parameters.AddWithValue("@KlasorNo", uyeEkleme.KlasorNo);
            command.Parameters.AddWithValue("@TescilTuru", uyeEkleme.TescilTuru);
            command.Parameters.AddWithValue("@KapanısTarihi", uyeEkleme.KapanısTarihi);
            command.Parameters.AddWithValue("@KapanısSebebi", uyeEkleme.KapanısSebebi);
            command.Parameters.AddWithValue("@AltSırketTipi", uyeEkleme.AltSırketTipi);
            command.Parameters.AddWithValue("@FaaliyetSuresi", uyeEkleme.FaaliyetSuresi);
            command.ExecuteNonQuery();

            // Re-enable identity insert
            command.CommandText = "SET IDENTITY_INSERT UyeEkleme OFF";
            command.ExecuteNonQuery();

            _connection.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwShow.DataSource = GetAll();
            List<UyeEkleme> uyeler = GetAll();

        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdaSicil.Text))
            {
                MessageBox.Show("Oda Sicil No alanı boş bırakılamaz");
                return;
            }

            if (cbxMerkezSube.SelectedItem == null || cbxFırmaTuru.SelectedItem == null || cbxTescilTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var _connection = new SqlConnection("server=(localdb)\\mssqllocaldb;initial catalog = UyeEkleme; integrated security = true"))
            {
                _connection.Open(); // Open the connection

                using (var command = new SqlCommand("INSERT INTO UyeEkleme(Ilce, TescilTarihi, Yetkili, KlasorNo, TescilTuru, KapanısTarihi, KapanısSebebi, AltSırketTipi, FaaliyetSuresi, merkezsubeplaka, firmaTuruid) " +
                    "VALUES(@Ilce, @TescilTarihi, @Yetkili, @KlasorNo, @TescilTuru, @KapanısTarihi, @KapanısSebebi, @AltSırketTipi, @FaaliyetSuresi, @merkezsubeplaka, @firmaTuruid)", _connection))
                {
                    // set parameter values for the command
                    command.Parameters.AddWithValue("@Ilce", txtIlce.Text);
                    command.Parameters.AddWithValue("@TescilTarihi", DateTime.ParseExact(tbxTescilTarihi.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                    command.Parameters.AddWithValue("@Yetkili", txtYetkili.Text);
                    command.Parameters.AddWithValue("@merkezsubeplaka", ExtractInteger(cbxMerkezSube.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@firmaTuruid", ExtractInteger(cbxFırmaTuru.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@KlasorNo", txtKlasorNo.Text);
                    command.Parameters.AddWithValue("@TescilTuru", cbxTescilTuru.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@KapanısSebebi", cbxKapanısSebebi.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@AltSırketTipi", cbxAltSirket.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@FaaliyetSuresi", txtFaaliyetSuresi.Text);
                    command.Parameters.AddWithValue("@KapanısTarihi", DateTime.ParseExact(tbxKapanısTarihi.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture));

                    // execute the command and get the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();
                    // show a message box with the result
                    MessageBox.Show($"Rows affected: {rowsAffected}");
                    dgwShow.DataSource = GetAll();
                }
            }
        }








        private void txtOdaSicil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            // Clear the Text property of all TextBox controls
            txtOdaSicil.Text = "";
            txtIlce.Text = "";
            txtYetkili.Text = "";
            txtKlasorNo.Text = "";
            txtFaaliyetSuresi.Text = "";
            tbxTescilTarihi.Text = "";
            tbxKapanısTarihi.Text = "";

            // Set the SelectedIndex property of all ComboBox controls to -1

            cbxMerkezSube.SelectedIndex = -1;
            cbxFırmaTuru.SelectedIndex = -1;
            cbxTescilTuru.SelectedIndex = -1;
            cbxKapanısSebebi.SelectedIndex = -1;
            cbxAltSirket.SelectedIndex = -1;

            //dgwShow.DataSource = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Check if OdaSicilNo is provided
            if (string.IsNullOrEmpty(txtOdaSicil.Text))
            {
                MessageBox.Show("Silmek istediğiniz verinin OdaSicilNo bilgisini giriniz!");
                return;
            }

            // Ask for user confirmation before deleting the data
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz OdaSicilNo: " + txtOdaSicil.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // Construct the SQL query to delete the data based on OdaSicilNo
                string query = "DELETE FROM UyeEkleme WHERE OdaSicilNo = @OdaSicilNo";
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@OdaSicilNo", Convert.ToInt32(txtOdaSicil.Text));

                // Open the connection and execute the query
                _connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                // Check if any rows are affected by the query
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data for OdaSicilNo " + txtOdaSicil.Text + " has been deleted.");
                    dgwShow.DataSource = GetAll();
                }
                else
                {
                    MessageBox.Show("Bulunamadı! " + txtOdaSicil.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriyi silerken bir sorun oluştu! " + ex.Message);
            }
            finally
            {
                // Close the connection
                _connection.Close();
            }
        }

        private void cbxTescilTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            if (selectedDate > DateTime.Today)
            {
                // Selected date is in the future, so set it to today's date
                selectedDate = DateTime.Today;
                monthCalendar1.SetSelectionRange(selectedDate, selectedDate);
            }
            tbxTescilTarihi.Text = selectedDate.ToString("dd/MM/yyyy");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Show();
            }
            else
            {
                groupBox2.Hide();
            }
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar2.SelectionRange.Start;
            if (selectedDate > DateTime.Today)
            {
                // Selected date is in the future, so set it to today's date
                selectedDate = DateTime.Today;
                monthCalendar2.SetSelectionRange(selectedDate, selectedDate);
            }
            tbxKapanısTarihi.Text = selectedDate.ToString("dd/MM/yyyy");
        }
        public static int ExtractInteger(string inputString)
        {
            string[] parts = inputString.Split('-');
            int integerPart;
            if (int.TryParse(parts[0], out integerPart))
            {
                return integerPart;
            }
            else
            {
                throw new ArgumentException("Input string does not contain a valid integer.");
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdaSicil.Text))
            {
                MessageBox.Show("Oda Sicil No alanı boş bırakılamaz");
                return;
            }

            if (cbxMerkezSube.SelectedItem == null || cbxFırmaTuru.SelectedItem == null || cbxTescilTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "server=(localdb)\\mssqllocaldb;initial catalog=UyeEkleme;integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE UyeEkleme SET Ilce=@Ilce, TescilTarihi=@TescilTarihi, Yetkili=@Yetkili, merkezsubeplaka=@merkezsubeplaka, firmaTuruid=@firmaTuruid, KlasorNo=@KlasorNo, TescilTuru=@TescilTuru, KapanısTarihi=@KapanısTarihi, KapanısSebebi=@KapanısSebebi, AltSırketTipi=@AltSırketTipi, FaaliyetSuresi=@FaaliyetSuresi WHERE OdaSicilNo=@OdaSicilNo";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@OdaSicilNo", txtOdaSicil.Text);
                    command.Parameters.AddWithValue("@Ilce", txtIlce.Text);
                    command.Parameters.AddWithValue("@TescilTarihi", DateTime.ParseExact(tbxTescilTarihi.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                    command.Parameters.AddWithValue("@Yetkili", txtYetkili.Text);
                    command.Parameters.AddWithValue("@merkezsubeplaka", ExtractInteger(cbxMerkezSube.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@firmaTuruid", ExtractInteger(cbxFırmaTuru.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@KlasorNo", txtKlasorNo.Text);
                    command.Parameters.AddWithValue("@TescilTuru", cbxTescilTuru.SelectedItem.ToString());

                    // Check if KapanısTarihi is not empty before parsing it
                    if (!string.IsNullOrEmpty(tbxKapanısTarihi.Text))
                    {
                        command.Parameters.AddWithValue("@KapanısTarihi", DateTime.ParseExact(tbxKapanısTarihi.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@KapanısTarihi", DBNull.Value);
                    }

                    command.Parameters.AddWithValue("@KapanısSebebi", cbxKapanısSebebi.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@AltSırketTipi", cbxAltSirket.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@FaaliyetSuresi", txtFaaliyetSuresi.Text);

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dgwShow.DataSource = GetAll();
                        MessageBox.Show("Record updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or not updated.");
                    }
                }
            }
        }

        private void cbxMerkezSube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxFırmaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
