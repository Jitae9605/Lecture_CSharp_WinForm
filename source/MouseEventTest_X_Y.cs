using System;
using System.Windows.Forms;

namespace MouseEventTest_X_Y
{
	class MouseEventTest_X_Y : Form
	{
		public void MyMouseHandler(object sender, MouseEventArgs e)
		{
			Console.WriteLine($"Sender : {((Form)sender).Text}");
			Console.WriteLine($"X:{e.X} , Y:{e.Y}");
			Console.WriteLine($"Button:{e.Button}, Clicks:{e.Clicks}");
			Console.WriteLine();
		}

		public MouseEventTest_X_Y(string title)
		{
			this.Text = title;
			this.MouseDown += new MouseEventHandler(MyMouseHandler);
		}

		static void Main(string[] args)
		{
			MouseEventTest_X_Y form = new MouseEventTest_X_Y("Mouse Event Test");

			

			

			
			Application.Run(form);									// form 실행
			
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MainApp
			// 
			this.ClientSize = new System.Drawing.Size(543, 322);
			this.Name = "MouseEventTest_X_Y";
			this.ResumeLayout(false);

		}
	}
}
