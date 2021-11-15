using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WF_Picross
{
	class Cell
	{
		PointF _location;   // Position
		SizeF _size;		// Taille

		int empty;			// Cellule vide
		int cross;			// Cellule contenant une croix
		int correct;		// Cellule correct

		
		// Propriétés
		public PointF Location { get => _location; set => _location = value; }
		public SizeF Size { get => _size; set => _size = value; }

		// Constructeur
		public Cell() :this(new PointF(60, 20), new SizeF(30, 30))
		{

		}

		public Cell(PointF location, SizeF size)
		{
			Location = location;
			Size = size;
		}

		// Méthode
		public void Paint(Graphics g)
		{

		}
	}
}
