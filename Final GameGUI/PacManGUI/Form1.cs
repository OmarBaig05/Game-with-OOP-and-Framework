using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
using PacManGUI.GameGL;
using System.Threading;

namespace PacManGUI
{
    public partial class Form1 : Form
    {
        Player player;
        Enemy enemy;
        Enemy enemy2;
        Enemy enemy3;
        GameGrid grid;
        private Fire fire;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             grid = new GameGrid("maze.txt", 35, 70);

            //Loading Images

            Image playerImage = Game.getGameObjectImage('p');
            Image enemyImage = Game.getGameObjectImage('1');
            Image enemyImage2 = Game.getGameObjectImage('2');
            Image enemyImage3 = Game.getGameObjectImage('3');

            //Initializing Coordinates

            GameCell startCellPlayer = grid.getCell(23,30);
            GameCell startCellEnemy = grid.getCell(30, 30);
            GameCell startCellEnemy2 = grid.getCell(33, 30);
            GameCell startCellEnemy3 = grid.getCell(10, 30);

            // calling Objects/Players

            player = new Player(playerImage, startCellPlayer,10);
            enemy = new Enemy(enemyImage, startCellEnemy, 5);
            enemy2 = new Enemy(enemyImage2, startCellEnemy2, 5);
            enemy3 = new Enemy(enemyImage3, startCellEnemy3, 15);
            Enemy.enemies.Add(enemy);
            Enemy.enemies.Add(enemy2);
            Enemy.enemies.Add(enemy3);
            printMaze(grid);
        }



        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
               
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        void updateScore()
        {
            int x = int.Parse(Scorelabel1.Text);
            x += 5;
            Scorelabel1.Text =x.ToString();
        }
        void playerHealth()
        {
            label3.Text =player.getPlayerLife().ToString();
            if(player.getPlayerLife() <= 0)
            {
                gameEnd();
            }
        }
        void Enemy1Health()
        {
            label8.Text = enemy.getEnemyLife().ToString();
        }
        void Enemy2Health()
        {
            label6.Text = enemy2.getEnemyLife().ToString();
        }
        void bossEnemyHealth()
        {
            label4.Text = enemy3.getEnemyLife().ToString();
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            moveEnemy();
            
            Collisions.enemyLifeCheck();
            GameCell playerNextCell;
            allFireMovementCommonFunction();
            if (Keyboard.IsKeyPressed(Key.LeftArrow)) {
                playerNextCell =  player.move(GameDirection.Left);
                collsion(playerNextCell);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow)){
                playerNextCell = player.move(GameDirection.Right);
                collsion(playerNextCell);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow)){
                playerNextCell = player.move(GameDirection.Up);
                collsion(playerNextCell);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow)){
                playerNextCell = player.move(GameDirection.Down);
                collsion(playerNextCell);
            }
            if (Keyboard.IsKeyPressed(Key.F))
            {
                generateFire();
            }
            
        }


        public void allFireMovementCommonFunction()
        {
            for (int i = 0; i < Fire.fires.Count; i++)
            {
                Fire.fires[i].move(GameDirection.Right);
                Fire.firesByEnemies[i].move(GameDirection.Left);
                if (Collisions.collisionWithFire())
                {
                    updateScore();
                    Enemy1Health();
                    Enemy2Health();
                    bossEnemyHealth();
                }
            }
            for (int i = 0; i < Fire.firesByEnemies.Count; i++)
            {
                Fire.firesByEnemies[i].move(GameDirection.Left);
                if (Collisions.collisionWithFireOfPlayer(player))
                {
                    playerHealth();
                }
            }
        }

        public void moveEnemy()
        {
            for(int i = 0; i < Enemy.enemies.Count; i++)
            {
                if (Enemy.enemies[i] == enemy3)
                {
                    Enemy.enemies[i].randomMove();
                }
                GameCell g = Enemy.enemies[i].move();
            }
        }
        public void collsion(GameCell playerNextCell)
        {
            if(Collisions.collision(playerNextCell))    
            {
                gameEnd();
            }
        }

        void gameEnd()
        {
            GameEnd g = new GameEnd();
            this.Hide();
            g.Show();
        }
        public void generateFire()
        {
            Image fireImage = Game.getGameObjectImage('f');
            GameCell fireStartCell = player.getCurrentCell();
            fireStartCell = grid.getCell(fireStartCell.X, fireStartCell.Y + 1);
            fire = new Fire(fireImage, fireStartCell);
            Fire.fires.Add(fire);
        }
        private void fireTimer_Tick(object sender, EventArgs e)
        {
            foreach(Enemy en in Enemy.enemies)
            {
                GameCell cell = en.CurrentCell;
                Image fireImage = Game.getGameObjectImage('v');
                if(en.direction == GameDirection.Right)
                {
                    cell = grid.getCell(cell.X, cell.Y - 1);
                }
                else if(en.direction == GameDirection.Left)
                {
                    cell = grid.getCell(cell.X, cell.Y - 2 );
                }
                fire = new Fire(fireImage, cell);
                Fire.firesByEnemies.Add(fire);
            }
        }
    }
}
