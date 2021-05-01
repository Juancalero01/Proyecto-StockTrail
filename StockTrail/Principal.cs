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
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmAltaProducto childForm = new FrmAltaProducto();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {

        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVentas childForm = new FrmConsultarVentas();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
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

            if(tb.Rows.Count>0)
            {
                MessageBox.Show("FALTA STOCK");
                FmrAlerta alert = new FmrAlerta();
                alert.ShowDialog();
            }
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vERSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock childForm = new FrmStock();
            childForm.MdiParent = this;
            childForm.Text = "STOCK";
            childForm.Show();
        }

        private void nUEVOPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pRODUCTOSVENCIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVencimiento childForm = new FrmVencimiento();
            childForm.MdiParent = this;
            childForm.Text = "PRODUCTOS VENCIDOS";
            childForm.Show();
        }

        private void rEALIZARVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas childForm = new FrmVentas();
            childForm.MdiParent = this;
            childForm.Text = "REALIZAR VENTAS";
            childForm.Show();
        }

        private void cONSULTARVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVentas childForm = new FrmConsultarVentas();
            childForm.MdiParent = this;
            childForm.Text = "CONSULTAR VENTAS";
            childForm.Show();
        }

        private void cARGARNUEVOPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaProducto childForm = new FrmAltaProducto();
            childForm.MdiParent = this;
            childForm.Text = "NUEVO PRODUCTO";
            childForm.Show();
        }

        private void mODIFICARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar childForm = new FrmModificar();
            childForm.MdiParent = this;
            childForm.Text = "MODIFICAR PRODUCTO";
            childForm.Show();
        }

        private void eLIMINARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminar childForm = new FrmEliminar();
            childForm.MdiParent = this;
            childForm.Text = "ELIMINAR PRODUCTO";
            childForm.Show();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
