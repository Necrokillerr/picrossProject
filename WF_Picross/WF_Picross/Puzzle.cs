using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF_Picross
{
	class Puzzle : PictureBox
	{
		Size sizeGrid;
		public List<Cell> cells;
		public string[] collumns = { "3", "2,1", "4", "2, 2", "0" };
		public string[] rows = { "1", "1", "1", "3", "0" };

		public Puzzle() : this(5, 5)
		{
			
		}

		public Puzzle(int width, int height) : this(new Size(width, height))
		{

		}

		public Puzzle(Size size)
		{
			sizeGrid = size;
			cells = new List<Cell>();
		}

		// ================ Méthodes ================
		// Met une croix
		public void PutX()
		{

		}

		// Remplis la case
		public void PutColor()
		{

		}

		// Met une croix aux deux extrémités d'un segment
		public void PutXAround()
		{
			// Si nbCase à remplir = nbCase rempli, Mettre une croix aux extrémités
		}

		// Met une croix dans les espaces trop petit pour le nombre
		public void PutXInLittleSpaceForHint()
		{
			// Si nbCase disponible < que nbCase à remplir, Remplir par des croix
		}

		// Remplis toutes les cellules correct "logique"
		public void FillBetweenCell()
		{
			// Si deux case sont remplie et qu'elles correspondent au même nombre, Remplir les cases du milieu
		}

		// Remplis les lignes ou colonnes complète
		public void FillFullLineOrColumnCell()
		{
			// Si nbCase disponible = nbCase à remplir (dans ligne ou colonne), Tout remplir
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			int x = 60;
			int y = 20;
			int size = 30;
			
			for (int i = 0; i < sizeGrid.Height; i++)
			{
				pe.Graphics.DrawString(rows[i], new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(0, y+32));
				pe.Graphics.DrawRectangle(Pens.Blue, new Rectangle(new Point(0, y+size), new Size(60, 30)));

				y += size;
				x = 60;
				for(int j = 0; j < sizeGrid.Width; j++)
				{
					pe.Graphics.DrawString(collumns[j], new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(x, 0), new StringFormat(StringFormatFlags.DirectionVertical));
					pe.Graphics.DrawRectangle(Pens.Blue, new Rectangle(new Point(x, 0), new Size(30, 50)));
					cells.Add(new Cell(new Point(x, y), new Size(size, size)));
					x += size;
				}
			}
			foreach (Cell cell in cells)
            {
				cell.Paint(pe.Graphics);
            }
		}
	}
}
