using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel
{
    public class Pessoa
    {
        public string Nome { get; set;}
        public string Sobrenome { get; set;}

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            Sobrenome = sobreNome;
        }
    }
}
