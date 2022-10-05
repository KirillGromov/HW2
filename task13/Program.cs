
int a = int.Parse(Console.ReadLine());

//int num = a.length;
int a1 = a%100;

if(a1 == a){
    //Console.WriteLine(a);
    Console.WriteLine("третьей цифры нет");
}else if( (a>99) && (a<1000) ) {
    int a2 = a%100;
    a2 = a2%10;
    Console.WriteLine(a2);
}else{
    while(a>1000){
        a = a/10;
    }
    a = a%10;
    Console.WriteLine(a);
}

//Console.WriteLine(a);