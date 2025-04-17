using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    // Inheritance from the Robot class
    class Bot:Robot {
        public Bot() {
            Robot.count++; //Increment the static variable
        }
        // base constructor is used to call the constructor of the base class
        public Bot(string _name, int weight, byte[] coordinates) : base(_name, weight, coordinates) {

        }

        public override void printValues() {
            Console.WriteLine("\n" + this.Name + " Weight: " + this.Weight);
            foreach(byte coordinate in this.Coordinates) {
            Console.Write(coordinate + " ");
        }
    }
    }
}
