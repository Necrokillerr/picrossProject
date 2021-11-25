using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Picross
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
			Puzzle picross = new Puzzle(5, 5);
			picross.Location = new Point(450, 200);
			picross.Size = new Size(700, 700);
			this.Controls.Add(picross);
		}
	}
}
