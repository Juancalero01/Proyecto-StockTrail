using System;
using System.Collections;
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
    public partial class FrmVencimiento : Form
    {
        public FrmVencimiento()
        {
            InitializeComponent();
        }

        private void FrmVencimiento_Load(object sender, EventArgs e)
        {
            ActualizarGrafica();
        }
        private string SetFecha(DateTime fecha)
        {
            string ano = fecha.Year.ToString();
            string mes = fecha.Month.ToString();
            string dia = fecha.Day.ToString();
            string fechaTexto = ano + "-" + mes + "-" + dia;
            return fechaTexto;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrafica();
        }
        private void ActualizarGrafica()
        {
            DateTime Fecha = DateTime.Now;
            string fechaYMD = SetFecha(Fecha);
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
            string sql = "SELECT * FROM prodfar WHERE Vencimiento <" + "'" + SetFecha(Fecha) + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandText = sql;
            commandDatabase.Connection = databaseConnection;
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = commandDatabase;
            DataSet ds = new DataSet();
            Da.Fill(ds);
            DataTable tb = ds.Tables[0];
            dgvVenc.DataSource = tb;
            ArrayList Nom = new ArrayList();
            ArrayList Stock = new ArrayList();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                Nom.Add(tb.Rows[i]["Nombre"].ToString());
                Stock.Add(tb.Rows[i]["Cantidad"].ToString());
            }
            grafico.Series[0].Points.DataBindXY(Nom, Stock);
        }
    }
}
