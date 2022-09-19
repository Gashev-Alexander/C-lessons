# Треугольник Серпинского на python
"""
    Функция: Нарисуйте треугольник Серпинского
         Окружение: python3.7
         Дата: 2019/1/14 21:49
         Автор: волшебник кончиками пальцев
         Версия: 1.0
"""
import turtle as t
 
 
def sanjiaoxing(san):
    """
         Передайте координаты трех точек и нарисуйте треугольник
    """
    t.penup()
    t.goto(san[0])
    t.pendown()
    t.goto(san[1])
    t.goto(san[2])
    t.goto(san[0])
 
 
def get_mid(a, b):
    """
         Рассчитать координаты средней точки, вернув 2 точки
    """
    x = (a[0] + b[0]) / 2
    y = (a[1] + b[1]) / 2
    return [x, y]
 
 
def draw_san(size, i):
    """
         Нарисуйте функцию треугольника Серпинского
         : размер параметра: список трехточечных координат
         : param i: время рекурсии
    """
         # Нарисовать треугольник
    sanjiaoxing(size)
    if i > 0:
                 # Нарисуйте маленький треугольник слева
        size2 = [size[0], get_mid(size[0], size[1]), get_mid(size[0], size[2])]
        draw_san(size2, i - 1)
 
                 # Нарисуйте верхний треугольник
        size3 = [get_mid(size[0], size[2]), get_mid(size[1], size[2]), size[2]]
        draw_san(size3, i - 1)
        
                 # Нарисуйте маленький треугольник справа
        size4 = [get_mid(size[0], size[1]), size[1], get_mid(size[1], size[2])]
        draw_san(size4, i - 1)
 
 
def main():
    """
         Основная функция
    """
         # Распечатать графическое название
    t.penup()
    t.left(90)
    t.forward(350)
    t.pendown()
         t.write ("Треугольник Серпинского", False, выровнять = "center", font = (" ", 20, "normal"))
    t.speed(5)
 
         # Начальные координаты треугольника
    points = [[-200, 0], [200, 0], [0, 300]]
         # Рекурсия 5 раз
    count = 5
         # Вызовите функцию треугольника Серпинского
    draw_san(points, count)
 
    t.exitonclick()
 
 
if __name__ == '__main__':
    main()