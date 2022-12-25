# FinalWork
## Задача:
>Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться библиотеками, лучше обойтись исключительно массивами. 
## Описание программы:
>Объявляется первый пустой массив. Далее предлагается ввести кол-во строк, т.е. определяется размер первого массива. Необходимо ввести числовое значение размера массива, если вводится недопустимое значение, в консоле выводится соответствующее сообщение и происходит выход из программы. После происходит ввод строк под нумерацию, происходит заполнение первого массива. 

>Следующим этапом происходит объявление второго массива размер которого равен первому. Далее идет метод FinalArray. В нем объявляется переменная count = 0, которая отвечает за поочередную запись во второй массив элементов из первого массива, которые соответствуют условию в цикле. Цикл равен длине первого массива. Внутри цикла происходит проверка элементов массива на кол-во символов <= 3 если да, то i-ый элемент первого массива заносится в count элемент второго массива.  После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.

>Метод PrintArray позводяет вывести в консоль элементы выбранного массива. В нашем случае это второй массив.

### Блок схема основного алгоритма в папке BlokShema
### Путь к программе FinalWork/Program.cs
