using System;


namespace HelloWorld {
    //struct is a type of class, but it is a value type
    //struct need to use when we need to create a small class
    struct Book {
        private string title, author, intro;

        public short pages;

        public void setValues(string title, string author) {
            this.title = title;
            this.author = author;

        }

        public void printValues() {
            Console.WriteLine(this.author + "write a book: " + this.title);
        }
    }
}
