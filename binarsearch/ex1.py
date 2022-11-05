from random import randint   # генерация случайного числа
x=randint(0,100)
# метод последовательного перебора
count_perebor=0

for i in range(0,101):
    count_perebor+=1
    if i==x:
        print("число найдено!")
        break

print("загаданное число было ",x, "и для его поиска перебором потребовалось итераций", count_perebor)

# метод случайного отгадывания
count_random=1

y=randint(0,100)
while x!=y:
    y=randint(0,100)
    count_random+=1

print("загаданное число было ",x, "и для его поиска угадыванием потребовалось итераций", count_random)

#метод бинарного отгадывания
count_binar=1
print("Давай начнём игру - угадай число от 0 до 100")
y=int(input("Введите число"))
while x!=y:
   if x<y: print("искомое число меньше")
   else: print("искомое число больше")
   y=int(input("Введите число"))
   count_binar+=1
print("загаданное число было ",x, "и для его поиска бинарным алгоритмом потребовалось итераций", count_binar)



