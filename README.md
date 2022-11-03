# VerificationWork
# Итоговая проверочная работа

   ##  1. Создать репозиторий на GitHub
---
>**Решение**

Создан репозиторий

[Адрес]  https://github.com/OVK1976/VerificationWork.git

---
## 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
----
>**Решение**

<u>Алгоритм решения:</u>
1. Задаем исходный массив. Значения вводим с клавиатуры.

2. Создаем новый массив. Длину массива определяем из количества значений, соотвествующих условию.

3. Перебираем значения из исходного массива

4. Проверяем каждое значение из массива на соответствие условию: длина строки меньше или равна трем.

5. Если строка удовлетворяет условию кладем значение в новый массив

6. Повторяем п. 3 - 5 до тех пор пока не достигнем конца исходного массива
7. Выводим результат: исходный массив -> новый массив.

![Алгоритм решения](../../../../../../../../C:/%D0%94%D0%BE%D0%BA%D1%83%D0%BC%D0%B5%D0%BD%D1%82%D1%8B%20%D0%9E%D0%BB%D0%B5%D0%B3/%D0%AF%20%D0%B1%D1%80%D0%B5%D0%BD%D0%B4/%D0%9E%D0%B1%D1%83%D1%87%D0%B5%D0%BD%D0%B8%D0%B5/%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5/1%20%D1%87%D0%B5%D1%82%D0%B2%D0%B5%D1%80%D1%82%D1%8C/%D0%98%D1%82%D0%BE%D0%B3%D0%BE%D0%B2%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%B0%201-3/VerificationWork/%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC%20%D1%80%D0%B5%D1%88%D0%B5%D0%BD%D0%B8%D1%8F.jpg)
-----
    ## 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
--------
>**Решение**

> Файл README.md создан. Размещен в репозитории.
---------

## 4. Написать программу, решающую поставленную задачу
---
>**Решение**
---
## 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
---
>**Решение**


---
### **Задача**: 
_Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._

### Примеры:

>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

>[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

>[“Russia”, “Denmark”, “Kazan”] → []