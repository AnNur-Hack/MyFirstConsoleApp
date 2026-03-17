/*
int[] temperatures = [25, 32, 28, 35, 30, 29, 40];
var threshold = 30;

foreach (var t in temperatures)
{
    if (t >= threshold) 
    {
        threshold = t;
        Console.WriteLine($"temperature is {threshold}");
    }
}
*/

//Atm Machine project

int pin = 7071;
int amount = 5000;
string Acctname = "Lakan";
int[] amountwithdraw = {2000,500,1000,5000};

Console.WriteLine("Pls enter your pin");
int pinentry = int.Parse(Console.ReadLine());
if (pinentry == pin)
{
 Console.WriteLine("Enter your account type\n(1) Press 1 for saving. \n (2) Press 2 for current.");
 int accttypeEntry = int.Parse(Console.ReadLine());
 if (accttypeEntry == 1)
 {
 Console.WriteLine("////////////////////////// \n(1) Press 1 to withdraw. \n (2) Press 2 to check balance.");
 int bankoperation = int.Parse(Console.ReadLine());
 if (bankoperation == 1)
 {
 Console.WriteLine("///////////////////////\n select amount to withraw\n(1) 2000. \n (2) 500 \n (3) 1000 \n (4) 5000 \n (5)Enter value you want to with");
 int amountToWithdraw = int.Parse(Console.ReadLine());
 // we move to switch case 
 switch (amountToWithdraw)
 {
  case 1:
   amount -= amountwithdraw[0];
   Console.WriteLine($"//////Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TrasactionType = Debit.\n Amount-Withdrawn = {amountwithdraw[0]}. \n Balance = {amount}.\n Thank you for banking with us.");
   break;
  case 2:
   amount -=  amountwithdraw[1];
   Console.WriteLine($"////Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TrasactionType = Debit.\n Amount-Withdrawn = {amountwithdraw[1]}. \n Balance = {amount}.\n Thank you for banking with us.");
   break;
  case 3:
   amount -= amountwithdraw[2];
   Console.WriteLine($"////Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TransactionType = Debit.\n Amount-Withdrawn = {amountwithdraw[2]}. \n Balance = {amount}.\n Thank you for banking with us.");
   break;
  case 4:
   amount -=  amountwithdraw[3];
   Console.WriteLine($"////Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TrasnactionType = Debit.\n Amount-Withdrawn = {amountwithdraw[3]}. \n Balance = {amount}.\n Thank you for banking with us.");
   break;
  case 5:
   amount -=  amountToWithdraw;
   Console.WriteLine($"////Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TrasactionType = Debit.\n Amount-Withdrawn = {amountwithdraw[0]}. \n Balance = {amount}.\n Thank you for banking with us.");
   break;
  default:
   Console.WriteLine("////////\nInvalid opration");
   break;
 }
 }
// Console.WriteLine($"/////AccountSummary///\n. welcome {Acctname}, Your Account Balance is #{amount}");
 
 }
 else
 {
  Console.WriteLine("//////////////////\nYour account type is invalid");
 }
 
}
else
{
 Console.WriteLine("/////////Invalid pin, try again");
}


 









     

