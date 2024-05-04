// Landon Holloway (lah0084)
// ISMN 3080 Fall 2023
// Programming Assignment 1

//Variables
double totalCal = 533;
double totalCandy = 36;
double servingSize = 12; 


//Input number of M&M's eaten
Console.WriteLine("How many M&M's have you eaten: ");
double candyEaten = Convert.ToDouble(Console.ReadLine());

//Calculations
double caloriesPerCandy = Convert.ToDouble(totalCal/totalCandy);
double roundCal = Math.Round(caloriesPerCandy, 3);

double caloriesEaten = Convert.ToDouble(candyEaten * caloriesPerCandy);
double roundCalEaten = Math.Round(caloriesEaten, 3);

double servingsEaten = Convert.ToDouble(candyEaten/servingSize);
double roundServEaten = Math.Round(servingsEaten, 3);

//Calculation Output
Console.WriteLine("Total Calories Consumed: " + roundCalEaten);
Console.WriteLine("Number of Servings Consumed: " + roundServEaten);