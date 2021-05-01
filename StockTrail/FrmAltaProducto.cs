using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockTrail
{
    public partial class FrmAltaProducto : Form
    {
        static string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
        public FrmAltaProducto()
        {
            InitializeComponent();
        }
        private void Guardar()
        {
            string nombre = "'" + txtNombre.Text + "'";            
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            DateTime Fecha = Convert.ToDateTime(txtFecha.Text);
            DateTime Vencimiento = Convert.ToDateTime(txtVenc.Text);
            string proveedor = "'" + txtProveedor.Text + "'";            
            string fechaYMD = SetFecha(Fecha);            
            string sql = "INSERT INTO prodfar (Nombre,Cantidad,Importe,Fecha,Proveedor,Vencimiento)";
            sql = sql + "VALUES (" + nombre;
            sql = sql + "," + cantidad.ToString();
            sql = sql + "," + "'" + txtPrecioU.Text + "'";
            sql = sql + "," + "'" + fechaYMD + "'";
            sql = sql + "," + proveedor;
            sql = sql + "," + "'" + SetFecha(Vencimiento)+ "'";
            sql = sql + ")";

            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                commandDatabase.CommandText = sql;
                commandDatabase.Connection = databaseConnection;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("DATO ACTUALIZADO CORRECTAMENTE");
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtProveedor.Text = "";
                txtPrecioU.Text = "";
                txtVenc.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private string SetFecha(DateTime fecha)
        {
            string ano = fecha.Year.ToString();
            string mes = fecha.Month.ToString();
            string dia = fecha.Day.ToString();
            string fechaTexto = ano + "-" + mes + "-" + dia;
            return fechaTexto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA CONTINUAR");
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UNA CANTIDAD PARA CONTINUAR");
                return;
            }
            Guardar();
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            txtFecha.Text = fecha.ToShortDateString();
        }

        private void txtVenc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
