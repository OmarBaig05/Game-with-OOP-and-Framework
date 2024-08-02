using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    class Enemy: MovingObject,randomEnemyI
    {
        public GameDirection direction;
        private int lifes;
        public static List<Enemy> enemies = new List<Enemy>();
        public Enemy(Image image, GameCell startCell,int lifes) : base(image, startCell, GameObjectType.ENEMY)
        {
            this.CurrentCell = startCell;
            this.direction = GameDirection.Left;
            this.lifes = lifes;
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell == currentCell || nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }
            currentCell.setGameObject(Game.getBlankGameObject());
            this.CurrentCell = nextCell;
            
            return nextCell;
        }

        public GameCell randomMove()
        {
            GameDirection[] directionArr = { GameDirection.Left, GameDirection.Right, GameDirection.Up, GameDirection.Down };
            Random random = new Random();
            direction = directionArr[random.Next(directionArr.Length)];
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (nextCell == currentCell || nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY || nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                while ((nextCell == currentCell || nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY || nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL))
                {
                    direction = directionArr[random.Next(directionArr.Length)];
                    nextCell = currentCell.nextCell(direction);
                }

            }

            currentCell.setGameObject(Game.getBlankGameObject());
            this.CurrentCell = nextCell;
            return nextCell;
        }
        public override GameCell move(GameDirection direction)
        {
            return null;
        }

        public void removeEnemyFromList(int i)
        {
            enemies.RemoveAt(i);
        }
        public void setEnemyLife(int life)
        {
            this.lifes = life;
        }
        public int getEnemyLife()
        {
            return lifes;
        }


    }
}
