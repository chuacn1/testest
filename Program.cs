namespace Testest
{
    internal class Program
    {

        private static void Aareena()
        {
            Console.WriteLine("Hey Bro!! everything up to");
        }

        public static void Clarissa()
        {
            string tempt;
            int number;


            while (true)
            {
                Console.WriteLine("Guess a number between 1 to 3");
                tempt = Console.ReadLine();
                number = Convert.ToInt32(tempt);

                if (number == 3)
                {
                    Console.WriteLine("Very smart");
                }

                else
                {
                    Console.WriteLine("WROOONNNG");

                    Console.WriteLine("");
                }

            }
        }


        static void Main(string[] args)
        {
            Aareena();
            Clarissa();
           
        }
    }
}
