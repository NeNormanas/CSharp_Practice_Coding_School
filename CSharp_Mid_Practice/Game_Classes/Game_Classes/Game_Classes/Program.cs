using System;

namespace Game_Classes.Game
{
    class Program
    {
        static void Main(string[] args)
        {

            


            GameScreen myGame = new GameScreen(60, 30);
            myGame.SetHero(new Hero(30, 15, "Normanas"));

            Random rnd = new Random();
            int enemycount = 0;

            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(i, rnd.Next(0, 60), rnd.Next(0, 30), "enemy" + enemycount));
                enemycount++;

            }

            myGame.Render();

            myGame.MoveHeroLeft();

            myGame.Render();

            Enemy secondEnemy = myGame.GetEnemyById(1);
            Enemy forthEnemy = myGame.GetEnemyById(3);

            if (secondEnemy != null && forthEnemy != null) // visada daryti tikrinimus, kad nebutu null, nes su null reiksme nulus programa.
            {
                forthEnemy.MoveDown();
                secondEnemy.MoveDown();
            }

            myGame.Render();

            myGame.MoveAllEnemiesDown();

            myGame.Render();


            Console.ReadKey();


        }
    }
}
