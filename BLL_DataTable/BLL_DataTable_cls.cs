using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataTable;
using System.Data;

namespace BLL_DataTable
{
    public class BLL_DataTable_cls
    {
        public void CrearTabla(ref DAL_DataTable_cls objtabla)
        {
            //objtabla = new DAL_DataTable_cls();
            DataColumn dcCedula = new DataColumn(@"Cédula Estudiante", typeof(string));
            DataColumn dcNombre = new DataColumn(@"Nombre Estudiante", typeof(string));
            DataColumn dcApellidos = new DataColumn(@"Apellidos Estudiante", typeof(string));
            dcCedula.Unique = true;  /// llave primaria

            objtabla.Lt_Base.Columns.Add(dcCedula);
            objtabla.Lt_Base.Columns.Add(dcNombre);
            objtabla.Lt_Base.Columns.Add(dcApellidos);

            /*DataRow DR = objtabla.Lt_Base.NewRow();


            DR[@"Nombre Estudiante"] = objtabla.Nombre;
            DR[@"Cédula Estudiante"] = objtabla.ID1;
            DR[@"Apellidos Estudiante"] = objtabla.Apellidos1;

            objtabla.Lt_Base.Rows.Add(DR);*/


        }
        public void AgregarRow(ref DAL_DataTable_cls objtabla)
        {
            DataRow dr = objtabla.Lt_Base.NewRow();

            dr[0] = objtabla.ID1;
            dr[1] = objtabla.Nombre;
            dr[2] = objtabla.Apellidos1;

            objtabla.Lt_Base.Rows.Add(dr);            
        }

        public void EditarRow(ref DAL_DataTable_cls objtabla)
        {
            foreach (DataRow dr in objtabla.Lt_Base.Rows)
            {
                if (dr[0].ToString().Trim() == objtabla.ID1)
                {
                    dr[1] = objtabla.Nombre;
                    dr[2] = objtabla.Apellidos1;
                }
            }
        }
    }
}
