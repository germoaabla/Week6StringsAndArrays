//string myString = "Hello, World!";

////int theLengthOfMyString = myString.Length;
////Console.WriteLine(theLengthOfMyString);
//Console.WriteLine(myString.Length);


//Console.WriteLine("Enter your first name:");
//string userName = Console.ReadLine().Trim(); //trim removes space before and after string; not inbetween!

string userName = "Harry Potter";
Console.WriteLine(userName);

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}");


//a-counter


//int counter = 0;

//for  (int i = 0; i < userName.Length; i++)
//{
//    if (userName[i] == 'a')
//    {
//        counter++; //counter = counter + 1
//    }
//}

//Console.WriteLine($"Your name has {counter} a-letters.");

string updatedUsername = userName.Replace('a', '4').Replace('o', '0').Replace('e', '3');

Console.WriteLine(updatedUsername);