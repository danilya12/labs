using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int x;
        public int y;
        public string sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }

        public void SetSym(string symbol)
        {
            sym = symbol;
        }
        public void Draw(string sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Point a = new Point

            {
                x = 1,
                y = 2,
            };

            a.Draw("----");
            Point b = new Point
            {
                x = 1 + 1,
                y = 2 + 1,
            };
            b.Draw("##--");
            Point c = new Point
            {
                x = 1,
                y = 2 + 2,
            };
            c.Draw("----");
        }
    }
}