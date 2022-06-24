using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CWNU
{
    public partial class FormMain : Form
    {
        // PWM의 DeadTime 값을 처리하는 변수선언 및 초기화
        private byte DeadTime = 0;
        // PWM의 프리스케일러의 값을 처리하는 변수선언 및 초기화
        private byte Prescaler = 240;
        // --------------------------------------------------------------------------------------------- //
        // PWM1의 DutyRate, Counter, ClockDiviert, Polarity 변수 선언 및 초기화
        //private double DutyRate_PWM1 = 96.3;
        private double DutyRate_PWM1 = 92.3;
        private uint Counter_PWM1 = 1381;
        private SmartX.SmartPWM.CLOCKDIVIDER ClockDivide_PWM1 = SmartX.SmartPWM.CLOCKDIVIDER.DIVIDE4;
        private SmartX.SmartPWM.POLARITY Polarity_PWM1 = SmartX.SmartPWM.POLARITY.HIGHACTIVE;
        // --------------------------------------------------------------------------------------------- //
        // PWM2의 DutyRate, Counter, ClockDiviert, Polarity 변수 선언 및 초기화
        //private double DutyRate_PWM2 = 96.3;
        private double DutyRate_PWM2 = 92.3;
        private uint Counter_PWM2 = 1381;
        private SmartX.SmartPWM.CLOCKDIVIDER ClockDivide_PWM2 = SmartX.SmartPWM.CLOCKDIVIDER.DIVIDE4;
        private SmartX.SmartPWM.POLARITY Polarity_PWM2 = SmartX.SmartPWM.POLARITY.HIGHACTIVE;


        // ============================================================================================== //
        private void F_Ctrl_PumpOpen_LH()
        {
            // Switch On 시 Servo Motor 제어 (90˚ -> 180˚)
            DutyRate_PWM1 = 92.3;

            for (int i = 0; i < 40; i++)
            {
                // DutyRate 적용
                DutyRate_PWM1 -= 0.1;
                smartPWM1.DutyRate1 = DutyRate_PWM1;
                // Display
                Lbl_Pump_LH.Text = "Left OPEN" + Environment.NewLine + string.Format("{0} %", (i+1) * 2.5).ToString();

                System.Threading.Thread.Sleep(30);
            }
        }

        private void F_Ctrl_PumpClose_LH()
        {
            // Switch Off 시 Servo Motor 제어 (180˚ -> 90˚)
            Lbl_Pump_LH.Text = "Left CLOSE" + Environment.NewLine + "0 %";
            DutyRate_PWM1 = 92.3;
            smartPWM1.DutyRate1 = DutyRate_PWM1;
        }

        // ============================================================================================== //
        private void F_Ctrl_PumpOpen_RH()
        {
            // Switch On 시 Servo Motor 제어 (90˚ -> 180˚)
            DutyRate_PWM2 = 92.3;

            for (int i = 0; i < 40; i++)
            {
                // DutyRate 적용
                DutyRate_PWM2 -= 0.1;
                smartPWM1.DutyRate2 = DutyRate_PWM2;
                // Display
                Lbl_Pump_RH.Text = "Right OPEN" + Environment.NewLine + string.Format("{0} %", (i+1) * 2.5).ToString();

                System.Threading.Thread.Sleep(30);
            }
        }

        private void F_Ctrl_PumpClose_RH()
        {
            // Switch Off 시 Servo Motor 제어 (180˚ -> 90˚)
            Lbl_Pump_RH.Text = "Right CLOSE" + Environment.NewLine + "0 %";
            DutyRate_PWM2 = 92.3;
            smartPWM1.DutyRate2 = DutyRate_PWM2;
        }

        // ============================================================================================== //
        // 펌프 제어 All 버튼 처리
        private void Btn_Pump_ALL_Click(object sender, EventArgs e)
        {
            if (Btn_Pump_ALL.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
            {
                // 각도 제어 : 180˚
                // ServoMotor_LH
                F_Ctrl_PumpOpen_LH();
                // ServoMotor_RH
                F_Ctrl_PumpOpen_RH();
            }
            else if (Btn_Pump_ALL.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
            {
                // 각도 제어 : 90˚
                // ServoMotor_LH
                F_Ctrl_PumpClose_LH();
                // ServoMotor_RH
                F_Ctrl_PumpClose_RH();
            }
        }

        // ============================================================================================== //
        // 펌프 제어 Left 버튼 처리
        private void Btn_Pump_LH_Click(object sender, EventArgs e)
        {
            if (Btn_Pump_LH.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
            {
                // 각도 제어 : 180˚
                // ServoMotor_LH
                F_Ctrl_PumpOpen_LH();
            }
            else if (Btn_Pump_LH.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
            {
                // 각도 제어 : 90˚
                // ServoMotor_LH
                F_Ctrl_PumpClose_LH();
            }
        }

        // ============================================================================================== //
        // 펌프 제어 Right 버튼 처리
        private void Btn_Pump_RH_Click(object sender, EventArgs e)
        {
            if (Btn_Pump_RH.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
            {
                // 각도 제어 : 180˚
                // ServoMotor_RH
                F_Ctrl_PumpOpen_RH();
            }
            else if (Btn_Pump_RH.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
            {
                // 각도 제어 : 90˚
                // ServoMotor_RH
                F_Ctrl_PumpClose_RH();
            }
        }
    }
}
