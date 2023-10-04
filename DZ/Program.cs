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