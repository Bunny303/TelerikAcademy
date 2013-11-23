using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace AcademyPopcorn
{
    // 5. Implement a TrailObject class. It should inherit the GameObject class 
    // and should have a constructor which takes an additional "lifetime" integer. 
    // The TrailObject should disappear after a "lifetime" amount of turns. 

    class TrailObject : GameObject
    {
        public int Lifetime { get; set; }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime)
            : base(topLeft, body)
        {
            this.Lifetime = lifetime;
        }
                
        public override void Update()
        {
            this.Lifetime--;
            if (this.Lifetime == 1)
            {
                this.IsDestroyed = true;
            }
        }
        
    }
}
