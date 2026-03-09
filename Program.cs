//Challenge 1- Multi-Condition Exam Eligibility

using System.ComponentModel.Design;

/*bool paidFees = true;
bool hasIdcard = true;
bool hasDonematric = false;
bool isCitizen = false;*/

/*if (paidFees && hasIdcard || hasDonematric || isCitizen) 
{
Console.WriteLine("Student is eligible to take exam");
}
else
{
Console.WriteLine("Student is not eligible to take exam");*/
//}

//explanation

// the program returns "student is eligible to take exam" given that the program runs in a synchronous style;
//we have 3 standalone statement in the operation;
//paidFees && hasIdcard is one standalone
//hasDonematric and isCitizen are two separate standalone
//what the program understand is True OR False OR False= True; since only one condition has to be true in OR-logic 
//i.e one condition needs to be met to return a true value, the operation returns true
//in a case where the first differentiating values were false i.e false OR false OR false, it would return a false value.

//Challenge 2- Access to School Portal

/*
bool paidFees = false;
bool hasIdcard = true;
bool hasDoneregistration = true;
bool isCitizen = false;

if (hasDoneregistration && paidFees || isCitizen && hasIdcard)
{
    Console.WriteLine("Student can access the school portal");
}
else
{
    Console.WriteLine("Student can not access the school portal");
}
*/

//explanation

//there are two standalone expression in the operation separated by OR logic operator
//hasDoneregistration && paidFees || isCitizen && hasIdcard
//what the program understand is false || false, since none of the condition wasn't met, it returns a false value
//hence, the output will be "student can not access the school portal"

//Challenge 3- Grade System

/*
int score = 45;

if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50  && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("fail");
}
*/

//explanation

//our variable score = 45, the condition for the variable will be met if score is less than 50 and the grade value for <50 is fail
//hence, the output will be "fail"

/*
int score = 65;

if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50  && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("fail");
}
*/

//explanation

//our variable score = 65, the condition for the variable will be met if score>=60<80 and the grade value for is 'B'
//hence, the output will be "Grade B"

/*
int score = 55;

if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50  && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("fail");
}
*/


//explanation

//our variable score = 55, the condition for the variable will be met if score>=50<60 and the grade value for is 'C'
//hence, the output will be "Grade C"


int score = 85;

if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50  && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("fail");
}

//explanation

//our variable score = 85, the condition for the variable will be met if score>=80 and the grade value for is 'A'
//hence, the output will be "Grade A"

//Challenge 4- Library Borrowing Rules

/*bool paidfees = true;
bool hasIDcard = true;
bool isStaff = false;
bool bookReserved = false;

if (paidfees && hasIDcard || isStaff && bookReserved)
{
    Console.WriteLine("student can borrow book");
}
else
{
    Console.WriteLine("student can not borrow book");
}*/

//explanation

//there are two standalone expression in the operation separated by OR logic operator
//paidfees && hasIDcard || isStaff && bookReserved which is the same has true and true OR false and false
//what the program understand is true || false, since one of the condition must be met in OR logic, it returns a true value
//hence, the output will be "student can borrow book"

//Challenge 5- Complex 5-variable logic

bool paidFees = true;
bool hasIDcard = true;
bool hasDonematric =false;
bool hasDoneRegistration = false;
bool isCitizen = false;

if ((paidFees && hasIDcard && hasDonematric) || hasDoneRegistration || isCitizen && hasIDcard)
{
    Console.WriteLine("Student is fully verified for all school processes");
}
else
{
    Console.WriteLine("Student is not fully verified for all school processes");
}

//explanation

// we have 3 standalone expression in the operation
//paidFees && hasIDcard && hasDonematric is one expression
// hence, true and true and false = false because all conditions must be met in AND logic.
//hasDoneRegistration is the second standalone expression which is false
//isCitizen && hasIDcard is the third standalone expression which is false and true = false
//the expression is translated has false || false || false = false
//hence, the output is "Student is not fully verified for all school processes"





