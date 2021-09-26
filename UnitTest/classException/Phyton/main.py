import sys

try:
    print("Первое число: ")
    a = float(input())

    print("Второе число: ")
    b = float(input())

    result = a / b
    print("Результат " + str(result))
except Exception as ex:
    print("Ошибка " + str(ex))

print("Размер типа данных int: " + str(sys.getsizeof(int())) + " bytes")
print("Размер типа данных float: " + str(sys.getsizeof(float())) + " bytes")