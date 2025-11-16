using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _511_oop
{
    
        public class Rectangle
        {
            private double _width;
            private double _height;

            public double Width
            {
                get
                {
                    return _width;
                }
                set
                {
                    if (value > 0)
                    {
                        _width = value;
                    }
                    else
                    {
                        Console.WriteLine("ощибка ширина должна быть положительным числом");
                    }
                }
            }
            public double Height
            {
                get
                {
                    return _height;
                }
                set
                {
                    if (value > 0)
                    {
                        _height = value;
                    }
                    else
                    {
                        Console.WriteLine("ощибка высота должна быть положительным числом");
                    }
                }
            }

            public Rectangle(double width, double height)
            {

                Width = width;
                Height = height;
            }
            public double GetArea()
            {
                return _width * _height;
            }
            public double GetPerimeter()
            {
                return 2 * (_width + _height);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("--- Создаём корректный прямоугольник");
                Rectangle rect1 = new Rectangle(-10, 0);
                Console.WriteLine($"Ширина: {rect1.Width}");
                Console.WriteLine($"высота:{rect1.Height}");
                Console.WriteLine($"площадь:{rect1.GetArea()}");
                Console.WriteLine($"периметер:{rect1.GetPerimeter()}");
                Console.WriteLine("\n---попытка создать некорретный прямоугольник");
            Rectangle rect2 = new Rectangle(-10, 0);
            Console.WriteLine($"Ширина rect2:{rect2.Width}");
            Console.WriteLine($"высота rect2:{rect2.Height}");
            Console.WriteLine($"\n--- Попытка изменить свойство на некорректное значение ---");
            rect1.Width = -20;
            Console.WriteLine($"новая ширина rect1 после попытки изменения: {rect1.Width}");
            Console.ReadLine();
            }
        }
    }
