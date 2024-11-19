namespace MoreIntroCS
{
    internal class EnumDemo
    {
        public static void Run()
        {
            int a = 3;

            var b = TrafficLight.Green;

            if (b == TrafficLight.Red)
            {
                //Console.WriteLine("Rødt");
            }

            var c1 = (TrafficLight)1;
            Console.WriteLine(c1);
            var s = "RedAndYellow";
            var isSuccess = Enum.TryParse(s, out TrafficLight d2);

            b++;
        }
    }
}
