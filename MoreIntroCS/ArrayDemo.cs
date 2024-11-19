namespace MoreIntroCS
{
    internal class ArrayDemo
    {
        public static void Run()
        {
            var numbers = new int[10];
            var count = 0;

            while (true)
            {
                Console.Write("Skriv tall: ");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                numbers[count] = number;
                for (var i = 0; i < numbers.Length; i++)
                {
                    var value = numbers[i];
                    Console.WriteLine($"På index {i} ligger verdien {value}");
                }

                count++;
            }



            /*
                //int[] numbers = new int[10];
               var numbers = new int[] { 1, 2, 3, 4, 5 };
               
               numbers[2] = 100;             
             */
        }
    }
}
