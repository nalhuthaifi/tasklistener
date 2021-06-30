using System;

namespace noura
{
    class Program
    {

        static void Main(string[] args)
        {

            IVehicle vehicle = null;
            do
            {
                Console.WriteLine("================= Welcome =================");
                Console.WriteLine(" Enter 1 for Cars, 2 for Motorcycle, and 00 to exit system");
           
                    
                var userchoice = Console.ReadLine();
                int VehicleType;
                if (Int32.TryParse(userchoice, out VehicleType))
                {

                    switch (VehicleType)
                    {

                    case (int) choice1.Car:
                            vehicle= Car.factory();
                    break;

                    case (int)choice1.Motocycle:
                            vehicle= Motorcycle.factory();
                            break;

                    case (int)choice1.exit:
                            Console.WriteLine("you chose to exit system ");
                            Console.WriteLine("to confirm your choice enter 0 again" +
                                ", otherwise press any key ");
                    break;
                    }
                    Console.WriteLine(vehicle);

                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    continue;
                }
            } while(Console.ReadKey().KeyChar != '0');

            Console.WriteLine("================= goodbye! ================= ");
        }



        public enum choice1
        {
            Car = 1,
            Motocycle = 2,
            exit = 0
        };

    
    }
}
