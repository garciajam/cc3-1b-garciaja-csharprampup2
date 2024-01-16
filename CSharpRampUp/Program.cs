namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Weight in Pounds (lbs): ");
            double weightlbs = Convert.ToDouble(Console.ReadLine());
            double weightkg = weightlbs / 2.205;
            Console.WriteLine("Weight in Kilograms (kgs): " + weightkg);

            Console.WriteLine("=============================================");
            Console.Write("Length in Miles (mi): ");
            double lengthmi = Convert.ToDouble(Console.ReadLine());
            double lengthkm = weightlbs * 1.609;
            Console.WriteLine("Length in Kilometers (km): " + lengthkm);

            Console.WriteLine("=============================================");
            Console.Write("Temperature in Fahrenheit (F): ");
            double tempF = Convert.ToDouble(Console.ReadLine());
            double tempC = (tempF - 32) * 0.56;
            Console.WriteLine("Temperature in Celsius (C): " + tempC);

            Console.WriteLine("=============================================");
            Console.Write("Age of Student 1: ");
            int student1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 2: ");
            int student2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 3: ");
            int student3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 4: ");
            int student4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 5: ");
            int student5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 6: ");
            int student6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 7: ");
            int student7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 8: ");
            int student8 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 9: ");
            int student9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Age of Student 10: ");
            int student10 = Convert.ToInt32(Console.ReadLine());

            int studentAges = (student1 + student2 + student3 + student4 + student5 + student6 + student7 + student8 + student9 + student10) / 10;
            Console.WriteLine("The average age of the students is: " + studentAges);

            //Characters
            string character1 = "Thom";
            string character2 = "Philip";
            string character3 = "Colin";
            string character4 = "Ranni";
            string character5 = "Godrick";

            //Items
            string item1 = "Greatsword";
            string item2 = "Icerind Hatchet";
            string item3 = "Bubbletear";
            string item4 = "Rune";
            string item5 = "Axe of Godrick";

            //Abilities
            string ability1 = "Stamp";
            string ability2 = "Frostbite";
            string ability3 = "Crimsonwhorl";
            string ability4 = "Healinator";
            string ability5 = "Kneeler";

            Console.WriteLine("=============================================");
            Console.WriteLine("In a land far away, there were 3 brave heroes: \n" + character1 + ", who wielded the " + item1 + " that grants the ability, "
            + ability1 + ", which increases strength and agility;\n" + character2 + ", who was equipped with the " + item2 + ", with the ability " + ability2
            + " that can freeze enemies and\n" + character3 + ", who used the " + item3 + ", having the ability of " + ability3 + " that can heal wounds. \n" +
            "They embarked on a quest to restore the Broken " + item4 + " to restore peace in the kingdom.\n" +
            "They faced great monsters and beings in their path using their abilities and collected every piece of the " + item4
            + ".\nThey also saved a witch named " + character4 + ", who in return, used " + ability4 + " that boosted the heroes' strength and morale.\n" +
            "Once they gathered every piece of the " + item4 + ", they suddenly get transported to another realm to fight the beast named " + character5 +
            ".\nIt wielded the " + item5 + " with the ability " + ability5 + " that can instill fear and manipulate others." +
            "\nThe beast was very powerful, but the heroes might and resolve enabled them to defeat the beast and were able to restore the " + item4 +
            ".\nThey were returned to their kingdom where peace reigns, and lived happily ever after. The End.");


            Console.WriteLine("=============================================");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("=============================================");
            Console.Write("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 < 1)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                int result = 0;
                for (int i = 1; i <= number2; i++)
                {
                    result += i;
                }
                Console.WriteLine("Output: " + result);
            }

            Console.WriteLine("=============================================");
            Console.Write("Enter a number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 < 1)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                for (int k = number3; k >= 1; k--)
                {
                    for (int l = 1; l <= k; l++)
                    {
                        Console.Write(l + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
