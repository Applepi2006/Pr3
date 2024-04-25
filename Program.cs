Console.Write("Введите число A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите действие: ");
string Deistvie = Console.ReadLine();
if (Deistvie == "+")
{
    Console.WriteLine(plus(A,B));
}
//else if (Deistvie == "-")
//{
//    Console.WriteLine(minus(A, B));
//}
//else if (Deistvie == "*")
//{
//    Console.WriteLine(umnozhit(A, B));
//}
//else if (Deistvie == "/")
//{
//    Console.WriteLine(delit(A, B));
//}
double plus(double A, double B)
{
    return (A + B);
}
//double minus(double A, double B)
//{
//    return (A - B);
//}
//double umnozhit(double A, double B)
//{
//    return (A * B);
//}
//double delit(double A, double B)
//{
//    return (A / B);
//}