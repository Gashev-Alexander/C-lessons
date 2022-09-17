# ``Lesson 1``
Любой код, который написан после двух обратных («//») слэшей называется «комментарием к коду»

## DotNet command
* Dotnet new console — эта команда нужна, чтобы создать новый проект.
* Dotnet run — эта команда нужна, чтобы запустить проект. Позднее я покажу, что будет, если у 
вас возникают какие-то ошибки, как нужно будет действовать и каким образом их чинить.
* Через Console мы обращаемся к окну терминала.
* С помощью «WriteLine» можем в консоли данные выводить.

## Пишем программу
* Сonsole.Reаd Line - с её помощью происходит считывание данных. 
* WriteLine - вывод в консоль с переходом на новую строку.
* Write - это вывод в консоль без перехода на новую строку. 
* ReadLine - позволяет считывать данные из нашего терминала.
* контейнер «integer», позволяет работать с целыми числами
* контейнер «double», позволяет работать с вещественными числами.

## Типы данных
* Типы данных integer и double
На этом этапе вы должны были запомнить целый тип данных (integer) и вещественный тип данных 
(double). Обратите внимание, что типы данных различаются не только по возможности хранить 
вещественные числа, но и по объёму памяти, который занимают. Если целые числа позволяют хранить 
диапазон от -2 147 483 648 до 2 147 483 647, то тип «double» может хранить числа от ±5,0 × 10-324 до 
±1,7 × 10308. Это очень большие значения и, скорее всего, на начальных этапах они вам не понадобятся. 
* Тип данных string
Также важно помнить, что есть строки (тип данных «string»). Он может содержать от 0 (это называется 
пустой строкой) до большого количества символов, в общем случае до 2 Гб. Это много. Для сравнения, 
например, один том «Война и мир» весит около 13 Мб, хотя, возможно, это вес всех книг серии «Война 
и мир». То есть строки могут быть очень и очень большими. 
* Тип данных bool 
Четвёртый тип данных, с которым нужно познакомиться на старте, это логический тип данных. Он 
записывается, как bool и позволяет хранить только 2 значения: либо истина, либо ложь. Попробуем 
познакомиться с ним в следующем проекте.

## Операторы для арифметических действий в С#
Классические арифметические операции в языке С# определяются следующими операторами:
* '+' — плюс 
* '-' — минус
* '/' — прямой слэш
* '*' — умножение
* '%' — значок процента (означает нахождение остатка от деления)
* '( )' — классические скобки, которые могут менять приоритет операций



# Список папок и описание внутренних программ
* lesson1 программа приветствия
* lesson1.1 и python1 программа приветствия после ввода имени пользователя
* lesson1.2 и python1.1 программа нахождения суммы двух числе
* lesson1.3 и python1.2 программа для вычисления частного двух чисел
* lesson1.4 программа деления с вещественными числами
* lesson1.5  и python1.4 программа именного приветствия
* lesson1.6 и python1.3 программа решения задачки с гирями
* lesson1.7 и python1.5 Треугольник Серпинского


# ``Домашнее задание #1``
* ``Задача 1``: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

  a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

* ``Задача 4``: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

  2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

* ``Задача 6``: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

  4 -> да
-3 -> нет
7 -> нет

* ``Задача 8``: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

  5 -> 2, 4
8 -> 2, 4, 6, 8



# ``Lesson 2``

![Фунцкии в программировании](https://ibb.co/PCTFmXW)