Exercise 2. Create a new C# Console project called ColorList.
•	Create a utility method called Print to use with the List’s built in ForEach function:

private static void Print(string s)
{
	Console.WriteLine(s);
}

•	In the Main method of the application, define a List of strings called Colors:

List<string> Colors = new List<string>();

//	Call the Add( ) method of the Colors list to add the following string items in this order:
                    White, Red, Orange, Yellow, Green, Blue, Indigo, Violet, Black

//	Print the list by passing the Print method to the list’s ForEach method.

//	Use the Count( ) method of your list and save the return. 

//	Write the value to the console in a string that says “The Colors list has {0} items”.

//	Sort the list by calling its Sort() method

•	Use a foreach loop to write all the items to the console:

	foreach (string color in Colors)
	{
		Console.WriteLine(color);
	}

•	Use indexOf() to find the index number for the string “Violet”

int index = colors.IndexOf("Violet");

•	Use Remove( ) to remove the item Violet using the index number.

•	Use Insert( ) to put the string Purple in the second last location.

•	Repeat the foreach loop to see the modified list.

•	Use the Contains( ) method to determine if Magenta is part of the list (it should not be): 

if (Colors.Contains("Magenta")
{
	Console.WriteLine("Magenta is in the list");
}

•	Use Add( ) to add Magenta to the list. Repeat the Contains() code and it should output the message.

•	Repeat the foreach loop. 
Where did Add( ) place Magenta in the list? Why do we need an Insert( ) method?
