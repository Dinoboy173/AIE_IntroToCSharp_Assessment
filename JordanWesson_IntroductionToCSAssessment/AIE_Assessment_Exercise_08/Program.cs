/*
 * Appendix 4 - Exercise 2: Adventure Game
 */

using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[,] map = new Room[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    map[row, col] = new Room();
                }
            }

            Player p = new Player();
            Enemy e = new Enemy(10, 27, 6);
            PowerUp pu = new PowerUp();

            map[1, 1].AddGameObject(p);
            map[2, 0].AddGameObject(e);
            map[0, 1].AddGameObject(pu);

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    map[row, col].Draw();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }

    abstract class GameObject
    {
        protected int posX = 0;
        protected int posY = 0;

        public GameObject()
        {
        }

        public abstract void Draw();
    }

    abstract class Character : GameObject
    {
        protected int AT = 0;
        protected int DF = 0;
        protected int HP = 0;

        public Character(int at, int df, int hp) : base()
        {
            this.AT = at;
            this.DF = df;
            this.HP = hp;
        }

        public bool IsAlive()
        {
            return HP > 0;
        }
    }

    class PowerUp : GameObject
    {
        public PowerUp() : base()
        {
        }

        public override void Draw()
        {
            Console.Write("?");
        }
    }

    class Player : Character
    {
        public Player() : base(10, 10, 100)
        {
            
        }

        public override void Draw()
        {
            Console.Write("X");
        }
    }

    class Enemy : Character
    {
        public Enemy() : base (10, 10, 100)
        {
            
        }

        public Enemy(int at, int df, int hp) : base(at, df, hp)
        {
            
        }

        public override void Draw()
        {
            if (HP > 10)
                Console.Write("O");
            else
                Console.Write("o");
        }
    }

    class Room
    {
        protected GameObject[] objects = new GameObject[3];

        public void AddGameObject(GameObject go)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == null)
                {
                    objects[i] = go;
                    break;
                }
            }
        }

        public void RemoveGameObject(GameObject go)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == go)
                {
                    objects[i] = null;
                    Array.Sort(objects);
                    break;
                }
            }
        }

        public void Draw()
        {
            if (objects[0] == null)
                Console.Write("_");
            else
                objects[0].Draw();
        }
    }
}
