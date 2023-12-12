string snack = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
double result = 0;
if (snack == "water")
{
    result = 1.00;
}
else if (snack == "coke")
{
    result = 1.40;
}
else if (snack == "cofee")
{
    result = 1.50;
}
else if (snack == "snacks")
{
    result = 2.00;
}
double totalCost = result * n;
Console.WriteLine(totalCost.ToString("F2"));