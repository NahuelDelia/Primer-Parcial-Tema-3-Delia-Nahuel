


namespace Primer_Parcial_Tema_3_Delia_Nahuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximo = 5;
                do
                {
                    Console.WriteLine("----- Ingresa Los valores del Prisma rectangular ----- ");
                    Console.Write("Longitud: ");
                    double longitud = double.Parse(Console.ReadLine());
                    Console.Write("Ancho: ");
                    double ancho = double.Parse(Console.ReadLine());
                    Console.Write("Alto: ");
                    double alto = double.Parse(Console.ReadLine());


                        double volumen = calcularVolumen(longitud, ancho, alto);
                        double area = calcularArea(longitud, ancho, alto);
                        double diagonal = calcularDiagonal(longitud, ancho, alto);

                        if (longitud > 0 && ancho > 0 && alto > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("------ RESULTADOS -----");
                            Console.WriteLine($"Volúmen: {volumen}");
                            Console.WriteLine($"Área: {area}");
                            Console.WriteLine($"Diagonal: {diagonal:N2}");
                        }
                        else
                        {
                            Console.WriteLine("Los valores son incorrectos. Intentalo de nuevo.");
                        }
                } while (maximo > 5);

            int[] ArrayPrismas = new int[maximo];
        }

        private static double calcularDiagonal(double longitud, double ancho, double alto)
        {
            return Math.Sqrt(Math.Pow(longitud, 2) + Math.Pow(ancho, 2) + Math.Pow(alto, 2));
        }

        private static double calcularArea(double longitud, double ancho, double alto)
        {
            return 2 * ((longitud * ancho) + (longitud * alto) + (alto * ancho));
        }

        private static double calcularVolumen(double longitud, double ancho, double alto)
        {
            return longitud * alto + ancho;
        }
    }
}
