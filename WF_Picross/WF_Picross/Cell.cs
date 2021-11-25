using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WF_Picross
{
	public enum State { empty, cross, fill };

	class Cell
	{
		Point _location;   // Position
		Size _size;         // Taille

		public State state;
		
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
			// Cellule vide
			if(state == State.empty || state == State.cross)
				g.DrawRectangle(Pens.Black, new Rectangle(Location, Size));

			// Cellule correct
			if (state == State.fill)
				g.FillRectangle(Brushes.Black, new Rectangle(Location.X, Location.Y, Size.Width+1, Size.Height+1));

			// Cellule fausse
			if (state == State.cross)
            {
				g.DrawLine(Pens.Red, new Point(Location.X, Location.Y), new Point(Location.X + Size.Width, Location.Y + Size.Height));
				g.DrawLine(Pens.Red, new Point(Location.X, Location.Y + Size.Height), new Point(Location.X + Size.Width, Location.Y));
            }
		}
	}
}
