using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(5, 5);

            renderer.DrawPlayer(player.X, player.Y);
        }
    }

    class Renderer
    {
        public void DrawPlayer(int x, int y, char ch = '@')
        {
            Console.SetCursorPosition(x,y);
            Console.Write(ch);
            Console.ReadKey();
        }
    }

    class Player
    {

        public int X { get; private set; }

        public int Y { get; private set; }

        public Player (int x, int y)
        {
            Y = y;
            X = x;
        }
    }
}

