namespace Testest
{
    internal class Program
    {

        public static void Aareena()
        {
            Console.WriteLine("Hey Bro!! everything up to");

            int num;
            string tempt;

            Console.WriteLine("Enter a number.");
            tempt = Console.ReadLine();
            num = Convert.ToInt32(tempt);


            if (num % 2  == 0)
            {
                Console.WriteLine(" Your number is an even number. ");
            }
            else
            {
                Console.WriteLine(" The number you entered is odd. ");
               
            }
            Console.ReadLine();
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
            Aareena();
           
        }
    }
}
