namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfacce");
            var q = new Quadrato(5);
            var r = new Rettangolo(5, 10);

            var qp = q.Perimetro();
            var qa = q.Area();

            var rp = r.Perimetro();
            var ra = r.Area();

            Console.WriteLine(String.Format("pq {0}, aq {1}, pr {2}, ar {3}\n", qp, qa, rp, ra));

            var listaFIgure = new List<IFiguraGeometrica>
            {
                new Quadrato(4),
                new Rettangolo(2, 4),
                new Quadrato (5),
                new Rettangolo(4, 8)
            };

            foreach (var f in listaFIgure)
            {
                //Console.WriteLine(
                //    $"Il perimetro del {f.GetType().Name} è {f.Perimetro()}" + " " +
                //    $"L'Area del {f.GetType().Name} è {f.Area()}\n"
                //    );

                Console.WriteLine(f.StampaInfo() + "\n");
            }
        }
    }
}
