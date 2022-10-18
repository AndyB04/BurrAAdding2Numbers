// Andrea Burr
// 10-18-2022
// mini2 redo - github
Console.Clear();
bool playagain = true;

while (playagain){

Console.WriteLine("lets add two numbers!");
Console.WriteLine("enter your first number!");
string numberOne = Console.ReadLine();
Console.WriteLine("Enter your second number please");
string numberTwo = Console.ReadLine();

int num1 = Convert.ToInt32(numberOne);
int num2 = Convert.ToInt32(numberTwo);

Console.WriteLine("your sum is " + (num1 + num2) + " hope this helps!");
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}

