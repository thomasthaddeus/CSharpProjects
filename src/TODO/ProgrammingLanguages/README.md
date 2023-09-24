# Programming Languages

Do you know when C# was invented? How about your other favorite programming languages, like JavaScript, Ruby, and R?

In this project you’ll be using lists and LINQ to search a database for answers!

The data is stored in a .tsv file, which stands for tab-separated values. It’s a common way to export data from a spreadsheet or database — you might see this file type when you try to download data from apps like Microsoft Excel and Google Sheets.

Here is what the data would look like as a table (just a few random rows included):

Year	Name	Chief Developer	Predecessors
1990	AMOS BASIC	François Lionet, Constantin Sotiropoulos	STOS BASIC
1991	Visual Basic	Alan Cooper (sold to Microsoft)	QuickBASIC
1995	Ruby	Yukihiro Matsumoto	Smalltalk;Perl
2009	Go	Google	C;Oberon;Limbo;Smalltalk
In Program.cs, the data importing is already taken care of, so you can focus on the queries! The data is stored in languages which is a list of type List<Language>. You can find the definition for the Language class in Language.cs. Here are the class’s important members:

int Year — When the language was invented
string Name — The name of the language
string ChiefDeveloper — The head developer and/or company responsible for making the language
string Predecessors — The other programming languages that this language is based on
string Prettify() — Returns a nicely formatted string version of the object
Let’s get started!

## Tasks

Mark the tasks as complete by checking them off
Explore the Data
1.
Let’s start by printing all of the languages: print each item in languages by calling its Prettify() method.


Hint
Use a foreach loop that iterates for each var in languages.

2.
Write a query that returns a string for each language. It should include the year, name, and chief developer of each language.

Print each one to the console.


Stuck? Get a hint
Microsoft Languages
3.
When was C# first released?

Find the language(s) with the name "C#". Use the Prettify() method to print the results to the console.

Note: As you write more of these LINQ queries and print the results, your console output might get too long to read. We suggest you comment out the print statements of the previous query before writing the next one.


Stuck? Get a hint
4.
Microsoft invented a bunch of languages, not just C#!

Find all of the languages which have "Microsoft" included in their ChiefDeveloper property.


Stuck? Get a hint
Good Programmers Copy...
5.
A few early languages laid the foundation for many of the advanced languages we use now. One of those languages is Lisp, which looks like this:

;;; Here's a comment
(print "Hello world")
(+ 3 4)
(let x 29)
Find all of the languages that descend from Lisp.


Stuck? Get a hint
6.
Programmers really like to call their languages “scripts”.

Find all of the language names that contain the word "Script" (capital S). Make sure the query only selects the name of each language.


Stuck? Get a hint
Y2K
7.
How many languages are included in the languages list?


Stuck? Get a hint
8.
How many languages were launched between 1995 and 2005?


Stuck? Get a hint
9.
Print a string for each of those near-millennium languages.

In your query add a Select operation that returns a string of this format for each element:

NAME was invented in YEAR

Stuck? Get a hint
Print Methods
10.
You might have used foreach loops to print every Language in this project. Write a method PrettyPrintAll() that handles that for us. It should:

return nothing
accept an argument of type IEnumerable<Language>
pretty print every language in the argument

Stuck? Get a hint
11.
You might have also used foreach loops to print every query result in this project. Write a method PrintAll() that handles that for us. It should:

return nothing
accept an argument of type IEnumerable<Object>
prints every object in the argument

Stuck? Get a hint
Extensions
12.
Well done! You’ve completed the main project. If you’d like to dive deeper into LINQ, try these optional challenges:

Take a look at the first query in Program.cs. It uses the File class and the ReadAllLines() method, then it uses three LINQ methods: Skip(), Select(), ToList(). Try to explain what each method call does, in simple terms. Use the .NET API Browser to learn more about any unfamiliar methods.

Your queries are currently sorted by year since the languages list was sorted by year. Try sorting a query alphabetically (on the name of each language) using the OrderBy() method.

Find the oldest language in the list using the Min() method.