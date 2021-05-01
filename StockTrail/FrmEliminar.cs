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
    public partial class FrmEliminar : Form
    {
        static string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {

        }
        private void EliminarDato()
        {
            string sql = "DELETE FROM prodfar WHERE Producto =" + txtEliminar.Text;
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
                MessageBox.Show("DATO BORRADO CORRECTAMENTE");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDato();
        }
    }
}
