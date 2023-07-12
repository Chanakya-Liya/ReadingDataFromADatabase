using EF.Data;
using EF.Models;

using ContosoPizzaPart2Context context = new ContosoPizzaPart2Context();

foreach(Customer c in context.Customers)
{
    Console.WriteLine(c.FirstName);
    Console.WriteLine(c.Cake);
    Console.WriteLine(c.Chocolate);
}
