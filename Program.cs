//Task 1- ARITHEMETIC OPERATORS

int a = 60;
int b = 25;

int printAddition = a + b;
Console.WriteLine($"our answer= {printAddition}");

int printSubtraction = a - b;
Console.WriteLine($"our answer= {printSubtraction}");

int printMultiplication = a * b;
Console.WriteLine($"our answer= {printMultiplication}");

double printDivision = (double)a / b;
Console.WriteLine($"our answer= {printDivision}");

int printModulus = a % b;
Console.WriteLine($"our answer= {printModulus}");

//Task 2- Integer vs Double Division

int ab = 10;
int bc = 4;

int intDivision = ab / bc;
Console.WriteLine($"our answer= {intDivision}");

double doubleDivision = (double)ab / bc;
Console.WriteLine($"our answer= {doubleDivision}");

//Task 3- Large Numbers

int population1 = 40000000;
long population2 = 40000000000;

long newPopulation = population1 + population2;
Console.WriteLine($"newPopulation= {newPopulation}");

//Task 4- Shop Calculator

decimal price = 1500.75m;
int quantity = 3;

decimal totalCost = price * quantity;
Console.WriteLine($"Total Price={totalCost}");

//Task 5- Bonus Challenge

int number1 = 20;
int number2 = 30;
int number3 = 40;

int averageScore = (number1 + number2 + number3)/3;
Console.WriteLine($"averageScore= {averageScore}");
    
    

    


