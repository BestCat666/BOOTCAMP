#метод бинарного поиска2
from random import randint   # генерация случайного числа
x=randint(0,100)
count_bin2=1
print("Давай начнём игру - угадай число от 0 до 100")
left=0
right=100
mid=(left+right)//2
while x!=mid:
    print(mid)
    if x<mid: 
        print("искомое число меньше")
        right=mid-1
    else: 
        print("искомое число больше")
        left=mid+1
    mid=(left+right)//2
    count_bin2+=1
print("загаданное число было ",x, "и для его поиска бинарным алгоритмом потребовалось итераций", count_bin2)