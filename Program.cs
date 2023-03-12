Console.WriteLine("Задай размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomNumbers = new int[size];

void arr(int size)
{
     for (int i = 0; i < size; i++)
{
     randomNumbers[i] = new Random().Next(1,9);
     Console.Write(randomNumbers[i] + " ");
}
}

int count(int[] randomNumbers)
{
    int sum = 0;
    int i = 0;
    
while (i < randomNumbers.Length)
{
    sum = sum + randomNumbers[i];
    i = i + 2;
}
return sum;
}

arr(size);

Console.Write($"Cумма элементов, стоящих на нечётных позициях: {count(randomNumbers)}");