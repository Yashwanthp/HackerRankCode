<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.Linq.dll</Reference>
  <Namespace>System.Data.Linq</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

void Main()
{
	int i = 4;
	double d = 4.0;
	string s = "HackerRank";
	
	 // Declare second integer, double, and String variables.
	 int j = int.Parse(Console.ReadLine());
	 double d1 = double.Parse(Console.ReadLine());
	 string s1 = Console.ReadLine();
        
        // Read and save an integer, double, and String to your variables.
     int integerResult = i + j;   
	 double doubleResult = d + d1;
	 string concatenatedString = s + " " + s1;
        // Print the sum of both integer variables on a new line.
      Console.WriteLine(integerResult);  
        // Print the sum of the double variables on a new line.
         Console.WriteLine(String.Format("{0:0.0}", doubleResult));
		 
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
		Console.WriteLine(concatenatedString); 
}


