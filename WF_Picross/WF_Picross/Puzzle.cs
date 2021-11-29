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
		public Cell[,] cells;
		public List<Cell> cellList;

		public string[] collumns = { "1", "4", "5", "2", "2" };
		public string[] rows = { "2", "3,1", "4", "3", "1" };

		//public string[] collumns = { "5", "2,1", "4", "2, 2", "0" };
		//public string[] rows = { "1", "2", "1", "4", "1" };

		public Puzzle() : this(5, 5)
		{
			
		}

		public Puzzle(int width, int height) : this(new Size(width, height))
		{

		}

		public Puzzle(Size size)
		{
			sizeGrid = size;
			cells = new Cell[sizeGrid.Width, sizeGrid.Height];
			cellList = new List<Cell>();
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
					cells[i, j] = new Cell(new Point(x, y), new Size(size, size));
					cellList.Add(new Cell(new Point(x, y), new Size(size, size)));
					x += size;
				}
			}
			/*foreach (Cell cell in cells)
            {
				cell.Paint(pe.Graphics);
            }*/

			foreach (Cell cell in cellList)
			{
				cell.Paint(pe.Graphics);
			}
		}
	}
}
