int a = int.Parse(Console.ReadLine()!); //a = -6
int count = -a; //count = 6
Console.WriteLine(count);
while (count!=a){
if (a<0)
count--;//count=count+1
else
count++;//count=count-1
Console.WriteLine(count);
}
