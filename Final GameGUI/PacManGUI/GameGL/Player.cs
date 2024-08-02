using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PacManGUI.GameGL;

namespace PacMan.GameGL
{
     class Player : MovingObject
    {
        int PlayerLife;
        public Player(Image image,GameCell startCell, int PlayerLife) :base (image , startCell, GameObjectType.PLAYER) {
            this.CurrentCell = startCell;
            this.PlayerLife = PlayerLife;
        }
        public override GameCell move(GameDirection direction) {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell= currentCell.nextCell(direction);
            if (currentCell != nextCell) {
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            this.CurrentCell = nextCell;
            return nextCell;
        }

        public override GameCell move()
        {
            return null;
        }

        public GameCell getCurrentCell()
        {
            return this.CurrentCell;
        }

        public int getPlayerLife()
        {
            return this.PlayerLife;
        }

        public void setPlayerLife(int i)
        { this.PlayerLife = i; }
    }

}
