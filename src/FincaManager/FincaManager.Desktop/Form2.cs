using FincaManager.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FincaManager.Desktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public ConexionDB conn = new ConexionDB();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Extraemos la cadena de conexión del App.config usando el nombre que le dimos

                // 2. Creamos la conexión
                using (SqlConnection connectionString = conn.MtdObtenerConexion())
                {
                    // 3. Intentamos abrirla
                    connectionString.Open();

                    MessageBox.Show("¡Conexión exitosa a la base de datos de FincaManager!",
                                    "Prueba de Conexión",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Si algo falla (contraseña mala, servidor apagado, etc.), te mostrará el error exacto
                MessageBox.Show("Error al conectar: " + ex.Message,
                                "Fallo de Conexión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
