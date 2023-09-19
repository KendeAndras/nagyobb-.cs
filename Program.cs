namespace Nagyobb
{
    internal class Program
    {
        //tipusdefinicio - human

        struct Human
        {
            public string name;
            public int num;
        }

        static void Main(string[] args)
        {
            //bemenet

            Human human1 = new Human();
            Human human2 = new Human();

            //kimenet

            string biggerName;

            //ellenoörzeshez

            bool error;
            string inputText;

            
            Console.WriteLine("ketten gondoltak egy szamra");
            Console.WriteLine("Egyik kocsog: ");
            human1.name = Console.ReadLine();
            do
            {
                
                Console.WriteLine("add meg {0} szamat: ", human1.name);
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out human1.num);
                if (error)
                {
                    Console.WriteLine("teso, egesz szamot adj neki");
                }

            } while (error);

            Console.WriteLine("Masik kocsog: ");
            human2.name = Console.ReadLine();
            do
            {
                
                Console.WriteLine("add meg {0} szamat, ami termeszetesen mas, mint {1}: ", human2.name, human1.num);
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out human2.num) || human1.num == human2.num;
                if (error)
                {
                    Console.WriteLine("teso, egesz szamot adj neki is, de ez ne eggyezzen {0} szamaval", human1);
                }

            } while (error);

            if (human1.num > human2.num) {
                biggerName = human1.name;
            }
            else
            {
                biggerName = human2.name;
            }
            Console.WriteLine("alkie nagyobb: {0}", biggerName);
        }
    }
}