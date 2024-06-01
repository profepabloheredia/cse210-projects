using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("*** ORDERS LIST ***\n");
                
        // print order 1
        Address address1 =new Address ("21 N Street #254", "Big city", "La Florida","USA");
        Customer customer1 =new Customer("Michael Brown",address1);
        Order order1 =new Order(customer1);

        Product productA = new Product(1, "Sugar ", 1.2, 25);
        Product productB = new Product(3, "flour", 1.7, 50);
        Product productC = new Product(4, "Baking powder", 0.9, 35);
        Product productD = new Product(2, "Peanut 1kg", 2.5, 18);
        order1.AddProduct(productA);
        order1.AddProduct(productB);
        order1.AddProduct(productC);
        order1.AddProduct(productD);

        order1.GetShippingLabel(1);
        order1.GetPackingLabel();

        // print order 2
        
        Address address2 =new Address ("calle 10 norte 156", "Renacimiento", "DF","MX");
        Customer customer2 =new Customer("Juan Gonzales",address2);
        Order order2 =new Order(customer2);

        productA = new Product(6, "Coconut 1kg", 5.2, 15);
        productB = new Product(5, "Milk", 1, 47);
        productC = new Product(4, "Baking powder", 0.9, 35);
       
        order2.AddProduct(productA);
        order2.AddProduct(productB);
        order2.AddProduct(productC);
       
        order2.GetShippingLabel(2);// order number 2
        order2.GetPackingLabel();
        
         // print order 3
        
        Address address3 =new Address ("Renacemento #23", "Ingleses", "Florianópolis","BRASIL");
        Customer customer3 =new Customer("Marinha Dos Santos",address3);
        Order order3 =new Order(customer3);

        productA = new Product(6, "Coconut 1kg", 5.2, 15);
        productB = new Product(5, "Milk", 1, 47);
        productC = new Product(4, "Baking powder", 0.9, 35);
        productD = new Product(2, "Peanut 1kg", 2.5, 18);
        Product productE = new Product(12, "Pears 10kg", 2.5, 5);
       
        order3.AddProduct(productA);
        order3.AddProduct(productB);
        order3.AddProduct(productC);
        order3.AddProduct(productD);
        order3.AddProduct(productE);
       
        order3.GetShippingLabel(3);// order number 3
        order3.GetPackingLabel();

        Console.WriteLine("*** END ORDERS LIST ***\n");
    }
}