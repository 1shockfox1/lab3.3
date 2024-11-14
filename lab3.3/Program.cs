try
{
    Console.WriteLine("введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите кол-во повторений: ");
    double n = double.Parse(Console.ReadLine());
    double s = 0;
    double fact = 1; 
    double step = 1; 
    for (int i = 1; i <= n; i += 2) 
    {
        
        fact *= i;
        step *= (2 * x);
        s += step / fact;

    }
    Console.WriteLine($"Сумма первых {n} членов ряда: {s}");
}
catch (Exception e)
{
    Console.WriteLine("ошибочка 404....");
}