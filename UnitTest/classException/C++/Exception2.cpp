#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    double a, b, result;

    try
    {
        cout << "Первое число: ";
        cin >> a;
        cout << "Второе число: ";
        cin >> b;
        if (b == 0) {
            throw "Деление на ноль невозможно\n";
        }
        else throw a, b;
    }
    catch (const char* exception)
    {
        cerr << "Ошибка: " << exception << endl;
    }
    catch (double dbeer)
    {
        cerr << "\nНеверное значение" << endl;
    }
    catch (exception& e)
    {
        cout << e.what();
    }
    catch (invalid_argument)
    {
        cerr << "ошибка операции 0" << endl;
    }
    cout << "Размер типа данных int = " << sizeof(int) << " bytes" << endl;
    cout << "Размер типа данных float = " << sizeof(float) << " bytes" << endl;
    cout << "Размер типа данных char = " << sizeof(char) << " bytes" << endl;

    return 0;
}