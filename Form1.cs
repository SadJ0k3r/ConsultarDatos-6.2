using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ConsultarDatos_6._2
    {
    public partial class Form1 : Form
        {
        private OleDbConnection connection;
        public Form1()
            {
            InitializeComponent();
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ariv2\\Documents\\PROG3355L_M7_BASE_DATOS_PUNTAJES.accdb; Persist Security Info = False");
            CargarTareas();
            CargarRangos();
            ConfigurarEncabezadosListView();
            PresentarNota("SELECT * FROM Actividades");


            lstViewPuntuacion.Click += lstViewPuntuacion_Click;
            }


        private void CargarTareas()
            {
            cmbTarea.Items.Clear();
            // Aquí puedes cargar las tareas desde la base de datos si es necesario
            cmbTarea.Items.Add("Tarea 1");
            cmbTarea.Items.Add("Tarea 2");
            cmbTarea.Items.Add("Tarea 3");
            cmbTarea.Items.Add("Tarea 4");
            cmbTarea.Items.Add("Tarea 5");
            }

        private void CargarRangos()
            {
            cmbRango.Items.Clear();
            // Aquí puedes cargar los rangos desde la base de datos si es necesario
            cmbRango.Items.Add("0 A 10");
            cmbRango.Items.Add("11 A 20");
            cmbRango.Items.Add("21 A 30");
            cmbRango.Items.Add("31 A 40");
            }

        private void ConfigurarEncabezadosListView()
            {
            lstViewPuntuacion.Columns.Clear();
            lstViewPuntuacion.View = View.Details;
            lstViewPuntuacion.HeaderStyle = ColumnHeaderStyle.Clickable;
            lstViewPuntuacion.FullRowSelect = true;
            lstViewPuntuacion.Columns.Add("Fecha", 100);
            lstViewPuntuacion.Columns.Add("Estudiante", 100);
            lstViewPuntuacion.Columns.Add("Actividad", 100);
            lstViewPuntuacion.Columns.Add("Puntaje", 100);
            lstViewPuntuacion.Columns.Add("IdActividad", 100);
            }

        private void PresentarNota(string query)
            {
            if (cmbTarea.SelectedIndex == -1 || cmbRango.SelectedIndex == -1)
                {
                MessageBox.Show("Por favor seleccione una tarea y un rango de calificaciones.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            try
                {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();

                lstViewPuntuacion.Items.Clear();

                while (reader.Read())
                    {
                    string[] data = new string[5];
                    data[0] = reader["FechaActividad"].ToString();
                    data[1] = reader["IdEstudiante"].ToString();
                    data[2] = reader["IdActividad"].ToString();
                    data[3] = reader["Puntaje"].ToString();
                    data[4] = reader["IdActividad"].ToString();

                    lstViewPuntuacion.Items.Add(new ListViewItem(data));
                    }

                reader.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message);
                }
            finally
                {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                }
            }

        private void btnCargar_Click(object sender, EventArgs e)
            {
            string tarea = cmbTarea.Text;
            string puntuacion = cmbRango.Text;
            int low = 0;
            int high = 0;

            switch (puntuacion)
                {
                case "0 A 10":
                    low = 0;
                    high = 10;
                    break;
                case "11 A 20":
                    low = 11;
                    high = 20;
                    break;
                case "21 A 30":
                    low = 21;
                    high = 30;
                    break;
                case "31 A 40":
                    low = 31;
                    high = 40;
                    break;
                }

            string sqlFilter = $"SELECT * FROM Actividades WHERE Descripcion = '{tarea}' AND Puntaje BETWEEN {low} AND {high}";
            PresentarNota(sqlFilter);
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
            {
            cmbTarea.SelectedIndex = -1;
            cmbRango.SelectedIndex = -1;
            lstViewPuntuacion.Items.Clear();

            // Limpia los campos de texto
            LimpiarCampos();
            }

        private void btnActualizar_Click(object sender, EventArgs e)
            {
            if (lstViewPuntuacion.SelectedItems.Count == 0)
                {
                MessageBox.Show("Por favor seleccione un elemento para actualizar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            if (!ValidarCampos())
                return;

            if (!int.TryParse(txtPuntuacion.Text, out int puntaje))
                {
                MessageBox.Show("El puntaje debe ser un número entero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            if (puntaje < 0 || puntaje > 40)
                {
                MessageBox.Show("El puntaje debe estar entre 0 y 40.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            try
                {
                connection.Open();
                string idActividad = lstViewPuntuacion.SelectedItems[0].SubItems[4].Text;
                string sqlUpdate = $"UPDATE Actividades SET IdEstudiante = '{txtEstudiante.Text}', Descripcion = '{txtActividad.Text}', Puntaje = {puntaje} WHERE IdActividad = {idActividad}";
                OleDbCommand command = new OleDbCommand(sqlUpdate, connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    {
                    MessageBox.Show("La actualización se realizó correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PresentarNota("SELECT * FROM Actividades");
                    }
                else
                    {
                    MessageBox.Show("No se pudo realizar la actualización.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message);
                }
            finally
                {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                }
            }


        private void btnSalir_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void lstViewPuntuacion_Click(object sender, EventArgs e)
            {
            if (lstViewPuntuacion.SelectedItems.Count > 0)
                {
                ListViewItem selectedItem = lstViewPuntuacion.SelectedItems[0];
                txtEstudiante.Text = selectedItem.SubItems[1].Text;
                txtActividad.Text = selectedItem.SubItems[2].Text;
                txtIdActividad.Text = selectedItem.SubItems[4].Text; // Se corrige el índice del IdActividad
                txtPuntuacion.Text = selectedItem.SubItems[3].Text; // Se corrige el índice de la Puntuación
                }
            }



        private void LimpiarCampos()
            {
            txtIdActividad.Clear();
            txtEstudiante.Clear();
            txtActividad.Clear();
            txtPuntuacion.Clear();
            }

        private bool ValidarCampos()
            {
            if (string.IsNullOrWhiteSpace(txtIdActividad.Text) || string.IsNullOrWhiteSpace(txtEstudiante.Text) || string.IsNullOrWhiteSpace(txtActividad.Text) || string.IsNullOrWhiteSpace(txtPuntuacion.Text))
                {
                MessageBox.Show("Todos los campos deben estar llenos para realizar la actualización.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }

            if (!int.TryParse(txtPuntuacion.Text, out int puntaje))
                {
                MessageBox.Show("El puntaje debe ser un número entero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }

            if (puntaje < 0 || puntaje > 40)
                {
                MessageBox.Show("El puntaje debe estar entre 0 y 40.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }

            return true;
            }
        }
    }
