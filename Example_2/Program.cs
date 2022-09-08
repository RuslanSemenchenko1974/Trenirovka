// Преобразует десятичное число в двоичный код
Console.WriteLine("Введите число");
int namber=Convert.ToInt32(Console.ReadLine());
int chastnoe=namber;
int binary=0;
int sizeBinary=0;
int[] binaryArr = new int[100];
int count=0;
Console.Write("Binary:");
while (chastnoe>0)
{
    chastnoe=(namber/2);
    binary=namber-chastnoe*2;
    binaryArr[count]=binary;
    count++;
    //Console.Write($" {binary}");
    namber=chastnoe;
}
sizeBinary=count-1;
//Console.Write("binary :");

    for (count = 0; count <= sizeBinary; count++)
{
    Console.Write(binaryArr[sizeBinary-count]);
}
