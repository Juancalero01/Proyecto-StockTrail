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
    public partial class FrmConsultarVentas : Form
    {

        public FrmConsultarVentas()
        {
            InitializeComponent();
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        private void Consultar()
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string sql = "SELECT V.Fecha,P.Nombre,V.Cantidad,V.Precio,V.Total";
            sql = sql + " FROM prodfar P, Venta V";
            sql = sql + " WHERE P.Producto = V.CodProducto";
            sql = sql + " ORDER BY V.IdVenta DESC";
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandText = sql;
            commandDatabase.Connection = databaseConnection;
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = commandDatabase;
            DataSet ds = new DataSet();
            Da.Fill(ds);
            DataTable tb = ds.Tables[0];
            dgvConsultarVent.DataSource = tb;
            dgvConsultarVent.Columns[1].Width = 150;
        }
    }
}
