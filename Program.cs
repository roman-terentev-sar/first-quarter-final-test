
Console.WriteLine("Введите несколько слов в одну строчку");
string s = Console.ReadLine();
string[] stringArray = s.Split(' ');
for(int i = 0; i< stringArray.Length; i++)
{
    if(stringArray[i].Length<=3)
    {
        Console.Write(stringArray[i] + " ");
    }
}