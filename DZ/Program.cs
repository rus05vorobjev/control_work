Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

string [] Arr = new string [number];
void array(string [] Arr)
{
  for (int i = 0;i<Arr.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     Arr[i] = Console.ReadLine();
  }
}

string [] symbol(string [] Arr)
{
  int n = 0;
  for (int i = 0;i<Arr.Length;i++)
  {
    if(Arr[i].Length <=3)
    n++;
  }
  string [] result = new string [n];
  int j = 0;
  for (int i = 0;i<Arr.Length;i++)
  {
    if(Arr[i].Length <=3)
    {
        result[j] = Arr[i];
        j++;
    }
  }
  return result;
} 

void print(string [] Arr)
{
    Console.Write("[");
    for (int i = 0;i<Arr.Length;i++)
    {
    Console.Write($"‘{Arr[i]}’, ");
    }
    Console.Write("]");
}
array(Arr);
print(symbol(Arr));