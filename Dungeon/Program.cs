/*
WARNING: This program is horrible hacked together frankenstein of a game. Pretty much nothing was planned in advance, I take absolutely NO responsibility over
what effects running this code might cause on your computer! I also want to say that you should in no situation use this code as an example of any kind, other than
AWFUL CODE. It would probably be best if you stopped reading after this comment.

IF YOU FIND THIS FILE/CODE ON YOUR COMPUTER YOU SHOULD REMOVE THIS FILE IMMEDIATELY.


TODO: Implement an object class that all level objects (player, monsters etc.) will subclass.
*/

using System;
using System.Collections.Generic;
using System.Collections;
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

    class Fighter
    {
        private readonly int maxHealth;

        private int health;
        private int att, def;
        private bool alive = true;
        public Fighter(int maxHealth, int attack, int defence)
        {
            this.maxHealth = maxHealth;
            this.health = maxHealth;
            this.att = attack;
            this.def = defence;
        }

        public void takeDamage(int amount)
        {
            this.health -= amount;
            if(health < 0)
            {
                this.alive = false;
                Game.GameMessage = "Something dies!";
            }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public bool Alive
        {
            get { return this.alive; }
            set { this.alive = value; }
        }

        public void attack(Fighter target)
        {
            int amount = (Game.BASE_DAMAGE * this.att) - target.def;
            Game.GameMessage = amount + " dmg done!";
            target.takeDamage(amount);
        }
    }

    class Goblin
    {
        public Fighter fighter;
        private int x, y;
        public Goblin(int x, int y)
        {
            this.fighter = new Fighter(8, 1, 1);
            this.x = x;
            this.y = y;
        }


        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }


        public void draw()
        {
            if (this.fighter.Alive)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(this.x, this.y);
                Console.Write("G");
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(this.x, this.y);
                Console.Write("%");
                Console.ResetColor();
            }
           
        }
    }

    class Hero
    {

        private int x, y;
        public Fighter fighter;

        public Hero(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.fighter = new Fighter(10, 2, 2);
        }

        public void move(int dx, int dy, ArrayList goblins)
        {
            int nx = this.x + dx, ny = this.y + dy;

            foreach(Goblin g in goblins)
            {
                if(nx == g.X && ny == g.Y && g.fighter.Alive)
                {
                    this.fighter.attack(g.fighter);
                    return;
                }
            }

            if (nx > 0 && nx < Game.DUNGEON_WIDTH && ny > 0 && ny < Game.DUNGEON_HEIGHT)
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
            Console.SetCursorPosition(0, 25);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("HP: " + this.fighter.Health);
            Console.ResetColor();
        }
    }

    class Game
    {
        public static int DUNGEON_WIDTH = 48;
        public static int DUNGEON_HEIGHT = 24;
        public static int BASE_DAMAGE = 2;

        private ArrayList goblins = new ArrayList();

        private static string gameMessage = "You fall through a trap door to a damp dungeon.";

        Hero pc;

        public Game()
        {
            goblins.Add(new Goblin(10, 10));
            this.pc = new Hero(4, 4);
            Console.CursorVisible = false;
        }

        public static string GameMessage
        {
            get { return gameMessage; }
            set { gameMessage = value; }
        }

        private bool readInput()
        {
            ConsoleKeyInfo c = Console.ReadKey();
            string key = c.KeyChar.ToString().ToLower();
            switch (key)
            {
                case "w":
                    pc.move(0, -1, goblins);
                    break;

                case "s":
                    pc.move(0, 1, goblins);
                    break;

                case "a":
                    pc.move(-1, 0, goblins);
                    break;

                case "d":
                    pc.move(1, 0, goblins);
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
            for (int i = 0; i < DUNGEON_WIDTH+1; i++)
            {
                for (int k = 0; k < DUNGEON_HEIGHT+1; k++)
                {
                    if(i==0 || i == DUNGEON_WIDTH || k==0 || k== DUNGEON_HEIGHT)
                    {
                        Console.SetCursorPosition(i, k);
                        Console.Write("#");
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(i, k);
                        Console.Write(".");
                        Console.ResetColor();
                    }
                }
            }
            foreach (Goblin g in goblins)
            {
                g.draw();
            }
            pc.draw();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, 26);
            Console.Write(GameMessage);
            Console.ResetColor();

        }


        public void run()
        {
            this.draw();
            while (this.readInput())
            {
                this.draw();
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
