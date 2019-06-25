using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinder
{
    public class agregardocen
    {


        public string DOCENTE { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }

        public agregardocen() { }

        public agregardocen(string pDOCENTE, string pgrado, string pgrupo)

        {

            this.DOCENTE = pDOCENTE;
            this.grado = pgrado;
            this.grupo = pgrupo;

        }

    }
}
