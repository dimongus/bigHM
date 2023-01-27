# Итоговая проверочная работа #

 ### Условие:

* Создать репозиторий на GitHub
* Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
* Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
* Написать программу, решающую поставленную задачу
* Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

 #### Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


 ## <span style="color:#00FFFF">  Решение: 

1) Задаем массив на старте выполнения
2) Воспользуемся конструкцией [switch](https://metanit.com/sharp/tutorial/3.45.php ) 
3) Напишем код:


``` 
 Console.WriteLine();
    Console.WriteLine("Выберите массив:");
    Console.WriteLine("1  массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2  массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3  массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
string[] array = new string[] {};
```

```
string command = ReadInput("Введите команду: ");
switch (command)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{command} - Такой команды нет");
        break;
}
```
```
int lenghtArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenghtArray++;
}
```
```
string[] newArray = new string[lenghtArray];
int count = 0;
```
```
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}
```
```
PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);
```

```
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
```
```
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
```
4) Во время выполнения работы не забываем делать commit
![](https://github.com/dimongus/bigHM/blob/main/pict/2.png)

5) Составим алгоритм:
![](https://github.com/dimongus/bigHM/blob/main/pict/%D0%91%D0%B5%D0%B7%D1%8B%D0%BC%D1%8F%D0%BD%D0%BD%D1%8B%D0%B9.png)