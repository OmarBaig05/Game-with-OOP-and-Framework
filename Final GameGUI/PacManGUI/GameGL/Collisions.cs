using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    internal class Collisions 
    {
        public static bool collision(GameCell playerNextCell)
        {
            foreach(Enemy e in  Enemy.enemies)
            {
                 if (e.CurrentCell.PictureBox.Bounds.IntersectsWith(playerNextCell.PictureBox.Bounds))
                 {
                     return true;
                 }
            }
            return false;
        }
        public static bool collisionWithFire()
        {
            for (int i = Fire.fires.Count - 1; i >= 0; i--)
            {
                foreach (Enemy e in Enemy.enemies)
                {
                    if (e.CurrentCell.PictureBox.Bounds.IntersectsWith(Fire.fires[i].CurrentCell.PictureBox.Bounds))
                    {
                        e.setEnemyLife(e.getEnemyLife()-1);
                        Fire.fires.RemoveAt(i);
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool collisionWithFireOfPlayer(Player p)
        {
            for (int i = Fire.firesByEnemies.Count - 1; i >= 0; i--)
            {
                
                 if (p.CurrentCell.PictureBox.Bounds.IntersectsWith(Fire.firesByEnemies[i].CurrentCell.PictureBox.Bounds))
                 {
                     p.setPlayerLife(p.getPlayerLife() - 1);
                     Fire.firesByEnemies.RemoveAt(i);
                    return true;
                 }
                
            }
            return false;
        }

        public static void enemyLifeCheck()
        {
            for (int i = 0; i < Enemy.enemies.Count; i++)
            {
                if (Enemy.enemies[i].getEnemyLife() <= 0)
                {
                    Enemy.enemies.RemoveAt(i);
                }
            }
        }
        public bool playerLifeCheck(Player p)
        {
            if (p.getPlayerLife() <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
    

