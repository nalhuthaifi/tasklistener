
using System;


namespace noura
{
    public class Bicycle : Motorcycle{
        public override int Id { set; get; }
        public override int Color { set; get; }
        public override int SerialNumber { set; get; }


        public Bicycle(int ID, int Color, int SerialNumber)
        {
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber= SerialNumber;


        System.Console.WriteLine("Bicycle istructor is called!");

    }
        
        public override void startService()
        {

            Int32 choice = 0;
            string direction;

            Console.WriteLine("what action you want to be performed?");
            Console.WriteLine("1-   move forward");
            Console.WriteLine("2-   Turn (right/left)");
            Console.WriteLine("3-   Stop");
            Console.WriteLine("0-   Exit System");
            choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
              MoveForward();
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter direction");
                direction = Console.ReadLine();
            Turn(direction);
            }
            else if (choice == 3)
            {
               Stop();
            }

        }
        public void toString(){
       System.Console.WriteLine($"Bicycle Id is " );
    }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void MoveForward()
        {
            System.Console.WriteLine("Move Forward!");
        }

        public override void Turn(string Direction) => System.Console.WriteLine($"Turn {Direction}!");

        public override void Stop()
        {
            System.Console.WriteLine("STOP!");
        }
    }
}