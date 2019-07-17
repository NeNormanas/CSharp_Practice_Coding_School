﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Classes.Game
{
    class GameScreen
    {
        private int width;
        private int hight;

        private Hero hero; // galim aheroju suskurti ir per konstruktoriu arba is kart kaip kintamaji padaryti kartu su plociais auksciais
        private List<Enemy> enemies = new List<Enemy>();




        public GameScreen(int width, int hight)
        {
            this.width = width;
            this.hight = hight;

        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;

        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveHeroRight()
        {
            hero.MoveRight();
        }

        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }



        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();

            }

        }

        public Enemy GetEnemyById(int id)
        {
            foreach (var enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null; // neegsituojanti vieta, naudojam prie objektu

        }

        public void Render()
        {
            hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }

    }
}