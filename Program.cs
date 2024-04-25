double Result = 0;
Console.Write("Введите число A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите действие: ");
string Deistvie = Console.ReadLine();
if (Deistvie == "+")
{
    Result = A + B;
}
else if (Deistvie == "-")
{
    Result = A - B;
}
else if (Deistvie == "*")
{
    Result = A * B;
}
else if (Deistvie == "/")
{
    Result = A / B;
}
Console.WriteLine(Result);