using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_DataTable;
using BLL_DataTable;

namespace PL_DataTable
{
    public partial class _PLMostrarDatos : Form
    {
        #region Variables Globales

            public DAL_DataTable_cls ObjDAL_Form2;

        #endregion


        public _PLMostrarDatos()
        {
            InitializeComponent();
        }

        private void _PLMostrarDatos_Load(object sender, EventArgs e)
        {
            if (ObjDAL_Form2.cBandAx == 'A')
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
            else
            {
                button2.Text = "Modificar";
                textBox1.Enabled = false;
                textBox1.Text = ObjDAL_Form2.ID1;
                textBox2.Text = ObjDAL_Form2.Nombre;
                textBox3.Text = ObjDAL_Form2.Apellidos1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*public void Datos(ref DAL_DataTable_cls Proceso)
        {
            textBox1.Text = Proceso.ID1;
            textBox2.Text = Proceso.Nombre;
            textBox3.Text = Proceso.Apellidos1;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_DataTable.BLL_DataTable_cls ObjBLL = new BLL_DataTable_cls();

            ObjDAL_Form2.ID1 = textBox1.Text.Trim();
            ObjDAL_Form2.Nombre = textBox2.Text.Trim();
            ObjDAL_Form2.Apellidos1 = textBox3.Text.Trim();

            if (ObjDAL_Form2.cBandAx == 'A')
            {
                ObjBLL.AgregarRow(ref ObjDAL_Form2);
            }
            else
            {
                ObjBLL.EditarRow(ref ObjDAL_Form2);
            }

            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
