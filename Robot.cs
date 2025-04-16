using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class Robot {

        //public avaliable for all, inside and outside the class
        //protected avaliable for the class and its derived classes
        //private avaliable only for the class

        private string name;

        private int weight;

        private byte[] coordinates;

        public void setValues(string _name, int weight, byte[] coordinates) {
            name = _name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void printValues() {
            Console.WriteLine("\n" + name + " Weight: " + weight);
            foreach(byte coordinate in coordinates) {
                Console.Write(coordinate + " ");
            }

        }
    }
}
