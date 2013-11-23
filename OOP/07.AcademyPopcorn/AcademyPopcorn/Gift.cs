using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // 11. Implement a Gift class. It should be a moving object, which always falls down. 
    // The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket. 
    
    class Gift:MovingObject
    {
        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '$','$' } }, new MatrixCoords(1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
