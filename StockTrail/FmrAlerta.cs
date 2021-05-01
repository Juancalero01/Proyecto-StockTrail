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
    public partial class FmrAlerta : Form
    {
        public FmrAlerta()
        {
            InitializeComponent();
        }

        private void FmrAlerta_Load(object sender, EventArgs e)
        {
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string query = "SELECT * FROM prodfar";
            string sql = "SELECT * FROM prodfar WHERE Cantidad < 5";
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandText = sql;
            commandDatabase.Connection = databaseConnection;
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = commandDatabase;
            DataSet ds = new DataSet();
            Da.Fill(ds);
            DataTable tb = ds.Tables[0];
            dgvAlerta.DataSource = tb;
        }
    }
}
