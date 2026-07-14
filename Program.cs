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

            Pole pole = Pole.South;
            string animal;
            animal = (pole == Pole.North) ? "Polar bear" : "Penguin";
            Console.WriteLine($"The animal that lives in the {pole} Pole is the {animal}");
        }
    }
}

