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
            PutCrossOnRowsAndCollumnsWithZero();
            PutColorOnRowsAndCollumnsWithMaxValue();
            PutColorOnCenteredCells();
        }

        // Met une croix dans les lignes et colonnes ayant la valeur minimal (zéro)
        public void PutCrossOnRowsAndCollumnsWithZero()
        {
            // Collumns
            for (int i = 0; i < pCross.Collumns.Length; i++)
            {
                if (pCross.Collumns[i] == "0")
                {
                    for (int j = 0; j < pCross.Rows.Length; j++)
                    {
                        pCross.CellList[i + pCross.Rows.Length * j].State = State.cross;
                    }
                }
            }
            
            // Rows
            for (int i = 0; i < pCross.Rows.Length; i++)
            {
                if (pCross.Rows[i] == "0")
                {
                    for (int j = 0; j < pCross.Collumns.Length; j++)
                    {
                        pCross.CellList[j + pCross.Collumns.Length * i].State = State.cross;
                    }
                }
            }
        }

        // Remplis toutes les lignes et colonnes ayant la valeur maximal (taille du puzzle)
        public void PutColorOnRowsAndCollumnsWithMaxValue()
        {
            // Collumns
            for (int i = 0; i < pCross.Collumns.Length; i++)
            {
                if (pCross.Collumns[i] == pCross.Collumns.Length.ToString())
                {
                    for (int j = 0; j < pCross.Rows.Length; j++)
                    {
                        pCross.CellList[i + pCross.Rows.Length * j].State = State.fill;
                    }
                }
            }

            // Rows
            for (int i = 0; i < pCross.Rows.Length; i++)
            {
                if (pCross.Rows[i] == pCross.Rows.Length.ToString())
                {
                    for (int j = 0; j < pCross.Collumns.Length; j++)
                    {
                        pCross.CellList[j + pCross.Collumns.Length * i].State = State.fill;
                    }
                }
            }
        }

        // Remplis les cases restant allumé quand la valeur à été testé dans chaque emplacement
        public void PutColorOnCenteredCells()
        {
            // Croquis papier
        }
    }
}
