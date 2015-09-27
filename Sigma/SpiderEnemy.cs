using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Kalib Crone
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Sigma
{
    public class SpiderEnemy
    {
        Model model;
        SpiderEnemy[] spidersArr;
        Vector3 position;
        Vector2 heading;

        int health;
        int attackDistance;
        float speed;


        public void Initialize(ContentManager contMgr, Vector3 pos, Vector2 head)
        {
            model = contMgr.Load<Model>("SpiderEnemy");
            position = pos;
            heading = head;

            health = 100;
            attackDistance = 20;
            speed = 4;
        }



        public void Update(Vector3 playerPosition)
        {
            if ((Vector3.Distance(playerPosition, position) > attackDistance))
            {
                follow(playerPosition);
            }
            else
            {
                idle();
            }

        }

        private void idle()
        {
            throw new NotImplementedException();
            //idle animation
        }

        public void follow(Vector3 playerPosition)
        {
            double angle = Math.Atan2(playerPosition.Y - position.Y, playerPosition.X - position.X); //Find angle of enemy to player
            Vector3 velocity = new Vector3((float)Math.Cos(angle), (float)Math.Sin(angle), 0);
            position += velocity * speed; //makes enemy follow player.  Increase/Decrease speed (float) to adjust movement speed.


        }

        public void attack()
        {
            //do attack
        }

        public void Draw(Vector3 cameraPosition, float aspectRatio)
        {
           
        }

    }
}
