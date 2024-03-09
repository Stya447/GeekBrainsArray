## Итоговая контрольная работа по основному блоку

### Описание
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []


### Решение
1. Для начала создаем метод, который будет возвращать массив строк и называем его соответствующе GetElementsWithLengthEqualsOrLessThan3.
В нем мы создаем новый массив newArgs, в который будут записывать все элементы массива, подходящие по условию.
2. Создаем счетчик counter, с помощью которого мы будем перемещаться по новому массиву.
3. Далее, с помощью цикла начинаем перебирать отданный нам в параметрах массив args. Сравниваем каждый элемент по условию, обозначенному нам задачей.
Если строка проходит по условию, то мы записываем ее в новый массив и увеличиваем счетчик соответственно.
4. После того как все шаги по фильтрации массива были выполнены, с помощью еще одного цикла for выводим список получившихся элементов в консоль, а затем возвращаем новый массив.

### Блок схема
![image](https://github.com/Stya447/GeekBrainsArray/assets/138287416/cbbb15a7-a113-4f5a-94a3-7f7d7730fb6a)

### Результат работы программы

![image](https://github.com/Stya447/GeekBrainsArray/assets/138287416/590647b3-8f9c-4857-96b7-33c8bfc4ff21)
