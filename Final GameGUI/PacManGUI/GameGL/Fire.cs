using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGUI.GameGL
{
    internal class Fire: MovingObject
    {
        public static List<Fire> fires = new List<Fire>();
        public static List<Fire> firesByEnemies = new List<Fire>();
        private bool flag = false;
        public Fire(Image image, GameCell startCell) : base(image,startCell, GameObjectType.Fire)
        {
            this.CurrentCell = startCell;
        }

        public override GameCell move (GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            if (currentCell == nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
                Fire.fires.Remove(this);
                return null;
            }
            this.CurrentCell = nextCell;
            return nextCell;
        }
        public  GameCell move(GameDirection direction, GameCell gamecell)
        {
            if(flag == true)
            {
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(direction);

                if (currentCell != nextCell)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                }
                if (currentCell == nextCell)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    Fire.fires.Remove(this);
                    return null;
                }
                this.CurrentCell = nextCell;
                return nextCell;
            }
            return null;
            
        }
        public override GameCell move()
        {
            return null;
        }

        public bool getFlag()
        {
            return flag;
        }
        public void setFlag(bool flag) { this.flag = flag; }
    }
}
