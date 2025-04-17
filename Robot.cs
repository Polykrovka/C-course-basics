using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    //abstract class is can not create an object of the class. Can not be instantiated(create instanse)
    abstract class Robot {

        //public avaliable for all, inside and outside the class
        //protected avaliable for the class and its derived classes
        //private avaliable only for the class

        protected static int count = 0; //Static variable can be used even if we dot not create an object of the class

        protected string color;

        private string name;

        private int weight;

        private byte[] coordinates;

        public string Name {
            get { return this.name; }
        }


        //accessor methods names usually start with uppercase letter the same as the variable name
        public int Weight {
            get { Console.Write("Weight: "); return this.weight; }
            set {
                if(value < 1) {
                    this.weight = 1;
                } else {
                    this.weight = value;
                }
            }
        }

        public byte[] Coordinates {
            get { return this.coordinates; }
            private set {}
        }

        public int Width { private get; set; }

        //Constructor do bot return data, no ned to use void\
        //Name of the constructor is the same as the class name
        //
        public Robot(string _name, int weight, byte[] coordinates) {
            Console.WriteLine("\nObject has been created");
            this.setValues(_name, weight, coordinates);
            count++; //Increment the static variable
        }

        //Constructor without parameters, will be used when the object is created without parameters
        public Robot() {
            Console.WriteLine("\nObject without parametrs has been created");
            //can not this.count because it is static
            count++; //Increment the static variable
        }

        public void setValues(string _name, int weight, byte[] coordinates) {
            name = _name;
            this.weight = weight;  //better to use this. to avoid confusion with the parameter name
            this.coordinates = coordinates;
        }

        //virtual method can be overridden in the derived class
        //public virtual void printValues() {
        //    Console.WriteLine("\n" + this.name + " Weight: " + this.weight);
        //    foreach(byte coordinate in coordinates) {
        //        Console.Write(coordinate + " ");
        //    }
        //}

        //Abstract method can not have a body, must be implemented in the derived class
        public abstract void printValues(); 

        public static void Print() {
            Console.WriteLine("\nRobot static var count of objects: {0}", count);
        }
    }
}
