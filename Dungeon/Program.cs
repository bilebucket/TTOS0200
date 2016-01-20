using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.run();
        }
    }

    class Hero
    {

        private int x, y;

        public Hero(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void move(int dx, int dy)
        {
            int nx = this.x + dx, ny = this.y + dy;
            if (nx > 0 && nx < Game.CONSOLE_WIDTH && ny > 0 && ny < Game.CONSOLE_HEIGHT)
            {
                this.x += dx;
                this.y += dy;
            }
        }

        public void draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(this.x, this.y);
            Console.Write("@");
            Console.ResetColor();
        }
    }

    class Game
    {
        public static int CONSOLE_WIDTH = 80;
        public static int CONSOLE_HEIGHT = 24;

        Hero pc;

        public Game()
        {
            this.pc = new Hero(4, 4);
            Console.CursorVisible = false;
        }

        private bool readInput()
        {
            ConsoleKeyInfo c = Console.ReadKey();
            string key = c.KeyChar.ToString().ToLower();
            switch (key)
            {
                case "w":
                    pc.move(0, -1);
                    break;

                case "s":
                    pc.move(0, 1);
                    break;

                case "a":
                    pc.move(-1, 0);
                    break;

                case "d":
                    pc.move(1, 0);
                    break;  
            }

  
            if(c.Key == ConsoleKey.Escape)
            {
                return false;
            }
            return true;
        }


        private void draw()
        {
            Console.Clear();
            for (int i = 0; i < CONSOLE_WIDTH+1; i++)
            {
                for (int k = 0; k < CONSOLE_HEIGHT+1; k++)
                {
                    if(i==0 || i == CONSOLE_WIDTH || k==0 || k== CONSOLE_HEIGHT)
                    {
                        Console.SetCursorPosition(i, k);
                        Console.Write("#");
                    }
                }
            }
            pc.draw();
        }


        public void run()
        {
            this.draw();
            while (this.readInput())
            {
                this.draw();
            }
        }
    }
}
