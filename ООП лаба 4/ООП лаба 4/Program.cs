using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_лаба_4
{
    public class Paper
    {
        public string Type { get; set; }
        public string Color { get; set; }




        public Paper(string type, string color)
        {
            Type = type;

            Color = color;
        }
        public void Fold()
        {
            Console.WriteLine("Складываем бумагу");
        }
        public void Print()
        {
            Console.WriteLine("напечатанный текст");
        }
        public override string ToString()
        {
            return String.Format("{0} , {1}", Type, Color);
        }
    }
    public class Notebook : Paper
    {
        public int Pagenumber { get; set; }
        public string Typenotebook { get; set; }

        public Notebook(string type, string color, int pagenumber, string typenotebook) : base(type, color)
        {
            Type =type;
            Color =color;
            Pagenumber = pagenumber;
            Typenotebook = typenotebook;
        }

        public void Writter(string text)
        {
            Console.WriteLine("Написанный текст в тетради-" + text);
        }
        public void DeletePage(int page)
        {
            Console.WriteLine("Вырываем страницу -" + page);
        }
        public override string ToString()
        {
            return String.Format("{0} , {1}, {2}, {3}", Type, Color, Pagenumber, Typenotebook);
        }
    }
        public class Wallpaper : Paper
        {
            public double Length { get; set; }
            public double Width { get; set; }
        public Wallpaper(double length, double width, string type, string color) : base(type, color)
        {
                Length = length;
                Width = width;
            }
            public void Cut()
            {
                Console.WriteLine("Вырезаем обои");
            }
            public void Gluing()
            {
                Console.WriteLine("Наклеивать обои ");
            }
            public override string ToString()
            {
                return String.Format("{0} , {1}, {2}, {3}", Type, Color, Length, Width);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Paper p = new Paper("A4", "Белый");
                Console.WriteLine(p.ToString());
                p.Fold();
                p.Print();
                Notebook n = new Notebook("A4","blue",24, "В клетку");
                Console.WriteLine(n.ToString());
                n.Writter("weasgdga");
                n.DeletePage(3);
                Wallpaper w = new Wallpaper(1.8,0.5,"A5","blue");
                Console.WriteLine(w.ToString());
                w.Cut();
                w.Gluing();
                Console.ReadKey();
            }
        }
    
}
