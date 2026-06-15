using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Parking
{
    public partial class Form3 : Form
    {
        DateTime inTime;
        int fee = 0;
        List<string> list = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // 상태표시줄에 현재 날짜 및 시간 출력
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCarNum.Text == "")
            {
                MessageBox.Show("차량번호를 입력하세요.");
                txtCarNum.Focus();
                return;
            }

            // 저장파일명을 문자열 변수에 저장
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";

            // 해당 파일이 없으면 입차기록이 없다고 알려주고 끝냄
            if (!File.Exists(fileName))
            {
                MessageBox.Show("입차기록이 없습니다.");
                return;
            }

            // 파일에서 모든 내용을 읽어 와서 검색하려고 하는 자동차 번호인지 확인하고
            // 요금을 계산하는 일을 한다.            
            TimeSpan parkingTime; // 시간 간격을 관리하는 구조체
            string line;
            string[] data;
            StreamReader sr = new StreamReader(fileName);
            while ((line = sr.ReadLine()) != null)
            {
                string[] info = line.Split(',');
                if (info[0].Contains(txtCarNum.Text))
                {
                    /// 출차시간 - 입차시간 = 주차시간
                    inTime = DateTime.Parse(info[1]);
                    parkingTime = DateTime.Now - inTime;
                    /// 주차시간에 해당하는 결제금액 계산
                    fee = CalculateFee(parkingTime);
                    /// 레이블 3, 5, 9에 각각 차량번호, 결제금액, 주차시간 출력
                    label3.Text = info[0];
                    label5.Text = fee.ToString("N0") + "원";
                    label9.Text = parkingTime.Hours.ToString() + "시간 "
                        + parkingTime.Minutes.ToString() + "분"
                        + parkingTime.Seconds.ToString() + "초";

                    return;
                }
            }

            MessageBox.Show("해당하는 차량이 없습니다.");
        }
        private int CalculateFee(TimeSpan parkingTime) // 요금 계산하기
        {
            double totalMinutes = parkingTime.TotalMinutes;
            if (totalMinutes <= 30)
            {
                return 1000;
            }

            double extraMinutes = totalMinutes - 30;
            int extraMoney = (int)(Math.Ceiling(extraMinutes / 10));
            int money = 1000 + extraMoney;
            return money; // 요금계산하고 리턴
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string carNo = label3.Text;
            if (carNo == "")
            {
                MessageBox.Show("차량을 검색해 주세요.");
                txtCarNum.Focus();
                return;
            }

            // 요금 계산하고 계산된 차량은 파일에서 삭제
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 상태표시줄에 날짜 및 시간 표시
            tsslDateTime.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }
    }
}
