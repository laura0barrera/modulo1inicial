namespace modulo1inicial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("hola");
            Console.WriteLine("holaaaa");
            int edad = 18;
            Console.WriteLine(edad);
            string mensaje = "dx";
            bool bandera = false;
            var numero = 0;
            int num1;
            Console.WriteLine("escriba su nombre");
            string nom = Console.ReadLine();
            Console.WriteLine("el nombre del susurio es " + nom);
            Console.ReadKey();

            Console.WriteLine("LAURA GIL");

            Console.WriteLine("INT");
            int numerosupergrande = int.MaxValue;
            Console.WriteLine(numerosupergrande);

            //Tipos flotantes 
            float altura = 180.123456789f; //ocupa 4 bytes 
            double anchura = 45.123456789; // ocupa 8 bytes y es mas usado 
            decimal moto = 9.99m; // usa mas bytes y es mas preciso y se una en 

            Console.WriteLine("float");
            float Numerosupergrande = float.MaxValue;
            Console.WriteLine(Numerosupergrande);

            Console.WriteLine("double");
            double NumeroSupergrande = double.MaxValue;
            Console.WriteLine(NumeroSupergrande);

            Console.WriteLine("decimal");
            decimal NumeroSuperGrande = decimal.MaxValue;
            Console.WriteLine(NumeroSuperGrande);
        }
    }
}