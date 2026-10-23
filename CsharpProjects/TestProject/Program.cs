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



// #1 the ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";
//string suggestedDonation = "";



//// #2 variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";
//decimal decimalDonation;
//// #3 array used to store runtime data, there is no persisted data
//string[,] ourAnimals = new string[maxPets, 7];



//// #4 create sample data ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            animalSpecies = "dog";
//            animalID = "d1";
//            animalAge = "2";
//            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//            animalNickname = "lola";
//            suggestedDonation = "85.00";
//            break;

//        case 1:
//            animalSpecies = "dog";
//            animalID = "d2";
//            animalAge = "9";
//            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//            animalNickname = "gus";
//            suggestedDonation = "49.99";
//            break;

//        case 2:
//            animalSpecies = "cat";
//            animalID = "c3";
//            animalAge = "5";
//            animalPhysicalDescription = " Fat retarded cat";
//            animalPersonalityDescription = " Lazy bum that likes to sleep all day";
//            animalNickname = "bucko";
//            suggestedDonation = "40.00";
//            break;

//        case 3:
//            animalSpecies = "cat";
//            animalID = "c4";
//            animalAge = "8";
//            animalPhysicalDescription = " IZGLEDA KAO COVEK ";
//            animalPersonalityDescription = " hiperaktivna i mnogo jede ";
//            animalNickname = "vanzemaljac";
//            suggestedDonation = "";
//            break;

//        default:
//            animalSpecies = "";
//            animalID = "";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            suggestedDonation = "";
//            break;


//    }
//    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//    {
//        decimalDonation = 45.00m;

//    }
//    else
//    {
//        decimalDonation = Convert.ToDecimal(suggestedDonation);
//    }
//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//    ourAnimals[i, 6] = $"suggested Donation : {decimalDonation:C2}"; 
//}
//// #5 display the top-level menu options
//do
//{
//    // NOTE: the Console.Clear method is throwing an exception in debug sessions
//    Console.Clear();

//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    // use switch-case to process the selected menu option
//    switch (menuSelection)
//    {
//        case "1":
//            // list all pet info
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine();
//                    for (int j = 0; j < 7; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j]);
//                    }
//                }
//            }
//            Console.WriteLine("\n\rPress the Enter key to continue");
//            readResult = Console.ReadLine();
//            break;

//        case "2":
//            // Display all dogs with a specified characteristic");
//            string dogCharacteristic = "";
//            string dogDescription = "";
//            bool noMatchesDog = true;
//            while (dogCharacteristic == "")
//            {
//                // have the user enter physical characteristics to search for
//                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
//                readResult = Console.ReadLine();
//                if (readResult != null)
//                {
//                    dogCharacteristic = readResult.ToLower().Trim();
//                }
//            }
//            for (int i = 0; i < maxPets; i++)
//            {


//                if (ourAnimals[i, 1].Contains("dog"))
//                {
//                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
//                    if (dogDescription.Contains(dogCharacteristic))
//                    {
//                        noMatchesDog = false;
//                        Console.WriteLine($"\nOur dog {ourAnimals[i,3]} is a match");
//                        Console.WriteLine(dogDescription);
//                    }
//                }
//               }
//            if (noMatchesDog)
//            {
//                Console.WriteLine("None of our dogs are a match for: "+dogCharacteristic);
//            }
//            Console.WriteLine("Press the Enter key to continue.");
//            readResult = Console.ReadLine();
//            break;


//        default:
//            break;
//    }

//} while (menuSelection != "exit");





// ourAnimals array will store the following: 
// Final

// ourAnimals array will store the following: 
//string animalSpecies = "";
//string animalID = "";
//string animalAge = "";
//string animalPhysicalDescription = "";
//string animalPersonalityDescription = "";
//string animalNickname = "";
//string suggestedDonation = "";

//// variables that support data entry
//int maxPets = 8;
//string? readResult;
//string menuSelection = "";
//decimal decimalDonation = 0.00m;

//// array used to store runtime data
//string[,] ourAnimals = new string[maxPets, 7];

