using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        Address _aaoAddress1 = new Address(
            "123 Main Street",
            "Rexburg",
            "Idaho",
            "USA"
        );

        Customer _aaoCustomer1 = new Customer(
            "Aba Otchere",
            _aaoAddress1
        );


        Product _aaoProduct1 = new Product(
            "Laptop",
            "P001",
            800.00,
            1
        );

        Product _aaoProduct2 = new Product(
            "Wireless Mouse",
            "P002",
            25.00,
            2
        );

        Product _aaoProduct3 = new Product(
            "Keyboard",
            "P003",
            50.00,
            1
        );

        Order _aaoOrder1 = new Order(_aaoCustomer1);

        _aaoOrder1.AddProduct(_aaoProduct1);
        _aaoOrder1.AddProduct(_aaoProduct2);
        _aaoOrder1.AddProduct(_aaoProduct3);


        Address _aaoAddress2 = new Address(
            "45 Independence Avenue",
            "Accra",
            "Greater Accra",
            "Ghana"
        );

        Customer _aaoCustomer2 = new Customer(
            "Ama Mensah",
            _aaoAddress2
        );


        Product _aaoProduct4 = new Product(
            "Phone",
            "P004",
            500.00,
            1
        );

        Product _aaoProduct5 = new Product(
            "Headphones",
            "P005",
            75.00,
            2
        );

        Order _aaoOrder2 = new Order(_aaoCustomer2);

        _aaoOrder2.AddProduct(_aaoProduct4);
        _aaoOrder2.AddProduct(_aaoProduct5);


        Console.WriteLine("ORDER 1");
        Console.WriteLine("--------------------");

        Console.WriteLine(_aaoOrder1.GetPackingLabel());

        Console.WriteLine();

        Console.WriteLine(_aaoOrder1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine(
            $"Total Cost: ${_aaoOrder1.CalculateTotalCost()}"
        );


        Console.WriteLine("\n====================\n");


        Console.WriteLine("ORDER 2");
        Console.WriteLine("--------------------");

        Console.WriteLine(_aaoOrder2.GetPackingLabel());

        Console.WriteLine();

        Console.WriteLine(_aaoOrder2.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine(
            $"Total Cost: ${_aaoOrder2.CalculateTotalCost()}"
        );
    }
}