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
			Puzzle picross = new Puzzle(10, 10);
			picross.Location = new Point(200, 200);
			this.Controls.Add(picross);
		}
	}
}
