
int a = int.Parse(Console.ReadLine());

if(a<0){
    a *= -1;
}

int a1 = a;

a = a/10;
a = a%10;

Console.WriteLine(a);