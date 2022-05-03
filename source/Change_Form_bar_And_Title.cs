using System;
using System.Windows.Forms;

namespace Change_Form_bar_And_Title
{
	class MainApp : Form
	{
		static void Main(string[] args)
		{
			MainApp form = new MainApp();

			form.Width = 400;
			form.MouseDown += new MouseEventHandler(form_MouseDown);

			Application.Run(form);
		}

		static void form_MouseDown(object sender, MouseEventArgs e)
		{
			Form form = (Form)sender;

			if(e.Button == MouseButtons.Left)                           // 마우스 왼쪽 클릭
			{
				form.MaximizeBox = true;								// 최대화 버튼
				form.MinimizeBox = true;								// 최소화 버튼
				form.Text = "최대화/최대화 버튼이 활성화 되었습니다.";		// 상단바 타이틀
			}

			else if (e.Button == MouseButtons.Right)					// 마우스 오른쪽 클릭
			{
				form.MaximizeBox = false;                               // 최대화 버튼
				form.MinimizeBox = false;								// 최소화 버튼
				form.Text = "최대화/최대화 버튼이 비활성화 되었습니다.";	// 상단바 타이틀
			}
		}
	}
}
