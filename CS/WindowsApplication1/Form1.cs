using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			LayoutControl lc = new LayoutControl();
			lc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Controls.Add(lc);

			LayoutControlItem labelItem1 = lc.Root.AddItem();
			labelItem1.Name = Guid.NewGuid().ToString();
			labelItem1.Control = new LabelControl();
			labelItem1.Control.Size = new Size(100, 100);
			labelItem1.Text = "1";

			EmptySpaceItem emptySpace = new EmptySpaceItem();
			new DevExpress.XtraLayout.Customization.LayoutItemDragController(emptySpace, labelItem1, DevExpress.XtraLayout.Utils.InsertLocation.After, DevExpress.XtraLayout.Utils.LayoutType.Vertical).DragWildItem();

			LayoutControlItem labelItem2 =  lc.Root.AddItem();
			labelItem2.Name = Guid.NewGuid().ToString();
			labelItem2.Control = new LabelControl();
			labelItem2.Control.Size = new Size(100, 100);
			labelItem2.Text = "2";

		}
	}
}