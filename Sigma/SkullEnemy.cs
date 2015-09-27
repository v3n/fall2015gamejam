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
    public class SkullEnemy
    {
        Model model;
        SkullEnemy[] skulls;
        Vector3 position;
        Vector2 heading;
        

        int attackDistance = 10;
       
        float speed = 1f;

        
        public void Initialize(ContentManager contMgr, Vector3 pos, Vector2 head)
        {
            model = contMgr.Load<Model>("SkullEnemy");
            position = pos;
            heading = head;
           
        }

        

        public void Update(Vector3 playerPosition)
        {

            if((Vector3.Distance(playerPosition, position) > attackDistance))
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
            Vector3 velocity = new Vector3((float)Math.Cos (angle), (float)Math.Sin(angle),0);
            position += velocity*speed; //makes enemy follow player.  Increase/Decrease speed (float) to adjust movement speed.


        }
        public void attack()
        { 
            //do attack move (damage and animation)
        }


        public void Draw(Vector3 cameraPosition, float aspectRatio)
        {




           
            
            
            
            
            
            /*Wrote this code using default shaders.  Just for reference.*/

            //foreach (var mesh in model.Meshes) //model is composed of messhes.  can have different rendering states, such as lighting
            //{
            //    foreach (BasicEffect effect in mesh.Effects) //effect refers to a shader.  The ones used are built in.  TODO: change to custom shaders
            //    {
            //        effect.EnableDefaultLighting(); //sets up default lighting, easy and quick. not custom.
            //        effect.PreferPerPixelLighting = true; //realistic look for curved objects, slow on preformance
            //        effect.World = Matrix.Identity; //world matrix can be used to position, rotate or rescale model.  Identity means that the model is unrotated, drawn at the origin, and its size unchanged from loaded content. 

            //        var cameraLookAtVector = Vector3.Zero; //tell camera to look at the origin
            //        var cameraUpVector = Vector3.UnitZ; //Tell camera that positive Z is up.

            //        effect.View = Matrix.CreateLookAt(cameraPosition, cameraLookAtVector, cameraUpVector);

            //        float fieldOfView = Microsoft.Xna.Framework.MathHelper.PiOver4; //increasing means wider view, similar to zooming out.
            //        float nearClipPlane = 1;
            //        float farClipPlane = 200;

            //        effect.Projection = Matrix.CreatePerspectiveFieldOfView(fieldOfView, aspectRatio, nearClipPlane, farClipPlane);
            //    }
            //    mesh.Draw();
            //}
            
        }
        
    }
}
