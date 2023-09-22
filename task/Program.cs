/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

string []str = {"1234", "1567", "-2", "computer science"};
Console.WriteLine("[{0}]",string.Join(",",str));

string[] r = ResultArray(str);
Console.WriteLine("[{0}]",string.Join(",",r));

string[] ResultArray(string []str){
    int size = 0;
    foreach(string s in str){
        if(s.Length <= 3){
            size++;
        }
    }
    string[] resultarray = new string[size];
    int i = 0;
     foreach(string s in str){
        if(s.Length <= 3){
           resultarray[i] = s;
           i++;
        }
    }
    return resultarray;
}

