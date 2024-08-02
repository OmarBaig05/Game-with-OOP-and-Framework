using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacMan.GameGL
{
    public class Game
    {
        public static GameObject getBlankGameObject(){
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static GameObject getFoodGameObject()
        {
            GameObject food = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.pallet);
            return food;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = PacManGUI.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.wall;
            }
            if (displayCharacter == 'v' || displayCharacter == 'V')
            {
                img = PacManGUI.Properties.Resources._void;
            }
            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.wall;
            }
            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = PacManGUI.Properties.Resources.player;
            }
            if (displayCharacter == '1' || displayCharacter == '1')
            {
                img = PacManGUI.Properties.Resources.enemyA;
            }
            if (displayCharacter == '2' || displayCharacter == '2')
            {
                img = PacManGUI.Properties.Resources.enemyB;
            }
            if (displayCharacter == '3' || displayCharacter == '3')
            {
                img = PacManGUI.Properties.Resources.bossEnemy;
            }
            if (displayCharacter == 'f' || displayCharacter == 'f')
            {
                img = PacManGUI.Properties.Resources.fire;
            }
            return img;
        }
    }
}
