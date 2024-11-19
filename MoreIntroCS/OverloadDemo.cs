namespace MoreIntroCS
{
    internal class OverloadDemo
    {
        public static void Run()
        {
            Greet("Terje");
            Greet();
        }

        static void Greet(string name = "på deg")
        {
            //A();
            //B();
            //C();
            Console.WriteLine($"Hei {name}!");
        }

        /* v2
           static void Greet(string name)
           {
               //A();
               //B();
               //C();
               Console.WriteLine($"Hei {name}!");
           }
           
           static void Greet()
           {
                Greet("på deg");
           }
         */

        /* v1
           static void Greet(string name)
           {
               Console.WriteLine($"Hei, {name}!");
           }
           
           static void Greet()
           {
               Console.WriteLine($"Hei på deg!");
           }         
         */
    }
}
