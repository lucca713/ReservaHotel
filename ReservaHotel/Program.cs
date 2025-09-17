namespace ReservaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Lucca", "cerasomma");
            Pessoa p2 = new Pessoa("Isablle", "cerasomma");
            Reserva r1 = new Reserva();

            r1.CadastraHospedes(p1);

            r1.CadastraHospedes(p2);

            r1.MostrarCadastro();
        }
    }
}
