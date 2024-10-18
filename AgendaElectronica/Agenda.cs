using System;
using System.Data;
using System.Data.SqlClient;


namespace AgendaElectronica
{


    public partial class Agenda : Form
    {
        string connectionString = "Data Source=DESKTOP-9S18PK7;Initial Catalog=Agenda;Integrated Security=True";
        public void openConnection()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void closeConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Close();
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void showUsers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            openConnection();
            string query = "SELECT * FROM users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            closeConnection();
        }

        public void clearFields()
        {
            txtname.Text = "";
            txtlastname.Text = "";
            mskbirthdate.Text = "";
            txtaddress.Text = "";
            cmbgender.Text = "";
            cmbstatus.Text = "";
            mskphone.Text = "";
            txtmail.Text = "";
        }

        public Agenda()
        {
            InitializeComponent();
            showUsers();



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }
        private void InsertarContacto()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO users (name,lastname,birthdate,gender,address,status,phone,mail) " +
                               "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @CorreoElectronico)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtname.Text);
                    command.Parameters.AddWithValue("@Apellido", txtlastname.Text);
                    command.Parameters.AddWithValue("@FechaNacimiento", mskbirthdate.Text);
                    command.Parameters.AddWithValue("@Direccion", txtaddress.Text);
                    command.Parameters.AddWithValue("@Genero", cmbgender.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@EstadoCivil", cmbstatus.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@Movil", mskphone.Text);
                    command.Parameters.AddWithValue("@CorreoElectronico", txtmail.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    showMessage("Contacto insertado correctamente.");
                    showUsers();
                    clearFields();
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            { 
            if(txtname.Text.Length>0 && txtlastname.Text.Length>0&& mskbirthdate.Text.Length==10&& txtaddress.Text.Length>0&& cmbgender.Text.Length>0 && cmbstatus.Text.Length>0 && mskphone.Text.Length == 14 && txtmail.Text.Length > 0)
                {

                    InsertarContacto();
                }
            
            else
                {
                    showMessage("Todos los campos deben de estar completos");
                }
        }
            catch
            {
                showMessage("Error al insertar un usuario");
            }
        }
    }
}
