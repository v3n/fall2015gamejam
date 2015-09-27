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
        SpiderEnemy[] spiders;


        public void Initialize(ContentManager contMgr, Vector3 position, Vector2 heading)
        {
            model = contMgr.Load<Model>("SpiderEnemy");

        }



        public void Update(Vector3 playerPosition)
        {
            move(playerPosition);
        }

        public void move(Vector3 playerPos)
        {
            
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
