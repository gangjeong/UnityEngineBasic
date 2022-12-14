using System;

namespace Array_2D
{
    internal class Program
    {
        // Inner class
        // 클래스 내에 정의된 클래스
        class Player
        {
            public int _x, _y;

            // this 키워드
            // 객체 자기자신 참조 키워드
            public void SetPos(int x, int y)
            {
                this._x =  x;
                this._y =  y;
                Program.map[y, x] = 5;
                Program.DisplayMap();
            }

            public void MoveDown()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (_y >= map.GetLength(0) - 1)
                    return;

                // 지나갈 수 없는 벽인지 체크
                if (map[ _y + 1, _x] == 1)
                    return;

                SetPos(_x, _y + 1);
            }

            public void Moveup()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (_y <= 0)
                    return;

                // 지나갈 수 없는 벽인지 체크
                if (map[_y - 1, _x] == 1)
                    return;

                SetPos(_x, _y - 1);
            }

        }



        // 0 : 지나갈 수 있는 길
        // 1 : 지나갈 수 없는 벽
        // 2 : 도착지점
        // 5 : 플레이어
        static int[,] map = new int[5, 5]
        {
         { 0, 1, 1, 1, 1, },
         { 0, 1, 1, 1, 1, },
         { 0, 0, 0, 1, 1, },
         { 1, 1, 0, 1, 1, },
         { 1, 1, 0, 0, 2, },
        };


        static void Main(string[] args)
        {
            Player player = new Player();
            player.SetPos(0, 0);




            map[0, 0] = 5;
            DisplayMap();
        }

        static void DisplayMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 0)
                        Console.WriteLine("□");
                    else if (map[i, j] == 1)
                        Console.WriteLine("■");
                    else if (map[i, j] == 2)
                        Console.WriteLine("☆");
                    else if (map[i, j] == 5)
                        Console.WriteLine("▣");
                }
            }
        }
    }
}
