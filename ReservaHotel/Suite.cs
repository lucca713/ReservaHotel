using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel
{
    public class Suite
    {
        private string _tiposuit { get; set; }
        private int _capacidade { get; set; }
        private  double _valordiaria { get; set; }

        public Suite(string Tiposuit, int Capacidade, double ValorDiaria)
        {
            _tiposuit = Tiposuit;
            _capacidade = Capacidade;
            _valordiaria = ValorDiaria;
        }

    }
}
