using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WF_Picross
{
	class Cell
	{
		Point _location;   // Position
		Size _size;		// Taille

		int empty;			// Cellule vide
		int cross;			// Cellule contenant une croix
		int correct;		// Cellule correct

		
		// Propriétés
		public Point Location { get => _location; set => _location = value; }
		public Size Size { get => _size; set => _size = value; }

		// Constructeur
		public Cell() :this(new Point(60, 50), new Size(30, 30))
		{

		}

		public Cell(Point location, Size size)
		{
			Location = location;
			Size = size;
		}

		// Méthode
		public void Paint(Graphics g)
		{
			g.DrawRectangle(Pens.Black, new Rectangle(Location, Size));
		}
	}
}
