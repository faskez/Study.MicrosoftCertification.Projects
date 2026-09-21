////using System.Globalization;
////using System.Windows.Markup;
////CultureInfo.CurrentCulture = new CultureInfo("en-US");

//////string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//////double total = 0;
//////string message = "";

//////foreach (string e in values)
//////{
//////    double placeholder = 0;
//////    if (double.TryParse(e, out placeholder))
//////    {
//////        total += placeholder;

//////    }
//////    else
//////    {
//////        message += e;
//////    }
//////}

//////Console.WriteLine("Message: " + message);
//////Console.WriteLine("Total: " + total);
//////int value1 = 11;
//////decimal value2 = 6.2m;
//////float value3 = 4.3f;

//////decimal result1 = value1 / value2;
//////result1 = Convert.ToInt32(result1);
//////// Hint: You need to round the result to nearest integer (don't just truncate)
//////Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//////decimal result2 = value2 / (decimal)value3;
//////Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//////float result3 = value3 / value1;
//////Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

////string[] pallets = ["B14", "A11", "B12", "A13"];

//////Console.WriteLine("Sorted...");
//////Array.Sort(pallets);
//////foreach (var pallet in pallets)
//////{
//////    Console.WriteLine($"-- {pallet}");
//////}


//////Console.WriteLine("");
//////Console.WriteLine("Reversed...");
//////Array.Reverse(pallets);

//////foreach(var pallet in pallets)
//////{
//////    Console.WriteLine($"-- {pallet}");
//////}
////Console.WriteLine("");

////Array.Clear(pallets, 0, 2);

////Console.WriteLine($"Clearing 2 .... count: {pallets.Length}");
////foreach (var pallet in pallets)
////{
////    Console.WriteLine($" -- {pallet}");
////}

////Console.WriteLine("");
////Array.Resize(ref pallets, 6);
////Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

////pallets[4] = "C01";
////pallets[5] = "C02";

////foreach (var pallet in pallets)
////{
////    Console.WriteLine($"-- {pallet}");
////}
////Console.WriteLine("");

////Array.Resize(ref pallets, 3);
////Console.WriteLine($"Resizing 3 .... count : {pallets.Length}");
////foreach (var pallet in pallets)
////{
////    Console.WriteLine($"-- {pallet}");
////}

//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);

////string result = new string(valueArray);
//string result = String.Join(",", valueArray);
//Console.WriteLine(result);

//string[] items = result.Split(',');
//foreach (string e in items)
//{
//    Console.WriteLine(e);
//}


//string pangram = "The quick brown fox jumps over the lazy dog";
//string[] words = pangram.Split(" ");

//string[] temp = new string[words.Length];

//for( int i = 0; i < words.Length; i++)
//{
//    char[] chars = words[i].ToCharArray();
//    Array.Reverse(chars);
//    temp[i] = new string(chars);
//}

//string result = String.Join(" ", temp);
//Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);


for( int i = 0; i < orderIDs.Length; i++)
{
    if (orderIDs[i].Length != 4)
    {
        orderIDs[i] += "\t- Error";
        Console.WriteLine(orderIDs[i]);
    }
    else
    {
        Console.WriteLine(orderIDs[i]);
    }
}
//foreach (string order in orderIDs)
//{
//    if (order.Length == 4)
//    {
//        Console.WriteLine(order);
//    }
//    else
//    {
//        order += "    - Error";
//        Console.WriteLine(order);
//    }

//}
