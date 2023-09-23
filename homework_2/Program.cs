Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b){
    Console.Write($"Наибольшее число - {a}");
}
else {
    Console.Write($"Наибольшее число -{b}");
}
