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
        private List<Cell> _cellList;

        private string[] _collumns = { "1", "4", "5", "2", "2" };
		private string[] _rows = { "2", "3,1", "4", "3", "1" };

        // Array to test max and min value
        //private string[] _collumns = { "5", "0", "5", "2", "0" };
        //private string[] _rows = { "1", "2", "1", "1", "1" };
		
		public List<Cell> CellList { get => _cellList; set => _cellList = value; }
        public string[] Collumns { get => _collumns; set => _collumns = value; }
        public string[] Rows { get => _rows; set => _rows = value; }

        public Puzzle() : this(5, 5)
		{
			
		}

		public Puzzle(int width, int height) : this(new Size(width, height))
		{

		}

		public Puzzle(Size size)
		{
			sizeGrid = size;
			CellList = new List<Cell>();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			int x = 60;
			int y = 20;
			int size = 30;
			
			for (int i = 0; i < sizeGrid.Height; i++)
			{
				pe.Graphics.DrawString(Rows[i], new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(0, y+32));
				pe.Graphics.DrawRectangle(Pens.Blue, new Rectangle(new Point(0, y+size), new Size(60, 30)));

				y += size;
				x = 60;
				for(int j = 0; j < sizeGrid.Width; j++)
				{
					pe.Graphics.DrawString(Collumns[j], new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, new PointF(x, 0), new StringFormat(StringFormatFlags.DirectionVertical));
					pe.Graphics.DrawRectangle(Pens.Blue, new Rectangle(new Point(x, 0), new Size(30, 50)));
					CellList.Add(new Cell(new Point(x, y), new Size(size, size)));
					x += size;
				}
			}

			foreach (Cell cell in CellList)
			{
				cell.Paint(pe.Graphics);
			}
		}
	}
}
