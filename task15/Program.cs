int a = int.Parse(Console.ReadLine());

while(a>7 || a<1){
    Console.WriteLine("Введите число 1..7 :");
    a = int.Parse(Console.ReadLine());
}

if(a<=5){
    Console.WriteLine("нет");
}else Console.WriteLine("да");