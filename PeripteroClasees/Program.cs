using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeripteroClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////LISTES ME TA SYNOLIKA ANTIKEIMENA////////////////////////////
            
            List<Employee> AllEmployeesList = new List<Employee>();
            List<Product> AllProductsList = new List<Product>();
            List<Fridge> AllFridgeList = new List<Fridge>();

            ///////////////////////////////////////////////////////////////////////////////

            Kiosk kiosk1 = new Kiosk("Cool Kiosk", "Panepistimiou 39","12/6/2019",123876546);

            Employee e1 = new Employee("Babis","Kourkoulis",34, true);
            Employee e2 = new Employee("Nikos", "Nikolopoulos", 32, false);
            Employee e3 = new Employee("Stathis", "Adamopoulos", 29, true);

            Product p1 = new Product(1, "chocolate", 2);
            Product p2 = new Product(2, "Milko", 3);
            Product p3 = new Product(3, "cocacola", 3);
            Product p4 = new Product(4, "sprite", 1);
            Product p5 = new Product(5, "gkofreta", 1);
            Product p6 = new Product(6, "magazine", 5);
            Product p7 = new Product(7, "cigarettes", 7);
            Product p8 = new Product(8, "tobacco", 7);
            Product p9 = new Product(9, "water", 1);
            Product p10 = new Product(10, "milk", 3);

            IceCream i1 = new IceCream(12, "algida", 5);
            IceCream i2 = new IceCream(13, "boss", 5);
            IceCream i3 = new IceCream(14, "rocket", 6);


        ////// EDW FTIAXNW TA PSYGEIA //////////////////////////////////////////////////////
            Fridge psugeio1 = new Fridge(Mark.Boss);
            Fridge psugeio2 = new Fridge(Mark.LG);
            Fridge psugeio3 = new Fridge(Mark.Pitsos);
          
        //// EDW PROSTHETW TA ANTIKEIMENA POU EFTIAKSA STIS SYNOLIKES LISTES /////////////
            AllEmployeesList.Add(e1);
            AllEmployeesList.Add(e2);
            AllEmployeesList.Add(e3);

            AllProductsList.Add(p1);
            AllProductsList.Add(p2);
            AllProductsList.Add(p3);
            AllProductsList.Add(p4);
            AllProductsList.Add(p5);
            AllProductsList.Add(p6);
            AllProductsList.Add(p7);
            AllProductsList.Add(p8);
            AllProductsList.Add(p9);
            AllProductsList.Add(p10);
                              
            AllProductsList.Add(i1);
            AllProductsList.Add(i2);
            AllProductsList.Add(i3);

            AllFridgeList.Add(psugeio1);
            AllFridgeList.Add(psugeio2);
            AllFridgeList.Add(psugeio3);

            //////////////////////////////////////////////////////////////////////////////////////
            ///// EDW FTIAXNW KAI GEMIZW THN LISTA TOU KATHE PSYGEIOU /////////////////////////////

            List<Product> FridgeOneProducts = new List<Product>();
            List<Product> FridgeTwoProducts = new List<Product>();
            List<Product> FridgeThreeProducts = new List<Product>();

            FridgeOneProducts.Add(p1);
            FridgeOneProducts.Add(p2);
            FridgeOneProducts.Add(p3);
            FridgeOneProducts.Add(p4);

            FridgeTwoProducts.Add(p5);
            FridgeTwoProducts.Add(p6);
            FridgeTwoProducts.Add(p7);
            FridgeTwoProducts.Add(p8);

            FridgeThreeProducts.Add(p9);
            FridgeThreeProducts.Add(p10);
            FridgeThreeProducts.Add(i1);
            FridgeThreeProducts.Add(i2);
            FridgeThreeProducts.Add(i3);

            ///////// EDW SYSXETIZW TA PSYGEIA ME TIS LISTES TOUS, XRHSIMOPOIONTAS THN ENDIAMESH KLASH ////////////////////

            ProductsPerFridge FridgeOne = new ProductsPerFridge(Mark.Boss, FridgeOneProducts);
            ProductsPerFridge FridgeTwo = new ProductsPerFridge(Mark.LG, FridgeTwoProducts);
            ProductsPerFridge FridgeThree = new ProductsPerFridge(Mark.Pitsos, FridgeThreeProducts);





            //Ektypwnei olous tous ypallilous
            Console.WriteLine("******KIOSK EMPLOYEES*****");
            foreach (var item in AllEmployeesList)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                item.Output();
                Console.WriteLine();
                Console.WriteLine("------------");
            }

            Console.WriteLine("------<ALL PRODUCTS>------");
            //    //ektypwnei ola ta proionta
            foreach (var item in AllProductsList)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                item.Output();
                Console.WriteLine();
                Console.WriteLine("------------");
            }

            Console.WriteLine("ALL FRIDGES");
            //    //ektypwnei ola ta psygeia
            foreach (var item in AllFridgeList)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                item.Output();
                Console.WriteLine();
                Console.WriteLine("------------");
            }

            //////////////////////////////////////////////////////////////////////////////////////




            FridgeOne.ShowFridgeProducts();
            FridgeTwo.ShowFridgeProducts();
            FridgeThree.ShowFridgeProducts();




        }
    }

    //Na graftei i class periptero i opoia tha exei: name, address, imerominia enarksis
    // exei ypallilous. Ara tha ftiaxtei class Ipallilos: Name, epitheto, ilikia, kai tha mporei na doulepsei h oxi
    //gia kathe klasi, enas katallilos ctor pou na arxikopoiei ola ta properties
    class Kiosk
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string DateFounded { get; set; }

        public int AFM { get; set; }





        public Kiosk()
        {

        }

        public Kiosk(string name, string address, string date, int afm)
        {
            Name = name;
            Address = address;
            DateFounded = date;
            AFM = afm;
        }


        public void Output()
        {
            OutputName();
            OutputAddress();
            OutputDateFounded();
            OutputAFM();
        }


        public void OutputName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name: {Name}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void OutputAddress()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Address: {Address}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputDateFounded()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Date Founded: {DateFounded}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputAFM()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"AFM: {AFM}");
            Console.ForegroundColor = ConsoleColor.White;
        }

      
    }


    class Employee
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public bool CanWork { get; set; }

     



        public Employee(string firstname, string lastname, int age, bool canwork)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            CanWork = canwork;
        }

        public void Output()
        {
            OutputFirstName();
            OutputLastName();
            OutputAge();
            OutputCanWork();
        }
        public void OutputFirstName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"First Name: {FirstName} .");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputLastName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Last Name: {LastName}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputAge()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Age: {Age}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputCanWork()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Last Name: {LastName}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }



        public Product()
        {

        }
        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }



        public virtual void  Output()
        {
            OutputId();
            OutputName();
            OutputPrice();
        }


        public void OutputId()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Id: {Id}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine($"Name: {Name}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputPrice()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Price: {Price} euro.");
            Console.ForegroundColor = ConsoleColor.White;
        }

      
    }


    class Fridge
    {       
        public Mark Brand { get; set; }

        public Fridge(Mark marka)
        {
            Brand = marka;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Fridge's Brand is: {Brand} ");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }


    public enum Mark { Boss, Pitsos, LG, Morris }

    class IceCream : Product
    {

       

        public IceCream(int id, string name, int timi)
        {
            Id = id;
            Name = name;
            Price = timi;
        }

       

        public override void Output()
        {
            Console.WriteLine("I have discount!");
        }



    }

}
