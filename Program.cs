// Challenge 1
bool amProgrammer = true; 
int Age = 27;  
List<string> Names = new List<string>(); 
Names.Add("Monica"); 

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0"); 

string MyName = "MyName"; 

// Challenge 2
List<int> Numbers = new List<int>() {2, 3, 6, 7, 1, 5};
for (int i = Numbers.Count - 1; i >= 0; i--)  
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12, 7, 10, -3, 9};
foreach (int i in MoreNumbers)
{
    Console.WriteLine(i); 

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3, 6, 9, 12, 14};
for (int j = 0; j < EvenMoreNumbers.Count; j++) 
{
    if (EvenMoreNumbers[j] % 3 == 0)
    {
        EvenMoreNumbers[j] = 0; 
    }
}

// Challenge 5
string MyString = "superduperawesome";


// Challenge 6
Random rand = new Random();
int randomNum = rand.Next(13);  
if (randomNum == 12)
{
    Console.WriteLine("Hello");
}
}

