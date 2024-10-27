namespace numberClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number-Classification app
            Console.WriteLine("welcome to Number-Classification app  ");
            // take value from user
            Console.WriteLine(" please enter value ");
            //read value
            double value = 0;
            bool converted = double.TryParse(Console.ReadLine(), out value);
            // if 
            if (!converted)
            {
                Console.WriteLine(" please enter Correct value ");

                return;
            }
            if (value < 0)
            {
                Console.WriteLine("the value less than zero ");
            }
            else if (value == 0)
            {
                Console.WriteLine("the value Equal to zero ");
            }

            else if (value > 0)
            {
                Console.WriteLine("the value Greatest than zero ");
            }


        }
    }
}
