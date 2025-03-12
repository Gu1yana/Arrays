//int num = 7891;

//int max = 0;
//int x;
//while (num > 0)
//{
//    x = num % 10;
//    if (x > max)
//    {
//        max = x;
//    }
//    num /= 10;
//}
//Console.WriteLine(max);



//int eded = 0;

//if (eded > 0)
//{
//    while (eded % 2 == 0)
//    {
//        eded /= 2;
//    }
//}
//if (eded == 1)
//{
//    Console.WriteLine("2 nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("2 nin quvveti deyil");
//}



//int[] arr = { 55, 123, 4, 5, 3, 4 };
//int max = arr[0];
//int min = arr[0];

//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//for (int j = 1; j < arr.Length; j++)
//{
//    if (arr[j] < min)
//    {
//        min = arr[j];
//    }
//}
//Console.WriteLine($"minimum ve maksimum ededin cemi: { min + max}");



int[] arr = { 3, 12, 6, 18, 81 }; 
int say = 0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 3 == 0 && arr[i] % 2 == 1)
    {
        say++;
    }
Console.WriteLine($"3e bolunen ve tek ededlerin sayi:{say}");