using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DAL_DataTable;
using BLL_DataTable;

namespace PL_DataTable
{
    public partial class Form1 : Form
    {
        DAL_DataTable_cls objdal = new DAL_DataTable_cls();
        BLL_DataTable_cls objBll = new BLL_DataTable_cls();


        public Form1()
        {
            InitializeComponent();
        }

        private void btTabla_Click(object sender, EventArgs e)
        {

            

        }

        private void dtg_lista_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_lista.Rows.Count > 0)
            {
                _PLMostrarDatos Ventana = new _PLMostrarDatos();

                objdal.cBandAx = 'E';
                objdal.ID1 = dtg_lista.SelectedRows[0].Cells[0].Value.ToString();
                objdal.Nombre = dtg_lista.SelectedRows[0].Cells[1].Value.ToString();
                objdal.Apellidos1 = dtg_lista.SelectedRows[0].Cells[2].Value.ToString();

                Ventana.ObjDAL_Form2 = objdal;
                Ventana.ShowDialog();

                dtg_lista.DataSource = objdal.Lt_Base;
            }

        }

        private void dtg_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objBll.CrearTabla(ref objdal);
            dtg_lista.DataSource = null;
            dtg_lista.DataSource = objdal.Lt_Base;

            lbl_TipoCambio.Text = ConfigurationManager.AppSettings["TP_DOLAR"].ToString();
            lbl_PI.Text = ConfigurationManager.AppSettings["PI"].ToString();

        }
       

        private void button1_Click(object sender, EventArgs e)
        {            
            _PLMostrarDatos Ventana = new _PLMostrarDatos();

            objdal.cBandAx = 'A';
            Ventana.ObjDAL_Form2 = objdal;
            Ventana.ShowDialog();
                          
            dtg_lista.DataSource = objdal.Lt_Base;
        }
    }
}
