namespace ReservaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Reserva> list = new List<Reserva>();

            Pessoa p1 = new Pessoa("Lucca", "cerasomma");
            Pessoa p2 = new Pessoa("Isablle", "cerasomma");

            Suite S1 = new Suite("casal",2,30.50);

            Reserva r1 = new Reserva();
            Reserva r2 = new Reserva();


            r1.CadastraHospedes(p1);

            var dias = r1.CadastrarSuite(S1);

            Console.WriteLine("Digite os dias");
            r1.DiasReservados = int.Parse(Console.ReadLine());

            r1.CAlcularDiaria(dias);

            
        }
    }
}
