namespace classSpace
{
    class MainClass
    {
        public static void Main(String[]a){
        int small = 0;
        int medium = 0;
        int large = 0;

        const double SMALL_PRICE = 1.75;
        const double MEDIUM_PRICE = 1.90;
        const double LARGE_PRICE = 2.00;

        const int SMALL_OUNCES = 9;
        const int MEDIUM_OUNCES = 12;
        const int LARGE_OUNCES = 15;

        double profit = 0;//Money
        int ounces = 0;//Amount of coffee
        string input = " ";

        int decision = 0;
        int sentinel = 0;

        while(sentinel == 0){
        int sentinel2 = 0;
            while(sentinel2 == 0){
                Console.Clear();
                Console.WriteLine(@"Welcome to the Effa's Coffee Shop!");
                Console.WriteLine();
                Console.WriteLine("Small coffees: " + small + " | Medium coffees: " + medium + " | Large coffees: " + large);
                Console.WriteLine("Ounces of coffee sold: " + ounces);
                Console.WriteLine("Money made: " + profit.ToString("C"));
                Console.WriteLine();
                Console.WriteLine("We have coffee in three different sizes, please choose a number that represents an option: ");
                Console.WriteLine("1) Small  (9oz)  : 1.75$");
                Console.WriteLine("2) Medium (12oz) : 1.90$");
                Console.WriteLine("3) Large  (15oz) : 2.00$");
                Console.WriteLine("4) Check please");
                Console.Write("Selection >> ");
                input = Console.ReadLine();

                if (int.TryParse(input, out decision)){
                    sentinel2 = 1;
                }
                else
                {
                    Console.WriteLine("Wrong choice, try again");
                    Console.Read();
                }
                Console.Clear();
            }

        switch(decision){
            case 1:
                small = getSmallCoffee(small);
                profit = small * SMALL_PRICE;
                ounces = small * SMALL_OUNCES;
                break;
            case 2:
                medium = getMediumCoffee(medium);
                profit = medium * MEDIUM_PRICE;
                ounces = medium * MEDIUM_OUNCES;
                break;
            case 3:
                large = getLargeCoffee(large);
                profit = large * LARGE_PRICE;
                ounces = large * LARGE_OUNCES;
                break;
            case 4:
                check(small, medium, large, profit, ounces);
                sentinel = 1;
                break;
            default:
                Console.WriteLine("This option does not exist, try again. ");
                Console.Read();
                break;
            }
        }
    }

        static int getSmallCoffee(int small){
            int sentinel = 0;
            string input = " ";
            while(sentinel == 0){
                Console.Write("How many small coffees do you want >> " );
                input = Console.ReadLine();

                if (int.TryParse(input, out small)){
                    sentinel = 1;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                    Console.Read();
                    Console.Clear();
                }
            }
            return small;
        }

        static int getMediumCoffee(int medium){
            int sentinel = 0;
            string input = " ";
            while(sentinel == 0){
                Console.Write("How many medium coffees do you want >> " );
                input = Console.ReadLine();

                if(int.TryParse(input, out medium)){
                    sentinel = 1;
                }
                else{
                    Console.WriteLine("Wrong input, try again");
                    Console.Read();
                    Console.Clear();
                }
            }
            return medium;
        }

        static int getLargeCoffee(int large){
            int sentinel = 0;
            string input = " ";
            while(sentinel == 0){
                Console.Write("How many medium coffees do you want >> " );
                input = Console.ReadLine();

                if(int.TryParse(input, out large)){
                    sentinel = 1;
                }
                else{
                    Console.WriteLine("Wrong input, try again");
                    Console.Read();
                    Console.Clear();
                }
            }
            return large;
        }

        static void check(int small, int medium, int large, double profit, int ounces){
            Console.WriteLine("You ordered: ");
            Console.WriteLine(small + " small coffees");
            Console.WriteLine(medium + " medium coffees");
            Console.WriteLine(large + " large coffees"); 
            Console.WriteLine("With a total of " + ounces + "ounces");
            Console.WriteLine("Your total to pay is : " + profit.ToString("C"));
        }

    }

}