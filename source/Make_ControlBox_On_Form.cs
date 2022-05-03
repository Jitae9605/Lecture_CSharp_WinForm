using System;
using System.Windows.Forms;

namespace Make_ControlBox_On_Form
{
	class MainApp : Form
	{
		static void Main(string[] args)
		{
			// 버튼정의
			Button button = new Button();

			button.Text = "Click Me!";	// 버튼에 쓰여있을 내용
			button.Left = 100;			// 버튼 위치 - 왼쪽으로 부터 100
			button.Top = 50;			// 버튼 위치 - 위에서부터 50

			// 이벤트 - 버튼클릭시 발동 
			button.Click += (object sender, EventArgs e) =>
			{
				// 딸깍! 이라고 적힌 메세지박스 팝업
				MessageBox.Show("딸깍!");
			};

			// 폼 정의
			MainApp form = new MainApp();
			form.Text = "Form & Control";	// 폼 타이틀
			form.Height = 150;				// 폼 높이 - 150

			// 폼에 버튼 추가
			form.Controls.Add(button);

			// 폼 실행
			Application.Run(form);
		}
	}
}
		