//// sample data ourAnimals array entries
//for (int i = 0; i < maxPets; i++)
//{
//    switch (i)
//    {
//        case 0:
//            animalSpecies = "dog";
//            animalID = "d1";
//            animalAge = "2";
//            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//            animalNickname = "lola";
//            suggestedDonation = "85.00";
//            break;

//        case 1:
//            animalSpecies = "dog";
//            animalID = "d2";
//            animalAge = "9";
//            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//            animalNickname = "gus";
//            suggestedDonation = "49.99";
//            break;

//        case 2:
//            animalSpecies = "cat";
//            animalID = "c3";
//            animalAge = "1";
//            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//            animalPersonalityDescription = "friendly";
//            animalNickname = "snow";
//            suggestedDonation = "40.00";
//            break;

//        case 3:
//            animalSpecies = "cat";
//            animalID = "c4";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "lion";
//            suggestedDonation = "";

//            break;

//        default:
//            animalSpecies = "";
//            animalID = "";
//            animalAge = "";
//            animalPhysicalDescription = "";
//            animalPersonalityDescription = "";
//            animalNickname = "";
//            suggestedDonation = "";
//            break;
//    }

//    ourAnimals[i, 0] = "ID #: " + animalID;
//    ourAnimals[i, 1] = "Species: " + animalSpecies;
//    ourAnimals[i, 2] = "Age: " + animalAge;
//    ourAnimals[i, 3] = "Nickname: " + animalNickname;
//    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//    {
//        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
//    }
//    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
//}

//// top-level menu options
//do
//{
//    // NOTE: the Console.Clear method is throwing an exception in debug sessions
//    Console.Clear();

//    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//    Console.WriteLine(" 1. List all of our current pet information");
//    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//    Console.WriteLine();
//    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//    readResult = Console.ReadLine();

//    if (readResult != null)
//    {
//        menuSelection = readResult.ToLower();
//    }

//    // switch-case to process the selected menu option
//    switch (menuSelection)
//    {
//        case "1":
//            // list all pet info
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 0] != "ID #: ")
//                {
//                    Console.WriteLine();

//                    for (int j = 0; j < 7; j++)
//                    {
//                        Console.WriteLine(ourAnimals[i, j].ToString());
//                    }
//                }
//            }

//            Console.WriteLine("\r\nPress the Enter key to continue");
//            readResult = Console.ReadLine();

//            break;

//        case "2":
//            // #1 Display all dogs with a multiple search characteristics

//            string dogCharacteristics = "";

//            while (dogCharacteristics == "")
//            {
//                // #2 have user enter multiple comma separated characteristics to search for
//                Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
//                readResult = Console.ReadLine();

//                if (readResult != null)
//                {
//                    dogCharacteristics = readResult.ToLower();
//                    Console.WriteLine();
//                }
//            }

//            string[] dogSearches = dogCharacteristics.Split(",");
//            // trim leading and trailing spaces from each search term
//            for (int i = 0; i < dogSearches.Length; i++)
//            {
//                dogSearches[i] = dogSearches[i].Trim();
//            }

//            Array.Sort(dogSearches);
//            // #4 update to "rotating" animation with countdown
//            string[] searchingIcons = { " |", " /", "--", " \\", " *" };

//            bool matchesAnyDog = false;
//            string dogDescription = "";

//            // loops through the ourAnimals array to search for matching animals
//            for (int i = 0; i < maxPets; i++)
//            {
//                if (ourAnimals[i, 1].Contains("dog"))
//                {

//                    // Search combined descriptions and report results
//                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
//                    bool matchesCurrentDog = false;

//                    foreach (string term in dogSearches)
//                    {
//                        // only search if there is a term to search for
//                        if (term != null && term.Trim() != "")
//                        {
//                            for (int j = 2; j > -1; j--)
//                            {
//                                // #5 update "searching" message to show countdown
//                                foreach (string icon in searchingIcons)
//                                {
//                                    Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
//                                    Thread.Sleep(100);
//                                }

//                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
//                            }

