namespace MoreIntroCS
{
    internal class RandomDemo
    {
        public static void Run()
        {
            var random = new Random();
            var a = random.Next(100, 200);
            var b = random.Next(100, 200);
            var c = random.Next(100, 200);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
