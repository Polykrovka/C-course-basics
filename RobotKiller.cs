using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    // Inheritance from the Robot class
    class RobotKiller: Robot {

        public int Health { get; set; }

        public RobotKiller() {
            Robot.count++; //Increment the static variable
        }
        // base constructor is used to call the constructor of the base class
        public RobotKiller(string _name, int weight, byte[] coordinates, int health): base(_name, weight, coordinates) {
            Console.WriteLine("\nObject has been created");
            this.Health = health;
            // base.printValues(); //Call the base class method
            base.color = "Red"; //Access to the protected value of the base class
            this.color = "Blue"; //Access to the protected value of the base class anoter way
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
        }
    }
}