//                            // #3a iterate submitted characteristic terms and search description for each term
//                            if (dogDescription.Contains(" " + term.Trim() + " "))
//                            {
//                                // #3b update message to reflect current search term match 

//                                Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

//                                matchesCurrentDog = true;
//                                matchesAnyDog = true;
//                            }
//                        }
//                    }

//                    // #3d if the current dog is match, display the dog's info
//                    if (matchesCurrentDog)
//                    {
//                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
//                    }
//                }
//            }

//            if (!matchesAnyDog)
//            {
//                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
//            }

//            Console.WriteLine("\n\rPress the Enter key to continue");
//            readResult = Console.ReadLine();

//            break;

//        default:
//            break;
//    }
//}
//while (menuSelection != "exit");

//int[] brojevi = { 1, 2, 3, 4 };

//Console.WriteLine("Vredonsti u skupini brojeva:");
//PrintArray(brojevi);
//Console.WriteLine("\n");
//PrikaziSlucajneBrojeve();

//void PrintArray(int[] numbersArray)
//{
//foreach (int i in numbersArray)
//    {
//        Console.WriteLine($"{i}");
//    }
//}


//void PrikaziSlucajneBrojeve()
//{
//    Random slucajniBroj = new Random();

//    for (int i=0; i < 5; i++)
//    {
//        Console.WriteLine($"{slucajniBroj.Next(1,100)}");
//    }
//    Console.WriteLine();

//}



//int[] times = { 800, 1200, 1600, 2000 };
//int diff = 0;

//Console.WriteLine("Enter current GMT");
//int currentGMT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Current Medicine Schedule:");

///* Format and display medicine times */
//DisplayTime();

//Console.WriteLine();

//Console.WriteLine("Enter new GMT");
//int newGMT = Convert.ToInt32(Console.ReadLine());

//if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//{
//    Console.WriteLine("Invalid GMT");
//}
//else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//{
//    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    AdjustTime();
//}
//else
//{
//    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    AdjustTime();
//}

//Console.WriteLine("New Medicine Schedule:");

///* Format and display medicine times */
//DisplayTime();

//Console.WriteLine();

//void AdjustTime()
//{
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}

//void DisplayTime()
//{
//    foreach (int val in times)
//    {
//        string time = val.ToString();
//        int len = time.Length;

//        if (len >= 3)
//        {
//            time = time.Insert(len - 2, ":");
//        }
//        else if (len == 2)
//        {
//            time = time.Insert(0, "0:");
//        }
//        else
//        {
//            time = time.Insert(0, "0:0");
//        }

//        Console.Write($"{time} ");
//    }
//}

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
//using System.Net;

///* Format and display medicine times */
///* Format and display medicine times */
//string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
//bool validLength = false;
//bool validZeroes = false;
//bool validRange = false;
//string[] address;

//foreach (string ip in ipv4Input)
//{
//    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
//    ValidateLength();
//    ValidateZeroes();
//    ValidateRange();

//    if (validLength && validZeroes && validRange)
//    {
//        Console.WriteLine($"{ip} is a valid IPv4 address");
//    }
//    else
//    {
//        Console.WriteLine($"{ip} is an invalid IPv4 address");
//    }
//}




//void ValidateLength()
//{

//    validLength = address.Length == 4;
//}
//void ValidateZeroes()
//{

//    foreach( string num in address)
//    {
//        if (num.Length > 1 && num.StartsWith("0"))
//        {
//            validZeroes = false;
//            return;
//        }
//    }
//    validZeroes = true; 
//}
//void ValidateRange()
//{


//    foreach(string br in address)
//    {
//        int val = int.Parse(br);
//        if(val < 0 || val > 255)
//        {
//            validRange = false;
//            return;
//        }

//    }

//}

//Random random = new Random();
//int luck = random.Next(1);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

//Console.WriteLine("A fortune teller whispers the following words:");
//DisplayFortune();

//void DisplayFortune()
//{
//    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//    for (int i = 0; i < 4; i++)
//    {
//        Console.Write($"{text[i]} {fortune[i]} ");
//    }
//}







