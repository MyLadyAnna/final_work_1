# First final work
## Задание:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма решения:
Объявляется два массива: изначальный *(array1)* и второй *(array 2)* такой же длины. Потом вызывается метод **FirstArrayInSecond** (описан выше объявления переменных), в котором присутствует цикл *for* действующий до длины 1 массива, внутри цикла проводится проверка условия (длина i-го элемента <=3), если ответом будет **«да»**, то элемент первого массива (array1[i])  заносится в *count* элемент второго массива (array2[count]), прибавляется *count* и программа возвращается к циклу *for*, в котором *i* также увеличивается на 1. Если ответом на проверку условия в цикле *if* будет **нет**, то просто прибавляется *i* и проверяется следующий элемент в 1 массиве. Как только цикл *for* пройдёт по всему массиву работа метода закончится.
Затем вызывается метод **PrintArray**, который печатает 2 массив (в этот массив мы копировали все элементы из 1, которые соответствовали условию (длина i-го элемента <=3)).

В блок-схеме описан основной метод *FirstArrayInSecond*. Найти блок-схему вы можете в папке **block_diagram**.
Программу для решения задачи вы найдёте в папке **program**, файл **Program.cs**.
