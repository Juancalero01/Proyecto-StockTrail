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

namespace StockTrail
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarProducto();
            if (cmbProducto.SelectedIndex==0)
            {
                int codigo = Convert.ToInt32(cmbProducto.SelectedValue);
                cargarProductoId(codigo);
            }
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void CargarProducto()
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string sql = "SELECT * FROM prodfar";
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandText = sql;
            commandDatabase.Connection = databaseConnection;
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = commandDatabase;
            DataSet ds = new DataSet();
            Da.Fill(ds);
            DataTable tb = ds.Tables[0];
            cmbProducto.DataSource = tb;
            cmbProducto.ValueMember = "Producto";
            cmbProducto.DisplayMember = "Nombre";
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex > 0)
            {
                int codigo = Convert.ToInt32(cmbProducto.SelectedValue);
                cargarProductoId(codigo);
                
            }
        }
        private void cargarProductoId(int Codigo)
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string sql = "SELECT * FROM prodfar WHERE Producto = "+Codigo.ToString();
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandText = sql;
            commandDatabase.Connection = databaseConnection;
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = commandDatabase;
            DataSet ds = new DataSet();
            Da.Fill(ds);
            DataTable tb = ds.Tables[0];
            if(tb.Rows.Count>0)
            {
                txtStock.Text = tb.Rows[0]["Cantidad"].ToString();
                txtPrecio.Text = tb.Rows[0]["Importe"].ToString();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtIngresarCant.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR UNA CANTIDAD");
                return;
            }
            int stock = Convert.ToInt32(txtStock.Text);
            int cantidad = Convert.ToInt32(txtIngresarCant.Text);
            if (cantidad > stock)
            {
                MessageBox.Show("NO PUEDE SUPERAR AL STOCK");
                return;
            }
            GuardarVenta();
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            double precio = 0;
            int cantidad = 0;
            double total = 0;
            if (txtIngresarCant.Text !="")
            {
                cantidad =Convert.ToInt32( txtIngresarCant.Text);
            }
            if (txtPrecio.Text != "")
            {
                 precio=Convert.ToDouble(txtPrecio.Text);
            }
            total = cantidad * precio;
            txtTotal.Text = total.ToString();
        }
        private string SetFecha(DateTime fecha)
        {
            string ano = fecha.Year.ToString();
            string mes = fecha.Month.ToString();
            string dia = fecha.Day.ToString();
            string fechaTexto = ano + "-" + mes + "-" + dia;
            return fechaTexto;
        }
        private void GuardarVenta()
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            int CodProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            string Fecha = SetFecha(Convert.ToDateTime(txtFecha.Text));
            int cantidad = Convert.ToInt32(txtIngresarCant.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            double total = Convert.ToDouble(txtTotal.Text);
            string sql = "";
            sql = "INSERT INTO Venta(Fecha,CodProducto,Cantidad,Precio,Total)";
            sql = sql + "VALUES (" + "'" + Fecha + "'";
            sql = sql + "," + CodProducto.ToString();
            sql = sql + "," + cantidad.ToString();
            sql = sql + "," + precio.ToString();
            sql = sql + "," + total.ToString();
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
                txtIngresarCant.Text = "";
                txtTotal.Text = "";
                ActualizarStock(CodProducto,cantidad);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void ActualizarStock(int CodProducto , int Cantidad )
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string sql = "UPDATE prodfar SET Cantidad = Cantidad - " + Cantidad.ToString();
            sql = sql + " WHERE Producto = " + CodProducto.ToString();
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
                MessageBox.Show("VENTA GUARDADA CORRECTAMENTE");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
