using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    abstract class MovingObject : GameObject
    {
        public MovingObject(Image image, GameCell startCell, GameObjectType gameObjectType) : base(gameObjectType, image)
        {
            this.CurrentCell = startCell;
        }

        public abstract GameCell move(GameDirection direction);
        public abstract GameCell move();
    }
}
