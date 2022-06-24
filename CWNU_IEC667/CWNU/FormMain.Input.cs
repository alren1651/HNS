using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CWNU
{
    public partial class FormMain : Form
    {
        // PORTB의 상태변경이 감지되었을 때 발생되는 이벤트
        private void smartGPIO1_OnPortDatasChange(int iPortDatas)
        {
            // Auto 모드일 경우만 동작
            if (Draft_CtrlMode_Auto == true)
            {
                SmartX.SmartGPIO.PORTPIN iBit;

                // 입력 신호가 변경된 핀을 체크(HIGH -> LOW, LOW -> HIGH)
                //SmartX.SmartGPIO.PORTPIN iBit = smartGPIO1.PortDetection(SmartX.SmartGPIO.PORTID.PORTB, SmartX.SmartGPIO.TRIGGERMODE.LevelChange, iPortDatas);

                // 현재 Pin의 상태를 읽은 후 입력 신호가 변경된 핀을 체크 (HIGH -> LOW)
                iBit = smartGPIO1.PortDetection(SmartX.SmartGPIO.PORTID.PORTB, SmartX.SmartGPIO.TRIGGERMODE.HighActive, iPortDatas);
                // Counting
                if (iBit == SmartX.SmartGPIO.PORTPIN.PIN0)
                {
                    // 라벨에 데이터를 표시
                    Lbl_Level_LH.Text = "Left ON";

                    // Switch On 시 Servo Motor 제어 (90˚ -> 180˚)
                    F_Ctrl_PumpOpen_LH();
                }

                if (iBit == SmartX.SmartGPIO.PORTPIN.PIN1)
                {
                    // 라벨에 데이터를 표시
                    Lbl_Level_RH.Text = "Right ON";

                    // Switch On 시 Servo Motor 제어 (90˚ -> 180˚)
                    F_Ctrl_PumpOpen_RH();
                }

                // 현재 Pin의 상태를 읽은 후 입력 신호가 변경된 핀을 체크 (LOW -> HIGH)
                iBit = smartGPIO1.PortDetection(SmartX.SmartGPIO.PORTID.PORTB, SmartX.SmartGPIO.TRIGGERMODE.LowActive, iPortDatas);
                if (iBit == SmartX.SmartGPIO.PORTPIN.PIN0)
                {
                    // 라벨에 데이터를 표시
                    Lbl_Level_LH.Text = "Left OFF";

                    // Switch OFF 시 Servo Motor 제어 (180˚ -> 90˚)
                    F_Ctrl_PumpClose_LH();
                }

                if (iBit == SmartX.SmartGPIO.PORTPIN.PIN1)
                {
                    // 라벨에 데이터를 표시
                    Lbl_Level_RH.Text = "Right OFF";

                    // Switch OFF 시 Servo Motor 제어 (180˚ -> 90˚)
                    F_Ctrl_PumpClose_RH();
                }
            }
        }
    }
}
