using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MobileTest
{
    public class Cliente
    { 
        
        private int _consecutivocompania;
        [PrimaryKey]
        public int ConsecutivoCompania {
            get => _consecutivocompania;
            set => _consecutivocompania = value;
        }
        private string _codigo;
        [PrimaryKey]
        public string Codigo {
            get => _codigo;
            set => _codigo = value; 
        }
        private string _nombre;

        public string Nombre {
            get => _nombre; set => _nombre = value;
        }
        private string  _numerorif;
        [Unique]
        public string  NumeroRIF {
            get => _numerorif; set => _numerorif = value.Substring(0, 12);
        }
        private string _direccion;
        public string Direccion {
            get => _direccion; set => _direccion = value;
        }
    }
}
