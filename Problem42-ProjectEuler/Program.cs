Dictionary<string, int> letterValues = new();
letterValues.Add("A", 1);
letterValues.Add("B", 2);
letterValues.Add("C", 3);
letterValues.Add("D", 4);
letterValues.Add("E", 5);
letterValues.Add("F", 6);
letterValues.Add("G", 7);
letterValues.Add("H", 8);
letterValues.Add("I", 9);
letterValues.Add("J", 10);
letterValues.Add("K", 11);
letterValues.Add("L", 12);
letterValues.Add("M", 13);
letterValues.Add("N", 14);
letterValues.Add("O", 15);
letterValues.Add("P", 16);
letterValues.Add("Q", 17);
letterValues.Add("R", 18);
letterValues.Add("S", 19);
letterValues.Add("T", 20);
letterValues.Add("U", 21);
letterValues.Add("V", 22);
letterValues.Add("W", 23);
letterValues.Add("X", 24);
letterValues.Add("Y", 25);
letterValues.Add("Z", 26);

//Insert the words into an string Array
string[] words = System.IO.File.ReadAllText(@"C:\Users\nikil\Documents\Developer\ProjectEuler\Problem42-ProjectEuler\words.txt").Split(",");

//Get the max value to know the triangle limit number
double maxValue = 0;
foreach (string word in words)
{
    if(GetValue(word) > maxValue)
        maxValue = GetValue(word);
}

// Build a List with all triangle numbers below max
List<double> triangleNums = new();
int counter = 1;
while (true)
{
    triangleNums.Add(counter*(counter+1)/2);
    counter++;
    if (counter * (counter + 1) / 2 > maxValue)
        break;
}

//Loop and count all triangle words
int totalTriangleNums = 0;
foreach(string word in words)
{
    if (triangleNums.Contains(GetValue(word)))
        totalTriangleNums++;
}

//Print the answer
Console.WriteLine("There are {0} triangle words", totalTriangleNums);

double GetValue(string word)
{
    double sum = 0;
    foreach(char c in word)
    {
        sum += letterValues[c.ToString().ToUpper()];
    }
    return sum;
}