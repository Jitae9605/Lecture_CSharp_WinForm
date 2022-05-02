using System;
using System.Windows.Forms;

namespace MouseEventTest_X_Y
{
	class Change_Form_Size : Form
	{
		static void Main(string[] args)
		{
			Change_Form_Size form = new Change_Form_Size();
			form.Width = 300;	// 폼 너비
			form.Height = 200;  // 폼 높이

			form.MouseDown += new MouseEventHandler(form_MouseDown);

			Application.Run(form);
		}

		static void form_MouseDown(object sender, MouseEventArgs e)
		{
			Form form = (Form)sender;
			int oldWidth = form.Width;
			int oldHeight = form.Height;

			if (e.Button == MouseButtons.Left)
			{
				if(oldWidth < oldHeight)
				{
					form.Width = oldHeight;
					form.Height = oldWidth;
				}
			}

			else if(e.Button == MouseButtons.Right)
			{
				if (oldHeight < oldWidth)
				{
					form.Width = oldHeight;
					form.Height = oldWidth;
				}
			}

			Console.WriteLine("윈도우의 크기가 변했습니다.");
			Console.WriteLine($"Width : {form.Width}, Height : {form.Height}");
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MainApp
			// 
			this.ClientSize = new System.Drawing.Size(543, 322);
			this.Name = "Change_Form_Size";
			this.ResumeLayout(false);
		}
	}
}
