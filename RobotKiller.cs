using System;

enum Type { Enemy, Hero, Traitor }

namespace HelloWorld {
    // Inheritance from the Robot class
    class RobotKiller: Robot {

        public int Health { get; set; }

        public Type type; 

        public RobotKiller() {
            Robot.count++; //Increment the static variable
        }
        // base constructor is used to call the constructor of the base class
        public RobotKiller(string _name, int weight, byte[] coordinates, int health, Type type) : base(_name, weight, coordinates) {
            Console.WriteLine("\nObject has been created");
            this.Health = health;
            this.type = type;
            // base.printValues(); //Call the base class method
            base.color = "Red"; //Access to the protected value of the base class
            this.color = "Blue"; //Access to the protected value of the base class anoter way
            this.type = type;
        }

        public void Lazer() {
            Console.WriteLine("\nLazer shot");
        }

        // Overriding the base class method

        //public override void printValues() {
        //    base.printValues();
        //    Console.WriteLine("Healts " + this.Health);
        //}

        public override void printValues() {
            Console.WriteLine("\n" + this.Name + " Weight: " + this.Weight);
            Console.WriteLine("Healts " + this.Health);

            if(this.type == Type.Enemy) {
                Console.WriteLine("Type: Enemy");
            } else if(this.type == Type.Hero) {
                Console.WriteLine("Type: Hero");
            } else if(this.type == Type.Traitor) {
                Console.WriteLine("Type: Traitor");
            }
        }
    }
}
