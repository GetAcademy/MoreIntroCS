namespace MoreIntroCS
{
    internal class ConvertDemo
    {
        public static void Run()
        {
            // konvertering
            string s = "123";
            int i = Convert.ToInt32(s);


            // Convert, casting, parse 
            double d = 5.5;
            int n = (int) d;

            int a = 65;
            char c = (char)a;
            int aa = c;

            var n1 = int.Parse("123");

            var isSuccess = int.TryParse("123 kdsjf d ", out int n2);

            Console.WriteLine(isSuccess);
            Console.WriteLine(n2);
        }
    }
}
