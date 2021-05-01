using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockTrail
{
    public partial class FrmModificar : Form
    {
        static string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
        public FrmModificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }
        private void Actualizar()
        {
            string sql = "UPDATE prodfar SET Nombre ='" + txtNombre.Text + "', Cantidad='" + txtCantidad.Text + "',Importe='" + txtPrecioUnitario.Text + "',Proveedor='" + txtProveedor.Text + "'WHERE Producto =" + txtIdProd.Text+"";
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
                txtIdProd.Text = "";
                txtPrecioUnitario.Text = "";
                txtProveedor.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdProd.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN CODIGO");
                return; 
            }
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string sql = "SELECT * FROM prodfar WHERE Producto ="+txtIdProd.Text;
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandText = sql;
            commandDatabase.Connection = databaseConnection;
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = commandDatabase;
            DataSet ds = new DataSet();
            Da.Fill(ds);
            DataTable tb = ds.Tables[0];
            if (tb.Rows.Count > 0)
            {
                txtIdProd.Text = tb.Rows[0]["Producto"].ToString();
                txtNombre.Text = tb.Rows[0]["Nombre"].ToString();
                txtCantidad.Text = tb.Rows[0]["Cantidad"].ToString();
                txtPrecioUnitario.Text = tb.Rows[0]["Importe"].ToString();
                txtProveedor.Text = tb.Rows[0]["Proveedor"].ToString();
            }
        }
    }
}
