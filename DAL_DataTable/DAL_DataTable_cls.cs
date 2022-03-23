using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_DataTable
{
   public class DAL_DataTable_cls
    {
        private DataTable lt_Base = new DataTable("Tabla");
        private string ID;
        private string nombre;
        private string Apellidos;
        private char _cBandAx;
        public DataTable Lt_Base
        {
            get
            {
                return lt_Base;
            }

            set
            {
                lt_Base = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidos1
        {
            get
            {
                return Apellidos;
            }

            set
            {
                Apellidos = value;
            }
        }

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public char cBandAx
        {
            get
            {
                return _cBandAx;
            }

            set
            {
                _cBandAx = value;
            }
        }
    }
}
