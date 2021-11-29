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
            //PutCrossOnRowsAndCollumnsWithZero();
            //PutColorOnRowsAndCollumnsWithMaxValue();
            PutColorOnCenteredCells();
        }

        // Met une croix dans les lignes et colonnes ayant la valeur minimal (zéro)
        public void PutCrossOnRowsAndCollumnsWithZero()
        {
            // Collumns
            for (int i = 0; i < pCross.collumns.Length; i++)
            {
                if (pCross.collumns[i] == "0")
                {
                    for (int j = 0; j < pCross.rows.Length; j++)
                    {
                        pCross.cellList[i + pCross.rows.Length * j].state = State.cross;
                    }
                }
            }
            
            // Rows
            for (int i = 0; i < pCross.rows.Length; i++)
            {
                if (pCross.rows[i] == "0")
                {
                    for (int j = 0; j < pCross.collumns.Length; j++)
                    {
                        pCross.cellList[j + pCross.collumns.Length * i].state = State.cross;
                    }
                }
            }
        }

        // Remplis toutes les lignes et colonnes ayant la valeur maximal (taille du puzzle)
        public void PutColorOnRowsAndCollumnsWithMaxValue()
        {
            // Collumns
            for (int i = 0; i < pCross.collumns.Length; i++)
            {
                if (pCross.collumns[i] == pCross.collumns.Length.ToString())
                {
                    for (int j = 0; j < pCross.rows.Length; j++)
                    {
                        pCross.cellList[i + pCross.rows.Length * j].state = State.fill;
                    }
                }
            }

            // Rows
            for (int i = 0; i < pCross.rows.Length; i++)
            {
                if (pCross.rows[i] == pCross.rows.Length.ToString())
                {
                    for (int j = 0; j < pCross.collumns.Length; j++)
                    {
                        pCross.cellList[j + pCross.collumns.Length * i].state = State.fill;
                    }
                }
            }
        }

        // Remplis les cases restant allumé quand la valeur à été testé dans chaque emplacement
        public void PutColorOnCenteredCells()
        {

        }
    }
}
