int errorCount = 0;

l1:

Console.WriteLine("input 1 :");
string input = Console.ReadLine();
Console.WriteLine("input 2 :");
string input2 = Console.ReadLine();


bool state = int.TryParse(input, out int inputNum);
bool state2 = int.TryParse(input2, out int inputNum2);


if(!state || !state2)
{
    Console.WriteLine("Sehv daxil edilib !");
    errorCount++;

    if(errorCount > 5)
    {
        Console.WriteLine("Sehv limitini kecmisiz !");
    }
    else
    {
        goto l1;
    }
    
    
}




