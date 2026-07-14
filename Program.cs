namespace Conditionals
{
    class Condits
    {
        static void Main(string[] args)
        {
            //Pole pole = Pole.North;
            //string animal;
            //if (pole == Pole.North)
            //{
            //    animal = "Polar bear";
            //}
            //else
            //{
            //    animal = "Penguin";
            //}
            //Console.WriteLine($"The animal that lives in the {pole} Pole is the {animal}");

            //Pole pole = Pole.South;
            //string animal;
            //animal = (pole == Pole.North) ? "Polar bear" : "Penguin";
            //Console.WriteLine($"The animal that lives in the {pole} Pole is the {animal}");
            Console.WriteLine("Switch Statement");
            var city = CapitalCities.Madrid;
            string countryMessage = "";


            switch (city)
            {
                case CapitalCities.London:
                    countryMessage = $"{city} is capital of UK";
                    Console.WriteLine(countryMessage);
                    break;
                case CapitalCities.Madrid:
                    countryMessage = $"{city} is capital of Spain";
                    Console.WriteLine(countryMessage);
                    break;
                case CapitalCities.Rome:
                    countryMessage = $"{city} is capital of Italy";
                    Console.WriteLine(countryMessage);
                    break;
                case CapitalCities.Paris:
                    countryMessage = $"{city} is capital of France";
                    Console.WriteLine(countryMessage);
                    break;
                default:
                    Console.WriteLine(countryMessage);
                    break;







            }
        }
    }
}

