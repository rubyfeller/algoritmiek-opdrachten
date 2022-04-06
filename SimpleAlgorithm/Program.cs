using SimpleAlgorithm;

Console.WriteLine("Hello, World!");
Order order = new Order();
double maxPriceResult = order.GiveMaximumPrice();
double avgPriceResult = order.GiveAveragePrice();
List<Product> result = order.GetAllProducts();

Console.WriteLine("Products:");
foreach (var item in result)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Price);
}

List<Product> sortedList = order.SortProductsByPrice();
Console.WriteLine("Sorted Products (lowest to highest):");
foreach (var item in sortedList)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Price);
}
Console.WriteLine("The maximum price is: " + maxPriceResult);
Console.WriteLine("The average price is: " + avgPriceResult);