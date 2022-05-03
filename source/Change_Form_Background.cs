using System;
using System.Drawing;
using System.Windows.Forms;

namespace Change_Form_Background
{
	class MainApp : Form
	{
		
		Random rand;	// 무작위 난수 생성
		public MainApp()
		{
			rand = new Random();

			// 마우스 휠에 기능 할당
			this.MouseWheel += new MouseEventHandler(MainApp_MouseWheel);

			// 마우스 클릭에 기능 할당
			this.MouseDown += new MouseEventHandler(MainApp_MouseDown);

		}

		void MainApp_MouseDown(object sender, MouseEventArgs e)
		{
			// 폼 백그라운드 색상 및 사진 등의 이미지 삽입
			if(e.Button == MouseButtons.Left)	// 왼쪽마우스버튼 클릭시 색랜덤 변경
			{
				Color oldColor = this.BackColor;
				this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
			}

			else if (e.Button == MouseButtons.Right)    // 오른쪽 마우스버튼 클릭시 파일경로의 "sample.jpg"를 백그라운드이미지로 등록
			{
				if(this.BackgroundImage != null)
				{
					this.BackgroundImage = null;
					return;
				}

				string file = "sample.jpg";
				if (System.IO.File.Exists(file) == false)
					MessageBox.Show("이미지 파일이 없습니다.");
				else
					this.BackgroundImage = Image.FromFile(file);
			}
		}

		void MainApp_MouseWheel(object sender, MouseEventArgs e)
		{
			// 불투명도 조정
			this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);	// e.delta = 마우스 휠동작(+:위, -:아래 방향 스크롤)
			Console.WriteLine($"Opacity : {this.Opacity}");
		}

		static void Main(string[] args)
		{
			Application.Run(new MainApp());
		}
	}
}
