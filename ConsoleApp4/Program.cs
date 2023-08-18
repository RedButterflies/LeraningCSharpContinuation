// switch case
Console.WriteLine("What's your favourite day of the number (Enter a number from 1 to 10)?");
int favNumber = Convert.ToInt32(Console.ReadLine());
switch(favNumber)
{
    case 1: 
        Console.WriteLine("Your favourite number is 1, is Monday your favourire day of the week and January your favourite month as well?");
        break;
    case 2:
        Console.WriteLine("Your favourite number is 2, is Tueasday your favourite day of the week and February your favourite month?");
        break;
    case 3:
        Console.WriteLine("Your favourite number is 3, is Wednesday your favourite day of the week and March your favourite month as well?");
        break;
    case 4:
        Console.WriteLine("Your favourite number is 4, I have many questions");
        break;
    case 5:
        Console.WriteLine("Your favourite umber is 5, I hope you get great grades at school");
        break;
    case 6:
        Console.WriteLine("Your favourite number is 6, is Saturday your favourite day of the week and June your favourite month?");
         break;
    case 7: Console.WriteLine("Your favourite number is 7, is Sunday your favourite day of the week?? :o");
        break;
    case 8:
        Console.WriteLine("Your favourite number is 8, there are no days of the week I can assume are your favourite but you must like August quite much");
        break;
    case 9:
        Console.WriteLine("I'm glad you like nines, you must love September");
        break;
    case 10:
        Console.WriteLine("10 is a weird number to see as your favourite one but someone's got to like it, right? Maybe you like Halloween as well");
        break;
    default:
        Console.WriteLine("YOU WERE SUPPOSED TO INPUT A NUMBER BETWEEN 1 AND 10, TRY AGAIN");
        break;
}
//while loop
while(favNumber<=100)
{
    Console.WriteLine("Enter a number you want to add: ");
    int add = Convert.ToInt32(Console.ReadLine());
    favNumber += add;
    Console.WriteLine("Sum: "+favNumber.ToString());
}
Console.WriteLine("You've reached the limit, the sum is larger than 100!");
//do while loop
do
{
    Console.WriteLine("Enter a number you want to substract");
    int subs= Convert.ToInt32(Console.ReadLine());
    favNumber -= subs;
    Console.WriteLine("Sum: "+favNumber.ToString());

} while (favNumber>=1);
Console.WriteLine("You've reached 0 or a number below 0.");

//for loop
Console.WriteLine("Enter a number you want to add: ");
int add1 = Convert.ToInt32(Console.ReadLine());
int x = 0;
for (int i=favNumber;i<100;i+=(add1))
{
    x++;
    Console.WriteLine("You've added the number "+x+" times.");
}
Console.WriteLine("You've reached 100, you can try again.");

//foreach loop and arrays

string[] months = {"January","February","March","April","May","June","July","August","September","October","November","December" };
foreach (string month in months)
{
    int num = 1;
    Console.WriteLine("Month : "+ month);
    
}

//break and continue in for loop 

int start = -20;
for (int i=0;i<1000;i++)
{
    Console.WriteLine("Enter a number to add: ");
     int number = Convert.ToInt32(Console.ReadLine());
    start += number;
    if(start==600)
    {
        break;
    }


}
Console.WriteLine("Congratulations, the sum of the numbers you added equals exactly 600! You've escaped the loop");

int start1 = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter a number to add: ");
    int number = Convert.ToInt32(Console.ReadLine());
    start1 += number; 
    if (start1 == 50)
    {
        continue;
    }
    Console.WriteLine("great job! " + start1.ToString());
    
}
Console.WriteLine("If at any point, the sum of the entered numbers equaled 50, you wouldn't have gotten the \"great job\" message ");

//break and continue in while loop

int start6 = 0;
int b= 0;
while (b<10)
{
    Console.WriteLine("Enter a number to add: ");
    int number = Convert.ToInt32(Console.ReadLine());
    start6 += number;
    if (start6 == 60)
    {
        continue;
    }
    b++;
    Console.WriteLine("Sum: " + start6.ToString());

}
Console.WriteLine("Finish");
