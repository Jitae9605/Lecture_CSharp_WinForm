using System;
using System.Windows.Forms;

namespace SimpleWindow
{
	class MessageFilter : IMessageFilter
	{
		// 메세지필터(특정 키/조작 등을 어플리케이션에서 받아즐이지 않는것)
		public bool PreFilterMessage(ref Message m)
		{
			// 0x0f == WM_PAINT, 0x200 == WM_MOUSEMOVE, 0x113 == WM_TIMER
			if (m.Msg == 0x0F || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x113)
				return false;

			// 모든 발생하는 이벤트/조작 등의 메세지 발생 상황에서 해당 메세지의 내용과 이름을 출력함
			Console.WriteLine($"{m.ToString()} : {m.Msg}");


			// 0x201 == WM_LBUTTENDOWN
			if (m.Msg == 0x201)
				Application.Exit();

			return true;
		}
	}
	class MouseEventTest_X_Y : Form
	{
		static void Main(string[] args)
		{
			MouseEventTest_X_Y form = new MainApp();
			Application.AddMessageFilter(new MessageFilter());      // 메세지 필터 활성화
			Application.Run(form);                                  // form 실행

		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MainApp
			// 
			this.ClientSize = new System.Drawing.Size(543, 322);
			this.Name = "MainApp";
			this.ResumeLayout(false);

		}
	}
}
