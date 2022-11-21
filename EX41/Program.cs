 // Пользователь вводит с клавиатуры M чисел. 
 // Посчитайте, сколько чисел больше 0 ввёл пользователь.

bool check = false;
int count = 0;
int number = 0;
string inputEnd = string.Empty;
Console.WriteLine("Enter numbers separated by an 'Enter'");
Console.WriteLine("For the end of input, enter 'end'");
while(check == false)
{
    inputEnd = Console.ReadLine();
    if(inputEnd == "end")
    {
        check = true;
    }
    else
    {
        number = Convert.ToInt32(inputEnd);
        if(number > 0)
        {
            count++;
            //Console.WriteLine($"Count = {count}");
        }
    }
}
Console.WriteLine($"Count = {count}");