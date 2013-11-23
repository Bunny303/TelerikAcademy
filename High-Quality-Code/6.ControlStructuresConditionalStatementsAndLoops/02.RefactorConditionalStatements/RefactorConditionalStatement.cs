using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RefactorConditionalStatements
{
    public class RefactorConditionalStatement
    {
        Potato potato = new Potato();
        // ... 
        if (potato != null)
        {
            if (!potato.IsRotten && potato.HasBeenPeeled)
            {
                Cook(potato);
            }
        }

        bool xIsInRange = MIN_X <= x && x <= MAX_X;
        bool yIsInRange = MIN_Y <= y && y <= MAX_Y;

        if (xIsInRange && yIsInRange && !visited[x, y])
        {
            VisitCell(x, y);
        }
    }
}
