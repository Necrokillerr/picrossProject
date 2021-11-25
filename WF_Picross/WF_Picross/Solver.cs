using System;
using System.Collections.Generic;
using System.Text;

namespace WF_Picross
{
    class Solver
    {
        Puzzle pCross;
        public Solver(Puzzle picross)
        {
            pCross = picross;
        }

        public void Solve()
        {
            for(int i = 0; i < pCross.collumns.Length; i++)
            {
                if (pCross.collumns[i] == "0")
                {
                    for (int j = 0; j < pCross.rows.Length; j++)
                    {
                        pCross.cells[j].state = State.cross;
                    }
                }
            }
        }
    }
}
