/*Быстрая сортировка  как правило сложность n * log n
3 шага:
1. полуение массива [1, 0 , -6 , 2, 5, 3 , 2]
2. выбор опорного элемента(pivot), либо первый, либо последний, мы выбрали последний  arr[2](индекс 6)
3. все элементы меньше опорного должны стоять слева от него, а бОльшие справа
затем берем подмассив справа и слева от опорного и выполняем тоже самое с подмассивами. 
*/
 int[] arr = {0, -5, 2, 3 ,5 ,9 ,-1, 7};
 int[] res = QuickSort(arr, 0 , arr.Length - 1);
 Console.Write($"итоговый массив {string.Join(",", res)}");
int[] QuickSort(int[] inputArray, int minIndex, int maxIndex)
 {
    if(minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray,pivot + 1, maxIndex );
    return inputArray;
 }
 int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
 {
   int pivotIndex = minIndex - 1;
   for (int i = minIndex; i < maxIndex; i++)
   {
    if(inputArray[i] < inputArray[maxIndex])
    {
      pivotIndex++;
      Swap(inputArray, i, pivotIndex);
    }
   }
   pivotIndex++;
   Swap(inputArray,pivotIndex, maxIndex);
   return pivotIndex;
 }
void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}