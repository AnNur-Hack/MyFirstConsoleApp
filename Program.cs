//Task 1- Student 

/*int[] scores = { 45, 70, 55, 30, 90, 60 };
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine("scores: " + scores[i]); //concatenation
}*/

/*
int[] scores = { 45, 70, 55, 30, 90, 60 };
int highestScore = scores[0]; //We start by assuming the first score is both highest and lowest.
int lowestScore = scores[0];


for (int i = 1; i < scores.Length; i++) // we start from index 1 because index 0 is already assumed.
{ if (scores[i] > highestScore)
    {
        highestScore = scores[i]; 
    }
    if (scores[i] < lowestScore)
    {
        lowestScore = scores[i];
    }
}
Console.WriteLine("Highest Score: " + highestScore); //concatenation
Console.WriteLine("Lowest Score: " + lowestScore); //concatenation*/

/*
int[] scores = { 45, 70, 55, 30, 90, 60 };
int sum = 0;

for (int i = 0; i < scores.Length; i++) // Loop through each score and add to sum
{
    sum += scores[i];
}
decimal average = (decimal)sum / scores.Length; // we calculate the average, we used decimal because the output will be in decimals

// Print the average
Console.WriteLine($"Average score: {average}");*/

/*
int[] scores = { 45, 70, 55, 30, 90, 60 };

int sum = 0; // sum of all scores

// 1. Calculate total sum
for (int i = 0; i < scores.Length; i++)
{
    sum += scores[i];
}
*/

// 2. Calculate average and round to 2 decimal places
/*double average = ((double)sum / scores.Length);
Console.WriteLine("Average score: " + average);

// 3. Count number of students above average
int countAboveAverage = 0;
for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] > average)
    {
        countAboveAverage++; // increment count if score > average
    }
}

// 4. Print the result
{
    Console.WriteLine("Number of students above average: " + countAboveAverage);
}

for (int i = 0; i < scores.Length; i++) //iterate through all students.
{
    if (scores[i] >= 50) 
    {
        Console.WriteLine($"Student {i + 1}: Passed"); // interpolation
    }
    else
    {
        Console.WriteLine($"Student {i + 1}: failed"); //interpolation
    }
}*/

//Task 2- Array filter and Reverse

        // Array of temperatures
        int[] temperatures = { 25, 32, 28, 35, 30, 29, 40 };
        int threshold = 30; // Temperature threshold

        // 1. Print all temperatures
        Console.Write("All temperatures: ");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write(temperatures[i]);
            if (i < temperatures.Length - 1) Console.Write(", ");
        }
        Console.WriteLine(); // Move to next line

        // 2. Print only temperatures above threshold
        Console.Write($"Temperatures above {threshold}: ");
        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] > threshold)
            {
                Console.Write(temperatures[i] + " ");
            }
        }
        Console.WriteLine(); // Move to next line

        // 3. Reverse the array and print
        Console.Write("Reversed temperatures: ");
        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            Console.Write(temperatures[i]);
            if (i > 0) Console.Write(", ");
        }
        Console.WriteLine(); // Move to next line

        // 4. Calculate and print average temperature
        int sum = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            sum += temperatures[i];
        }

        {
            double average = (double)sum / temperatures.Length;
            Console.WriteLine("Average temperature: " + average);
        }
    









     

