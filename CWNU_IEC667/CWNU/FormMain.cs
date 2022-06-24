using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CWNU
{
    public partial class FormMain : Form
    {
        private bool Draft_CtrlMode_Auto = true;

        public FormMain()
        {
            InitializeComponent();
        }

        // ============================================================================================== //
        // 폼 로드시 실행
        private void FormMain_Load(object sender, EventArgs e)
        {
            smartForm1.MainForm = this;

            // -------------------------------------------------------------------------- //
            // smartGPIO
            smartGPIO1.PortSelect = SmartX.SmartGPIO.PORTID.PORTB;    // 입출력 포트를 A포트로 설정
            smartGPIO1.PortDirs = 0;           // PORTB GPIO 방향설정 (ALL INPUT)
            smartGPIO1.PortDatas = 0;          // PORTB DATA 설정     (ALL LOW)
            smartGPIO1.PortDetection_Initialize();

            // -------------------------------------------------------------------------- //
            // smartPWM
            smartPWM1.PreScaler = Prescaler;
            // PWM1 설정
            smartPWM1.DutyRate1 = DutyRate_PWM1;
            smartPWM1.PWMCounter1 = Counter_PWM1;
            smartPWM1.ClockDivider1 = ClockDivide_PWM1;
            smartPWM1.Polarity1 = Polarity_PWM1;
            // PWM2 설정
            smartPWM1.DutyRate2 = DutyRate_PWM2;
            smartPWM1.PWMCounter2 = Counter_PWM2;
            smartPWM1.ClockDivider2 = ClockDivide_PWM2;
            smartPWM1.Polarity2 = Polarity_PWM2;
            // DeadTime 초기 값 표시 및 설정
            smartPWM1.DeadTime = DeadTime;

            // -------------------------------------------------------------------------- //
            try
            {
                // GPIO Start
                smartGPIO1.PortWatchStart();       // PORTB DATA변경 이벤트 스타트

                // PWM Start
                smartPWM1.StartPWM1();
                smartPWM1.StartPWM2();
            }
            catch (Exception ex)
            {

            }
        }

        // ============================================================================================== //
        // 폼이 종료되기 전 실행
        private void FormMain_Closing(object sender, CancelEventArgs e)
        {
            // PORTB DATA변경 이벤트 스톱
            smartGPIO1.PortWatchStop();

            // Stop smartPWM1
            smartPWM1.StopPWM1();
            smartPWM1.StopPWM2();
        }

        // ============================================================================================== //
        // 흘수 제어모드 버튼 처리
        private void Btn_CtrlMode_Click(object sender, EventArgs e)
        {
            if (Btn_CtrlMode.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
            {
                // Draft Control Mode = Manual
                Draft_CtrlMode_Auto = false;

                Btn_CtrlMode.ButtonText = "MANUAL";
            }
            else if (Btn_CtrlMode.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
            {
                // Draft Control Mode = Auto
                Draft_CtrlMode_Auto = true;

                Btn_CtrlMode.ButtonText = "AUTO";
            }
        }
    }
}