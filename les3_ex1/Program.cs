// сортировка ВЫБОРОМ
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // перевод символа в число
int[] array = new int[n];
//Заполнение массива
for (int i = 0; i < n; i++)
{   
    Console.Write("Введите число массива ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("начальный массив : [" + string.Join(", ", array) + "]");
//Сортировка
for (int i = 0; i < n - 1; i++)    // n-1 т.к. последний элемент сравнивать не нужно
{
int MinIndex = i;
for (int j = i + 1; j < n; j++)  // i + 1 , чтобы не сравнивать одно и то же число
{
    if(array[j] < array[MinIndex])
    MinIndex = j;   // номер! минималього элемента
    Console.WriteLine(" массив : [" + string.Join(", ", array) + "]");
}
int temp;
temp = array[MinIndex];
array[MinIndex] = array[i];
array[i] = temp;
Console.WriteLine(" массив2 : [" + string.Join(", ", array) + "]");
}
Console.WriteLine("конечный массив : [" + string.Join(", ", array) + "]");