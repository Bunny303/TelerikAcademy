﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // 12. Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed.
    
    class GiftBlock: Block
    {
        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {

        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                produceObjects.Add(new Gift(this.topLeft));
            }
            return produceObjects;
        }
    }
}
