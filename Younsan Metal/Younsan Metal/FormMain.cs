using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Younsan_Metal
{
    public partial class FormMain : Form
    {
        private long lCount = 0;
        private int iVal1 = 0, iVal2 = 0;
        private double dADCVal1 = 0, dADCVal2 = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        //===================================================================================//
        /// <summary>
        /// 
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // MainForm 속성을 자기 자신으로 설정합니다.
            smartForm1.MainForm = this;

            Fn_smartGPIO_Start();

            Fn_InputCounter_Start();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FormMain_Closing(object sender, CancelEventArgs e)
        {
            Fn_smartGPIO_Stop();
            Fn_InputCounter_Stop();
            // 실행중인 모든 프로세스를 종료 후 응용 프로그램 종료
            smartForm1.Close();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Fn_InputCounter_Start();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Fn_InputCounter_Stop();
        }

        /// <summary>
        /// smartTimer Tick 이벤트
        /// </summary>
        private void smartTimer1_Tick(object sender, EventArgs e)
        {
            // InputcounterA1 블록 - CounterPin1의 Rotary Encoder의 값을 읽음
            lCount = smartInputCounter1.InputCounterA1.EncoderCounterCh1;

            Lbl_RotaryEncoderVal.Text = lCount.ToString();

            // SmartADC 블록 : IEC667, IEC1000은 12bit(4096)
            iVal1 = smartADC1.ReadData(0);
            //iVal1 = smartADC1.ReadDataDetailFiltering(0, 500, 400);
            dADCVal1 = ((double)iVal1 / 4096);
            //Adc0_DataParsing(iVal);

            Lbl_AdcVal1.Text = dADCVal1.ToString("F4");

            iVal2 = smartADC1.ReadData(1);
            dADCVal2 = ((double)iVal2 / 4096);
            //Adc0_DataParsing(iVal);

            Lbl_AdcVal2.Text = dADCVal2.ToString("F4");
        }

        //===================================================================================//
        #region Inputcounter Block
        /// <summary>
        /// Inputcounter블록 - CounterPin Counting 시작
        /// </summary>
        private void Fn_InputCounter_Start()
        {
            Btn_Start.Enabled = false;
            Btn_Stop.Enabled = true;

            // InputcounterA1 블록 - CounterPin1의 Port Mode를 InputCounter로 설정
            smartInputCounter1.InputCounterA1.PortMode = SmartX.SmartInputCounter.PORTMODES.Used;
            if (smartInputCounter1.InputCounterA1.Initialize() == true)
            {
                // InputcounterA1 블록 - CounterPin1의 Counting 시작
                smartInputCounter1.InputCounterA1.RunCounterPin1();
                // SmartTimer 시작
                smartTimer1.Start();
            }
        }

        /// <summary>
        /// Inputcounter블록 - CounterPin Counting 중지
        /// </summary>
        private void Fn_InputCounter_Stop()
        {
            Btn_Start.Enabled = true;
            Btn_Stop.Enabled = false;

            // SmartTimer 중지
            smartTimer1.Stop();
            // InputcounterB2 블록 - CounterPin1의 Counting 중지
            smartInputCounter1.InputCounterA1.PauseCounterPin1();
        }
        #endregion

        //===================================================================================//
        #region SmartGPIO - Relay
        /// <summary>
        /// Port 상태를 변경하는 버튼을 클릭했을 때 발생하는 이벤트
        /// </summary>
        private void PortOutData_Click(object sender, EventArgs e)
        {
            if (sender == Btn_Relay1)
            {
                // Relay ON
                if (Btn_Relay1.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
                {
                    smartGPIO1.Data4 = SmartX.SmartGPIO.PinStatus.High;
                    Btn_Relay1.ButtonText = "High";
                }
                // Relay OFF
                else if (Btn_Relay1.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
                {
                    smartGPIO1.Data4 = SmartX.SmartGPIO.PinStatus.Low;
                    Btn_Relay1.ButtonText = "Low";
                }
            }

            if (sender == Btn_Relay2)
            {
                // Relay ON
                if (Btn_Relay2.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
                {
                    smartGPIO1.Data5 = SmartX.SmartGPIO.PinStatus.High;
                    Btn_Relay2.ButtonText = "High";
                }
                // Relay OFF
                else if (Btn_Relay2.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
                {
                    smartGPIO1.Data5 = SmartX.SmartGPIO.PinStatus.Low;
                    Btn_Relay2.ButtonText = "Low";
                }
            }

            if (sender == Btn_Relay3)
            {
                // Relay ON
                if (Btn_Relay3.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
                {
                    smartGPIO1.Data6 = SmartX.SmartGPIO.PinStatus.High;
                    Btn_Relay3.ButtonText = "High";
                }
                // Relay OFF
                else if (Btn_Relay3.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
                {
                    smartGPIO1.Data6 = SmartX.SmartGPIO.PinStatus.Low;
                    Btn_Relay3.ButtonText = "Low";
                }
            }

            if (sender == Btn_Relay4)
            {
                // Relay ON
                if (Btn_Relay4.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
                {
                    smartGPIO1.Data7 = SmartX.SmartGPIO.PinStatus.High;
                    Btn_Relay4.ButtonText = "High";
                }
                // Relay OFF
                else if (Btn_Relay4.ButtonStatus == SmartX.SmartButton.BUTSTATUS.UP)
                {
                    smartGPIO1.Data7 = SmartX.SmartGPIO.PinStatus.Low;
                    Btn_Relay4.ButtonText = "Low";
                }
            }
        }


        /// <summary>
        /// PORTB DATA변경 이벤트 Start
        /// </summary>
        private void Fn_smartGPIO_Start()
        {
            smartGPIO1.PortWatchStart();
        }

        /// <summary>
        /// PORTB DATA변경 이벤트 Stop
        /// </summary>
        private void Fn_smartGPIO_Stop()
        {
            smartGPIO1.PortWatchStop();
        }

        /// <summary>
        /// PORTB의 상태변경이 감지 되었을 때 발생되는 이벤트
        /// </summary>
        private void smartGPIO1_OnPortDatasChange(int iPortDatas)
        {
            SmartGPIO_Parsing(iPortDatas);
        }

        // PORTB의 상태변경 이벤트 처리함수
        private void SmartGPIO_Parsing(int iPortDatas)
        {
            // B0. Input0 체크
            if ((iPortDatas & 0x01) == 0x01) // PortB의 0번 비트가 1이면
                Lbl_InputVal1.Text = "Low";
            else
                Lbl_InputVal1.Text = "High";

            //// B1. Input1 체크
            //if ((iPortDatas & 0x02) == 0x02)
            //    Lbl_InputVal2.Text = "Low";
            //else
            //    Lbl_InputVal2.Text = "High";

            //// B2. Input2 체크
            //if ((iPortDatas & 0x04) == 0x04)
            //    Lbl_InputVal3.Text = "Low";
            //else
            //    Lbl_InputVal3.Text = "High";

            //// B4. Input0 체크
            //if ((iPortDatas & 0x16) == 0x16)
            //    Lbl_InputVal4.Text = "Low";
            //else
            //    Lbl_InputVal4.Text = "High";
        }
        #endregion

        //===================================================================================//
        #region SmartADC Block
        // 센서 특성상 선형적이지 않을경우 구간별로 측정해야 합니다. 
        // ADC0 센서값을 거리로 계산해주는 공식. 20cm ~ 50cm 구간 사이 변환 공식
        // 본 코드는 AD값으로 거리를 계산하는 공식이며 AD값에 따라 거리값의 증/감이 비교적 비례하는 구간을 계산한 공식입니다. 
        // AD값의 구간별로 정확하게 거리를 계산하기위해서는 AD구간별로 계산공식이 필요합니다. 
        private void Adc0_DataParsing(double val)
        {
            // 거리센서의 ADC값 = 1064는 거리20cm, ADC값 = 491은 거리50cm 입니다. 
            // ADC값 1064 - 491 = 573(ADC구간) 이고 20cm ~ 50cm(ADC의 거리구간) 
            // 계산공식은 573 : 30 = (1064 - val) : x 의 결과값에 20(출발점)을 더합니다. 
            //LblAdc0.Text = val.ToString();                                            // ADC값
            //LblAdc0_1.Text = Math.Round(((((1064 - val) * 30) / 573) + 20), 0).ToString() + "cm";    // 거리값
        }
        #endregion
    }
}