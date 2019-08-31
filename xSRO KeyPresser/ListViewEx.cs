// Decompiled with JetBrains decompiler
// Type: xSRO_KeyPresser.ListViewEx
// Assembly: xSRO KeyPresser, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 428579D7-7BC6-41FC-A1A8-3499407A23CB
// Assembly location: C:\Users\Luisana\Desktop\xSRO KeyPresser\xSRO KeyPresser.exe

using System;
using System.Drawing;
using System.Windows.Forms;

namespace xSRO_KeyPresser
{
	public class ListViewEx : ListView
	{
		private int _LineBefore = -1;
		private int _LineAfter = -1;
		private const int WM_PAINT = 15;
		private const int WM_CONTEXTMENU = 123;
		private Brush b;
		private Pen p;

		public ListViewEx()
		{
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.setColor(Color.Black);
		}

		public void setColor(Color c)
		{
			this.b = (Brush)new SolidBrush(c);
			this.p = new Pen(c);
		}

		public int LineBefore
		{
			get
			{
				return this._LineBefore;
			}
			set
			{
				this._LineBefore = value;
			}
		}

		public int LineAfter
		{
			get
			{
				return this._LineAfter;
			}
			set
			{
				this._LineAfter = value;
			}
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			switch (m.Msg)
			{
				case 15:
					try
					{
						Rectangle bounds;
						if (this.LineBefore >= 0 && this.LineBefore < this.Items.Count)
						{
							bounds = this.Items[this.LineBefore].GetBounds(ItemBoundsPortion.Entire);
							this.DrawInsertionLine(bounds.Left, bounds.Right, bounds.Top);
						}
						if (this.LineAfter < 0 || this.LineBefore >= this.Items.Count)
							break;
						bounds = this.Items[this.LineAfter].GetBounds(ItemBoundsPortion.Entire);
						this.DrawInsertionLine(bounds.Left, bounds.Right, bounds.Bottom);
						break;
					}
					catch
					{
						break;
					}
				case 123:
					this.OnMouseEnter((EventArgs)null);
					break;
			}
		}

		private void DrawInsertionLine(int X1, int X2, int Y)
		{
			using (Graphics graphics = this.CreateGraphics())
			{
				graphics.DrawLine(this.p, X1, Y, X2 - 1, Y);
				Point[] points1 = new Point[3]
				{
					new Point(X1, Y - 4),
					new Point(X1 + 7, Y),
					new Point(X1, Y + 4)
				};
				Point[] points2 = new Point[3]
				{
					new Point(X2, Y - 4),
					new Point(X2 - 8, Y),
					new Point(X2, Y + 4)
				};
				graphics.FillPolygon(this.b, points1);
				graphics.FillPolygon(this.b, points2);
			}
		}
	}
}
