using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } 
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        //fazer no main
        public Reserva()
        {
            //inicio a lista
            Hospedes = new List<Pessoa>();
        }

        public void CadastraHospedes(Pessoa hospede)
        {
            Hospedes.Add(hospede);
        }
         public void MostrarCadastro()
          {
            Console.WriteLine("Hóspedes cadastrados:");
            foreach (Pessoa p in Hospedes)
            {
                Console.WriteLine($"{p.Nome}\n");
            }
          } 

    }
}
