namespace Snake_Game
{
    class SnakeApp
    {
        public static void Main()
        {
            char key = '0';

            char snakeHead = '0';
            char snakeTail1 = '*';
            char snakeTail2 = '*';
            char snakeTail3 = '*';
            char snakeTail4 = '*';
            char snakeTail5 = '*';

            int snakeHeadX = 5;
            int snakeHeadY = 0;

            int snakeTail1X = 4;
            int snakeTail1Y = 0;
                     
            int snakeTail2X = 3;
            int snakeTail2Y = 0;
                     
            int snakeTail3X = 2;
            int snakeTail3Y = 0;
                     
            int snakeTail4X = 1;
            int snakeTail4Y = 0;
                     
            int snakeTail5X = 0;
            int snakeTail5Y = 0;

            int screenWidth = Console.WindowWidth;
            int screenHeight = Console.WindowHeight;

            while(true)
            {
                key = Console.ReadKey(true).KeyChar;
                Console.CursorVisible = false;

                if (key == 'w' && snakeHeadY-1 == snakeTail1Y)
                {
                    continue;
                }
                if (key == 's' && snakeHeadY + 1 == snakeTail1Y)
                {
                    continue;
                }
                if (key == 'd' && snakeHeadX + 1 == snakeTail1X)
                {
                    continue;
                }
                if (key == 'a' && snakeHeadX - 1 == snakeTail1X)
                {
                    continue;
                }


                Console.SetCursorPosition(snakeTail5X, snakeTail5Y);
                Console.Write(' ');


                snakeTail5X = snakeTail4X;
                snakeTail5Y = snakeTail4Y;
                Console.SetCursorPosition(snakeTail5X, snakeTail5Y);
                Console.Write(snakeTail5);


                snakeTail4X = snakeTail3X;
                snakeTail4Y = snakeTail3Y;
                Console.SetCursorPosition(snakeTail4X, snakeTail4Y);
                Console.Write(snakeTail4);


                snakeTail3X = snakeTail2X;
                snakeTail3Y = snakeTail2Y;
                Console.SetCursorPosition(snakeTail3X, snakeTail3Y);
                Console.Write(snakeTail3);


                snakeTail2X = snakeTail1X;
                snakeTail2Y = snakeTail1Y;
                Console.SetCursorPosition(snakeTail2X, snakeTail2Y);
                Console.Write(snakeTail2);


                snakeTail1X = snakeHeadX;
                snakeTail1Y = snakeHeadY;
                Console.SetCursorPosition(snakeTail1X, snakeTail1Y);
                Console.Write(snakeTail1);

                
                if(key == 'w')
                {
                    snakeHeadY--;
                }
                if(key == 'd')
                {
                    snakeHeadX++;
                }
                if(key == 's')
                {
                    snakeHeadY++;
                }
                if(key == 'a')
                {
                    snakeHeadX--;
                }

                if(snakeHeadX < 0)
                {
                    snakeHeadX = screenWidth-1;
                }
                else if(snakeHeadX > screenWidth-1)
                {
                    snakeHeadX = 0;
                }
                else if(snakeHeadY < 0)
                {
                    snakeHeadY = screenHeight-1;
                }
                else if(snakeHeadY > screenHeight-1)
                {
                    snakeHeadY = 0;
                }

                if(snakeTail4X == snakeHeadX && snakeTail4Y == snakeHeadY)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("GAME FINISHED");
                    break;
                }
                

                Console.SetCursorPosition(snakeHeadX, snakeHeadY);
                Console.Write(snakeHead);

            }
        }
    }
}
