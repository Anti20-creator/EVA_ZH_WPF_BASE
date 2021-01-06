using System;
using System.Collections.Generic;
using System.Text;

namespace ZH
{
    struct Pos
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Pos(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Player
    {
        public Pos pos;
        public Player()
        {
            pos = new Pos(0, 0);
        }

        public void move(int plusx, int plusy, int size)
        {
            if(this.pos.X + plusx < 0 || this.pos.X + plusx >= size ||
                this.pos.Y + plusy < 0 || this.pos.Y + plusy >= size)
            {
                //invalid move
            }
            else
            {
                this.pos = new Pos(this.pos.X + plusx, this.pos.Y + plusy);
            }
        }
    }
    public class Model
    {
        int size;

        private int[,] map;
        public int Size { get { return size; } set { size = value; } }
        Player player;
        public EventHandler<int> generateTable;
        public EventHandler advanceTime;
        bool canmove;
        public Model() {
            Size = 0;
            map = new int[0, 0];
        }

        public void StartGame(int e)
        {
            canmove = true;
            player = new Player();
            Size = e;
            map = new int[e, e];
            genMap();
            OnGenerateTable(e);
        }

        private void OnGenerateTable(int e)
        {
            if (generateTable != null)
            {
                generateTable(this, e);
            }
        }

        public void OnAdvanceTime()
        {
            if (advanceTime != null)
            {
                advanceTime(this, EventArgs.Empty);
            }
        }

        public void AdvanceTime()
        {
            canmove = true;
            genMap();

            OnAdvanceTime();
        }

        public void movePlayer(int x, int y)
        {
            if (!canmove) return;
            player.move(x, y, Size);
            canmove = false;
        }

        private void genMap()
        {
            Random rnd = new Random();
            for (int i = 0; i < Size; ++i)
            {
                for (int j = 0; j < Size; ++j)
                {
                    map[i, j] = rnd.Next(0, 2);
                }
            }
            map[player.pos.X, player.pos.Y] = 2;
        }

        public int getMapElem(int i, int j)
        {
            return map[i, j];
        }
    }
}
