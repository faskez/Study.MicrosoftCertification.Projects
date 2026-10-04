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

//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] orderIDs = orderStream.Split(",");
//Array.Sort(orderIDs);


//for( int i = 0; i < orderIDs.Length; i++)
//{
//    if (orderIDs[i].Length != 4)
//    {
//        orderIDs[i] += "\t- Error";
//        Console.WriteLine(orderIDs[i]);
//    }
//    else
//    {
//        Console.WriteLine(orderIDs[i]);
//    }
//}
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
//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2750.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"\t Shares: {productShares:N3} Product");
//Console.WriteLine($"\t Sub Total: {subtotal:C}");
//Console.WriteLine($"\t Precentage: {taxPercentage:P2}");
//Console.WriteLine($"\t Total: {total:C}");

//string input = "Pad this";
////Console.WriteLine(input.PadLeft(12));
////Console.WriteLine(input.PadRight(12));

//Console.WriteLine(input.PadLeft(12, '-'));
//Console.WriteLine(input.PadRight(12, '-'));

//string paymentId = "769C";
//string payeeName = "Mr. Stephen Ortega";
//string paymentAmount = "$5,000.00";

//var formattedLine = paymentId.PadRight(6);
//formattedLine += payeeName.PadRight(24);
//formattedLine += paymentAmount.PadLeft(10);

//Console.WriteLine(formattedLine);
//string customerName = "Ms. Barros";

//string currentProduct = "Magic Yield";
//int currentShares = 2975000;
//decimal currentReturn = 0.1275m;
//decimal currentProfit = 55000000.0m;

//string newProduct = "Glorious Future";
//decimal newReturn = 0.13125m;
//decimal newProfit = 63000000.0m;

//Console.WriteLine($"Dear {customerName},");
//Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
//Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
//Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}\n");


//Console.WriteLine("Here's a quick comparison:\n");

//string comparisonMessage = "";
//comparisonMessage += currentProduct.PadRight(20);
//comparisonMessage += string.Format("{0:P2}   {1:C}\n", currentReturn,currentProfit);
//comparisonMessage += newProduct.PadRight(20);
//comparisonMessage += string.Format("{0:P2}   {1:C}\n", newReturn, newProfit);

//// Your logic here

//Console.WriteLine(comparisonMessage);

//  04.10.2026f
//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

//openingPosition += 1;
////Console.WriteLine(openingPosition);
////Console.WriteLine(closingPosition);
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition,length));
//string message = "What is the value <span>between the tags</span>?";

//int openingPosition = message.IndexOf("<span>");
//int closingPosition = message.IndexOf("</span>");       

//openingPosition += 6;
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));
//string message = "hello there!";

//int first_h = message.IndexOf('h');
//int last_h = message.LastIndexOf('h');

//Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//int openingPosition = message.LastIndexOf('(');

//openingPosition += 1;
//int closingPosition = message.LastIndexOf(')');
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));
//string message = "(What if) there are (more than) one (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;

//    openingPosition += 1;
//    int closingPosition = message.IndexOf(')');
//    if (closingPosition == -1) break;
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition,length));

//    message = message.Substring(closingPosition + 1);
//}
//string message = "Hello, world!";
//char[] charsToFind = { 'a', 'e', 'i' };
//int index = message.IndexOfAny(charsToFind);
//Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
//string msg = "Help (find) the {opening symbols}";
//Console.WriteLine($"Searching THIS Message: {msg}");
//char[] openSymbols = { '[', '{', '(' };
//int startPosition = 5;
//int openingPosition = msg.IndexOfAny(openSymbols);
//Console.WriteLine($"Found WITHOUT using startPosition: {msg.Substring(openingPosition)}");
//openingPosition = msg.IndexOfAny(openSymbols, startPosition);
//Console.WriteLine($"Found WITH using startPosition {startPosition}:  {msg.Substring(openingPosition)}");

//string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//// The IndexOfAny() helper method requires a char array of characters. 
//// You want to look for:

//char[] openSymbols = { '[', '{', '(' };

//// You'll use a slightly different technique for iterating through 
//// the characters in the string. This time, use the closing 
//// position of the previous iteration as the starting index for the 
////next open symbol. So, you need to initialize the closingPosition 
//// variable to zero:

//int closingPosition = 0;

//while (true)
//{
//    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//    if (openingPosition == -1) break;

//    string currentSymbol = message.Substring(openingPosition, 1);

//    // Now  find the matching closing symbol
//    char matchingSymbol = ' ';

//    switch (currentSymbol)
//    {
//        case "[":
//            matchingSymbol = ']';
//            break;
//        case "{":
//            matchingSymbol = '}';
//            break;
//        case "(":
//            matchingSymbol = ')';
//            break;
//    }

//    // To find the closingPosition, use an overload of the IndexOf method to specify 
//    // that the search for the matchingSymbol should start at the openingPosition in the string. 

//    openingPosition += 1;
//    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//    // Finally, use the techniques you've already learned to display the sub-string:

//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));
//}

//string data = "12345John Smith          5000  3  ";
//string updatedDate = data.Remove(5, 20);
//Console.WriteLine(updatedDate);

//string message = "This--is--ex-amp-le--da-ta";
//message = message.Replace("--", " ");
//message = message.Replace("-", "");
//Console.WriteLine(message);

//MOJE RESENJE ZADATKA
//using System.ComponentModel.DataAnnotations;

//const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

//string quantity = "Quantity: ";
//string output = input;

//// Your work here
//int openPos = input.IndexOf("<span>");
//openPos+=6;
//int closingPos = input.IndexOf("</span>");
//int length = closingPos - openPos;
//quantity += input.Substring(openPos, length);
//output= output.Remove(0,5);
//output= output.Remove(output.LastIndexOf('<'),6);
//output = output.Replace("&trade", "&reg");

//Console.WriteLine(quantity);
//Console.WriteLine(output);

//RESENJE SA SAJTA
//const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

//string quantity = "";
//string output = "";

//// Your work here

//// Extract the "quantity"
//const string openSpan = "<span>";
//const string closeSpan = "</span>";

//int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
//int quantityEnd = input.IndexOf(closeSpan);
//int quantityLength = quantityEnd - quantityStart;
//quantity = input.Substring(quantityStart, quantityLength);
//quantity = $"Quantity: {quantity}";

//// Set output to input, replacing the trademark symbol with the registered trademark symbol
//const string tradeSymbol = "&trade;";
//const string regSymbol = "&reg;";
//output = input.Replace(tradeSymbol, regSymbol);

//// Remove the opening <div> tag
//const string openDiv = "<div>";
//int divStart = output.IndexOf(openDiv);
//output = output.Remove(divStart, openDiv.Length);

//// Remove the closing </div> tag and add "Output:" to the beginning
//const string closeDiv = "</div>";
//int divCloseStart = output.IndexOf(closeDiv);
//output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

//Console.WriteLine(quantity);
//Console.WriteLine(output);





































