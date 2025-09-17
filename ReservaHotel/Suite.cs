using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel
{
    public class Suite
    {
        public string Tiposuit { get; set; }
        public int Capacidade { get; set; }
        public double Valordiaria { get; set; }

        public Suite(string tiposuit, int capacidade, double valorDiaria)
        {
            Tiposuit = tiposuit;
            Capacidade = capacidade;    
            Valordiaria = valorDiaria;  
        }

    }
}
