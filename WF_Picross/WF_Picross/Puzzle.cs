using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF_Picross
{
	class Puzzle : PictureBox
	{
		Cell picross;
		int _width;
		int _height;

		public Puzzle() : base()
		{
			picross = new Cell();
			_width = 5;
			_height = 5;
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

		}

		// Met une croix dans les espaces trop petit pour le nombre
		public void PutXInLittleSpaceForHint()
		{

		}

		// Remplis toute les cellules correct "logique"
		public void FillCorrectCell()
		{

		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			int x = 60;
			int y = 0;
			int size = 30;

			pe.Graphics.DrawString("1 3", new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(0, 33));
			pe.Graphics.DrawString("1 3", new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(0, 63));

			pe.Graphics.DrawString("3 1", new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(33, 0), new StringFormat(StringFormatFlags.DirectionVertical));

			for (int i = 0; i < _height; i++)
			{
				y += size;
				x = 60;
				for(int j = 0; j < _width; j++)
				{
					pe.Graphics.DrawRectangle(Pens.Black, new Rectangle(new Point(x, y), new Size(size, size)));
					x += size;
				}
			}
		}
	}
}
