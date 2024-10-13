using System;
using task_12;

class Task
{
    static void Main()
    {
        List<Order> orders = new List<Order>();
        Console.Write("Enter amount of orders = ");
        int size = int.Parse(Console.ReadLine());

        for(int i = 0; i < size; i++)
        {
            string input = Console.ReadLine().Trim('|');
            string[] parts = input.Split(" - ");
            string company = parts[0];
            int amount = int.Parse(parts[1]);
            string product = parts[2];
            orders.Add(new Order(company, amount, product));
            Line();
        }

        var result = from order in orders
                     group order by order.CompanyName into companyGroup
                     orderby companyGroup.Key
                     select new
                     {
                         Company = companyGroup.Key,
                         Products = from productGroup in companyGroup
                                    group productGroup by productGroup.Product into productGroup
                                    select new
                                    {
                                        ProductName = productGroup.Key,
                                        TotalAmount = productGroup.Sum(p => p.ProductsAmount)
                                    }
                     };

        foreach (var company in result)
        {
            Console.Write($"{company.Company}: ");
            Console.WriteLine(string.Join(", ", company.Products.Select(p => $"{p.ProductName}-{p.TotalAmount}")));
            Line();
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}