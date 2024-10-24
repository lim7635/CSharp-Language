using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class8th_Number_Game_
{
    public partial class Form1 : Form
    {
        private int findnumber = 0;
        private int chance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random(); // 난수 생성
            findnumber = rand.Next(1, 21); // 1 ~ 20 사이의 임의의 값 저장
            chance = 10;
            label1.Text = "맞출 숫자를 입력하세요.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputnumber = Int32.Parse(textBox1.Text);

            if(inputnumber == findnumber)
            {
                label1.Text = "승리했습니다!!!";
            }
            else
            {
                chance--;
                label1.Text = "기회는 " + chance + "번 남았습니다.";
            }

            if(chance <= 0)
            {
                label1.Text = "게임에 실패했습니다...";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
