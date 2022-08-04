
string[] array = new string [5];

for ( int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите массив");
    array[i] = Console.ReadLine()!;
}
for ( int i = 0; i < array.Length; i++)

{
    Console.Write(array [i] + "\t");
    
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Массив, содержащий 3 символа: ");
for ( int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i] + "\t" );
    }
    
}