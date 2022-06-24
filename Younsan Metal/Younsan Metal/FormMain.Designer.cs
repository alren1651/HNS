namespace Younsan_Metal
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.smartForm1 = new SmartX.SmartForm();
            this.smartGroupBox4 = new SmartX.SmartGroupBox();
            this.Lbl_AdcVal2 = new SmartX.SmartLabel();
            this.Lbl_AdcVal1 = new SmartX.SmartLabel();
            this.smartGroupBox3 = new SmartX.SmartGroupBox();
            this.Btn_Relay4 = new SmartX.SmartButton();
            this.Btn_Relay3 = new SmartX.SmartButton();
            this.Btn_Relay2 = new SmartX.SmartButton();
            this.Btn_Relay1 = new SmartX.SmartButton();
            this.smartGroupBox2 = new SmartX.SmartGroupBox();
            this.Lbl_InputVal1 = new SmartX.SmartLabel();
            this.Btn_Stop = new SmartX.SmartButton();
            this.Btn_Start = new SmartX.SmartButton();
            this.smartGroupBox1 = new SmartX.SmartGroupBox();
            this.Lbl_RotaryEncoderVal = new SmartX.SmartLabel();
            this.smartTimer1 = new SmartX.SmartTimer();
            this.smartInputCounter1 = new SmartX.SmartInputCounter();
            this.smartGPIO1 = new SmartX.SmartGPIO(this.components);
            this.smartADC1 = new SmartX.SmartADC();
            this.smartForm1.SuspendLayout();
            this.smartGroupBox4.SuspendLayout();
            this.smartGroupBox3.SuspendLayout();
            this.smartGroupBox2.SuspendLayout();
            this.smartGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smartForm1
            // 
            this.smartForm1.BackGroundFillStyle = SmartXUIBase.SmartUIControlFormBase.BackGroundFillStyles.GradationColor1;
            this.smartForm1.BackImage = ((System.Drawing.Image)(resources.GetObject("smartForm1.BackImage")));
            this.smartForm1.CenterLocation = false;
            this.smartForm1.Controls.Add(this.smartGroupBox4);
            this.smartForm1.Controls.Add(this.smartGroupBox3);
            this.smartForm1.Controls.Add(this.smartGroupBox2);
            this.smartForm1.Controls.Add(this.Btn_Stop);
            this.smartForm1.Controls.Add(this.Btn_Start);
            this.smartForm1.Controls.Add(this.smartGroupBox1);
            this.smartForm1.GradationColorBottom = System.Drawing.Color.Gray;
            this.smartForm1.GradationColorTop = System.Drawing.Color.White;
            this.smartForm1.LCDDirection = SmartXUIBase.SmartUIControlFormBase.LCDDIRECTIONS.HORIZONTAL;
            this.smartForm1.LCDSize = SmartXUIBase.SmartUIControlFormBase.LCDRESOLUTION.LCD800X600;
            this.smartForm1.Location = new System.Drawing.Point(0, 0);
            this.smartForm1.MainForm = null;
            this.smartForm1.Mode = SmartXUIBase.SmartUIControlFormBase.RUNMODE.DEVELOPER;
            this.smartForm1.MouseCursor = SmartX.SmartForm.OnOff.ON;
            this.smartForm1.Name = "smartForm1";
            this.smartForm1.Size = new System.Drawing.Size(800, 600);
            this.smartForm1.SpecialFunctionClickPointSize = 100;
            this.smartForm1.UseMainMenu = false;
            // 
            // smartGroupBox4
            // 
            this.smartGroupBox4.BackGround = null;
            this.smartGroupBox4.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox4.BackImage = null;
            this.smartGroupBox4.Controls.Add(this.Lbl_AdcVal2);
            this.smartGroupBox4.Controls.Add(this.Lbl_AdcVal1);
            this.smartGroupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.smartGroupBox4.FrameLineColor1 = System.Drawing.Color.Navy;
            this.smartGroupBox4.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox4.FrameLineThickness = 2;
            this.smartGroupBox4.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox4.HeaderHeightOffset = 5;
            this.smartGroupBox4.Location = new System.Drawing.Point(20, 400);
            this.smartGroupBox4.Name = "smartGroupBox4";
            this.smartGroupBox4.RoundRadius = 5;
            this.smartGroupBox4.Size = new System.Drawing.Size(530, 175);
            this.smartGroupBox4.TabIndex = 6;
            this.smartGroupBox4.Text = "A/D 변환 Monitoring";
            this.smartGroupBox4.TextColor = System.Drawing.Color.White;
            // 
            // Lbl_AdcVal2
            // 
            this.Lbl_AdcVal2.BackGround = null;
            this.Lbl_AdcVal2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_AdcVal2.BorderColor = System.Drawing.Color.DarkGray;
            this.Lbl_AdcVal2.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_AdcVal2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Lbl_AdcVal2.LineSpacing = 0F;
            this.Lbl_AdcVal2.Location = new System.Drawing.Point(290, 55);
            this.Lbl_AdcVal2.Name = "Lbl_AdcVal2";
            this.Lbl_AdcVal2.OverlapOptimize = true;
            this.Lbl_AdcVal2.PasswordChar = '\0';
            this.Lbl_AdcVal2.Radius = 10;
            this.Lbl_AdcVal2.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_AdcVal2.Size = new System.Drawing.Size(200, 50);
            this.Lbl_AdcVal2.TabIndex = 0;
            this.Lbl_AdcVal2.Text = "0.0";
            this.Lbl_AdcVal2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_AdcVal2.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_AdcVal2.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_AdcVal2.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_AdcVal2.Wordwrap = false;
            // 
            // Lbl_AdcVal1
            // 
            this.Lbl_AdcVal1.BackGround = null;
            this.Lbl_AdcVal1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_AdcVal1.BorderColor = System.Drawing.Color.DarkGray;
            this.Lbl_AdcVal1.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_AdcVal1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Lbl_AdcVal1.LineSpacing = 0F;
            this.Lbl_AdcVal1.Location = new System.Drawing.Point(40, 55);
            this.Lbl_AdcVal1.Name = "Lbl_AdcVal1";
            this.Lbl_AdcVal1.OverlapOptimize = true;
            this.Lbl_AdcVal1.PasswordChar = '\0';
            this.Lbl_AdcVal1.Radius = 10;
            this.Lbl_AdcVal1.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_AdcVal1.Size = new System.Drawing.Size(200, 50);
            this.Lbl_AdcVal1.TabIndex = 0;
            this.Lbl_AdcVal1.Text = "0.0";
            this.Lbl_AdcVal1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_AdcVal1.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_AdcVal1.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_AdcVal1.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_AdcVal1.Wordwrap = false;
            // 
            // smartGroupBox3
            // 
            this.smartGroupBox3.BackGround = null;
            this.smartGroupBox3.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox3.BackImage = null;
            this.smartGroupBox3.Controls.Add(this.Btn_Relay4);
            this.smartGroupBox3.Controls.Add(this.Btn_Relay3);
            this.smartGroupBox3.Controls.Add(this.Btn_Relay2);
            this.smartGroupBox3.Controls.Add(this.Btn_Relay1);
            this.smartGroupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.smartGroupBox3.FrameLineColor1 = System.Drawing.Color.Navy;
            this.smartGroupBox3.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox3.FrameLineThickness = 2;
            this.smartGroupBox3.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox3.HeaderHeightOffset = 5;
            this.smartGroupBox3.Location = new System.Drawing.Point(20, 250);
            this.smartGroupBox3.Name = "smartGroupBox3";
            this.smartGroupBox3.RoundRadius = 5;
            this.smartGroupBox3.Size = new System.Drawing.Size(760, 130);
            this.smartGroupBox3.TabIndex = 5;
            this.smartGroupBox3.Text = "Relay";
            this.smartGroupBox3.TextColor = System.Drawing.Color.White;
            // 
            // Btn_Relay4
            // 
            this.Btn_Relay4.BackGround = null;
            this.Btn_Relay4.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Relay4.ButtonColor = System.Drawing.Color.DarkGray;
            this.Btn_Relay4.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Relay4.ButtonImageAutoSize = true;
            this.Btn_Relay4.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Relay4.ButtonText = "Low";
            this.Btn_Relay4.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Relay4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Btn_Relay4.GroupID = 0;
            this.Btn_Relay4.ImageDisable = null;
            this.Btn_Relay4.ImageDown = null;
            this.Btn_Relay4.ImageUp = null;
            this.Btn_Relay4.Location = new System.Drawing.Point(570, 55);
            this.Btn_Relay4.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Relay4.Name = "Btn_Relay4";
            this.Btn_Relay4.NestedClickEventPrevent = false;
            this.Btn_Relay4.OutlinePixel = 2;
            this.Btn_Relay4.OverlapOptimize = true;
            this.Btn_Relay4.RepeatInterval = 200;
            this.Btn_Relay4.RepeatIntervalAccelerate = null;
            this.Btn_Relay4.RoundSize = 10;
            this.Btn_Relay4.SafeInterval = 200;
            this.Btn_Relay4.Size = new System.Drawing.Size(160, 50);
            this.Btn_Relay4.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Relay4.TabIndex = 0;
            this.Btn_Relay4.Text = null;
            this.Btn_Relay4.TextColor = System.Drawing.Color.Black;
            this.Btn_Relay4.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Relay4.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Relay4.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Relay4.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Relay4.Click += new System.EventHandler(this.PortOutData_Click);
            // 
            // Btn_Relay3
            // 
            this.Btn_Relay3.BackGround = null;
            this.Btn_Relay3.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Relay3.ButtonColor = System.Drawing.Color.DarkGray;
            this.Btn_Relay3.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Relay3.ButtonImageAutoSize = true;
            this.Btn_Relay3.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Relay3.ButtonText = "Low";
            this.Btn_Relay3.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Relay3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Btn_Relay3.GroupID = 0;
            this.Btn_Relay3.ImageDisable = null;
            this.Btn_Relay3.ImageDown = null;
            this.Btn_Relay3.ImageUp = null;
            this.Btn_Relay3.Location = new System.Drawing.Point(390, 55);
            this.Btn_Relay3.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Relay3.Name = "Btn_Relay3";
            this.Btn_Relay3.NestedClickEventPrevent = false;
            this.Btn_Relay3.OutlinePixel = 2;
            this.Btn_Relay3.OverlapOptimize = true;
            this.Btn_Relay3.RepeatInterval = 200;
            this.Btn_Relay3.RepeatIntervalAccelerate = null;
            this.Btn_Relay3.RoundSize = 10;
            this.Btn_Relay3.SafeInterval = 200;
            this.Btn_Relay3.Size = new System.Drawing.Size(160, 50);
            this.Btn_Relay3.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Relay3.TabIndex = 0;
            this.Btn_Relay3.Text = null;
            this.Btn_Relay3.TextColor = System.Drawing.Color.Black;
            this.Btn_Relay3.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Relay3.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Relay3.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Relay3.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Relay3.Click += new System.EventHandler(this.PortOutData_Click);
            // 
            // Btn_Relay2
            // 
            this.Btn_Relay2.BackGround = null;
            this.Btn_Relay2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Relay2.ButtonColor = System.Drawing.Color.DarkGray;
            this.Btn_Relay2.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Relay2.ButtonImageAutoSize = true;
            this.Btn_Relay2.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Relay2.ButtonText = "Low";
            this.Btn_Relay2.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Relay2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Btn_Relay2.GroupID = 0;
            this.Btn_Relay2.ImageDisable = null;
            this.Btn_Relay2.ImageDown = null;
            this.Btn_Relay2.ImageUp = null;
            this.Btn_Relay2.Location = new System.Drawing.Point(210, 55);
            this.Btn_Relay2.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Relay2.Name = "Btn_Relay2";
            this.Btn_Relay2.NestedClickEventPrevent = false;
            this.Btn_Relay2.OutlinePixel = 2;
            this.Btn_Relay2.OverlapOptimize = true;
            this.Btn_Relay2.RepeatInterval = 200;
            this.Btn_Relay2.RepeatIntervalAccelerate = null;
            this.Btn_Relay2.RoundSize = 10;
            this.Btn_Relay2.SafeInterval = 200;
            this.Btn_Relay2.Size = new System.Drawing.Size(160, 50);
            this.Btn_Relay2.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Relay2.TabIndex = 0;
            this.Btn_Relay2.Text = null;
            this.Btn_Relay2.TextColor = System.Drawing.Color.Black;
            this.Btn_Relay2.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Relay2.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Relay2.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Relay2.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Relay2.Click += new System.EventHandler(this.PortOutData_Click);
            // 
            // Btn_Relay1
            // 
            this.Btn_Relay1.BackGround = null;
            this.Btn_Relay1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Relay1.ButtonColor = System.Drawing.Color.DarkGray;
            this.Btn_Relay1.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Relay1.ButtonImageAutoSize = true;
            this.Btn_Relay1.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Relay1.ButtonText = "Low";
            this.Btn_Relay1.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Relay1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Btn_Relay1.GroupID = 0;
            this.Btn_Relay1.ImageDisable = null;
            this.Btn_Relay1.ImageDown = null;
            this.Btn_Relay1.ImageUp = null;
            this.Btn_Relay1.Location = new System.Drawing.Point(30, 55);
            this.Btn_Relay1.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Relay1.Name = "Btn_Relay1";
            this.Btn_Relay1.NestedClickEventPrevent = false;
            this.Btn_Relay1.OutlinePixel = 2;
            this.Btn_Relay1.OverlapOptimize = true;
            this.Btn_Relay1.RepeatInterval = 200;
            this.Btn_Relay1.RepeatIntervalAccelerate = null;
            this.Btn_Relay1.RoundSize = 10;
            this.Btn_Relay1.SafeInterval = 200;
            this.Btn_Relay1.Size = new System.Drawing.Size(160, 50);
            this.Btn_Relay1.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Relay1.TabIndex = 0;
            this.Btn_Relay1.Text = null;
            this.Btn_Relay1.TextColor = System.Drawing.Color.Black;
            this.Btn_Relay1.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Relay1.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Relay1.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Relay1.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Relay1.Click += new System.EventHandler(this.PortOutData_Click);
            // 
            // smartGroupBox2
            // 
            this.smartGroupBox2.BackGround = null;
            this.smartGroupBox2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox2.BackImage = null;
            this.smartGroupBox2.Controls.Add(this.Lbl_InputVal1);
            this.smartGroupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.smartGroupBox2.FrameLineColor1 = System.Drawing.Color.Navy;
            this.smartGroupBox2.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox2.FrameLineThickness = 2;
            this.smartGroupBox2.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox2.HeaderHeightOffset = 5;
            this.smartGroupBox2.Location = new System.Drawing.Point(380, 100);
            this.smartGroupBox2.Name = "smartGroupBox2";
            this.smartGroupBox2.RoundRadius = 5;
            this.smartGroupBox2.Size = new System.Drawing.Size(400, 130);
            this.smartGroupBox2.TabIndex = 4;
            this.smartGroupBox2.Text = "Input";
            this.smartGroupBox2.TextColor = System.Drawing.Color.White;
            // 
            // Lbl_InputVal1
            // 
            this.Lbl_InputVal1.BackGround = null;
            this.Lbl_InputVal1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_InputVal1.BorderColor = System.Drawing.Color.DimGray;
            this.Lbl_InputVal1.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_InputVal1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Lbl_InputVal1.LineSpacing = 0F;
            this.Lbl_InputVal1.Location = new System.Drawing.Point(100, 55);
            this.Lbl_InputVal1.Name = "Lbl_InputVal1";
            this.Lbl_InputVal1.OverlapOptimize = true;
            this.Lbl_InputVal1.PasswordChar = '\0';
            this.Lbl_InputVal1.Radius = 10;
            this.Lbl_InputVal1.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_InputVal1.Size = new System.Drawing.Size(200, 50);
            this.Lbl_InputVal1.TabIndex = 1;
            this.Lbl_InputVal1.Text = "Low";
            this.Lbl_InputVal1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_InputVal1.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_InputVal1.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_InputVal1.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_InputVal1.Wordwrap = false;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.BackGround = null;
            this.Btn_Stop.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Stop.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Btn_Stop.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Stop.ButtonImageAutoSize = true;
            this.Btn_Stop.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Stop.ButtonText = "Stop";
            this.Btn_Stop.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Stop.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Btn_Stop.GroupID = 0;
            this.Btn_Stop.ImageDisable = null;
            this.Btn_Stop.ImageDown = null;
            this.Btn_Stop.ImageUp = null;
            this.Btn_Stop.Location = new System.Drawing.Point(580, 495);
            this.Btn_Stop.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.NestedClickEventPrevent = false;
            this.Btn_Stop.OutlinePixel = 2;
            this.Btn_Stop.OverlapOptimize = true;
            this.Btn_Stop.RepeatInterval = 200;
            this.Btn_Stop.RepeatIntervalAccelerate = null;
            this.Btn_Stop.RoundSize = 10;
            this.Btn_Stop.SafeInterval = 200;
            this.Btn_Stop.Size = new System.Drawing.Size(200, 80);
            this.Btn_Stop.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Stop.TabIndex = 3;
            this.Btn_Stop.Text = null;
            this.Btn_Stop.TextColor = System.Drawing.Color.White;
            this.Btn_Stop.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Stop.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Stop.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Stop.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackGround = null;
            this.Btn_Start.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Start.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Btn_Start.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Start.ButtonImageAutoSize = true;
            this.Btn_Start.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Start.ButtonText = "Start";
            this.Btn_Start.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Start.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Btn_Start.GroupID = 0;
            this.Btn_Start.ImageDisable = null;
            this.Btn_Start.ImageDown = null;
            this.Btn_Start.ImageUp = null;
            this.Btn_Start.Location = new System.Drawing.Point(580, 400);
            this.Btn_Start.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.NestedClickEventPrevent = false;
            this.Btn_Start.OutlinePixel = 2;
            this.Btn_Start.OverlapOptimize = true;
            this.Btn_Start.RepeatInterval = 200;
            this.Btn_Start.RepeatIntervalAccelerate = null;
            this.Btn_Start.RoundSize = 10;
            this.Btn_Start.SafeInterval = 200;
            this.Btn_Start.Size = new System.Drawing.Size(200, 80);
            this.Btn_Start.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = null;
            this.Btn_Start.TextColor = System.Drawing.Color.White;
            this.Btn_Start.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Start.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Start.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Start.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // smartGroupBox1
            // 
            this.smartGroupBox1.BackGround = null;
            this.smartGroupBox1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox1.BackImage = null;
            this.smartGroupBox1.Controls.Add(this.Lbl_RotaryEncoderVal);
            this.smartGroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.smartGroupBox1.FrameLineColor1 = System.Drawing.Color.Navy;
            this.smartGroupBox1.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox1.FrameLineThickness = 2;
            this.smartGroupBox1.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox1.HeaderHeightOffset = 5;
            this.smartGroupBox1.Location = new System.Drawing.Point(20, 100);
            this.smartGroupBox1.Name = "smartGroupBox1";
            this.smartGroupBox1.RoundRadius = 5;
            this.smartGroupBox1.Size = new System.Drawing.Size(340, 130);
            this.smartGroupBox1.TabIndex = 1;
            this.smartGroupBox1.Text = "Rotary Encoder";
            this.smartGroupBox1.TextColor = System.Drawing.Color.White;
            // 
            // Lbl_RotaryEncoderVal
            // 
            this.Lbl_RotaryEncoderVal.BackGround = null;
            this.Lbl_RotaryEncoderVal.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_RotaryEncoderVal.BorderColor = System.Drawing.Color.DarkGray;
            this.Lbl_RotaryEncoderVal.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_RotaryEncoderVal.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.Lbl_RotaryEncoderVal.LineSpacing = 0F;
            this.Lbl_RotaryEncoderVal.Location = new System.Drawing.Point(75, 55);
            this.Lbl_RotaryEncoderVal.Name = "Lbl_RotaryEncoderVal";
            this.Lbl_RotaryEncoderVal.OverlapOptimize = true;
            this.Lbl_RotaryEncoderVal.PasswordChar = '\0';
            this.Lbl_RotaryEncoderVal.Radius = 10;
            this.Lbl_RotaryEncoderVal.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_RotaryEncoderVal.Size = new System.Drawing.Size(200, 50);
            this.Lbl_RotaryEncoderVal.TabIndex = 0;
            this.Lbl_RotaryEncoderVal.Text = "0.0";
            this.Lbl_RotaryEncoderVal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_RotaryEncoderVal.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_RotaryEncoderVal.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_RotaryEncoderVal.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_RotaryEncoderVal.Wordwrap = false;
            // 
            // smartTimer1
            // 
            this.smartTimer1.CounterMode = SmartX.SmartTimer.CounterModes.Up_Counter;
            this.smartTimer1.Interval = 100;
            this.smartTimer1.IntervalSeries = null;
            this.smartTimer1.TimeCount = ((long)(1000000));
            this.smartTimer1.TimeFormStringSeparator = ":";
            this.smartTimer1.Tick += new System.EventHandler(this.smartTimer1_Tick);
            // 
            // smartInputCounter1
            // 
            this.smartInputCounter1.InputCounterA1.CounterDataWidth = SmartX.SmartInputCounter.DATAWIDTH._64BIT;
            this.smartInputCounter1.InputCounterA1.PortMode = SmartX.SmartInputCounter.PORTMODES.Used;
            this.smartInputCounter1.InputCounterA2.CounterDataWidth = SmartX.SmartInputCounter.DATAWIDTH._32BIT;
            this.smartInputCounter1.InputCounterA2.PortMode = SmartX.SmartInputCounter.PORTMODES.NotUsed;
            this.smartInputCounter1.InputCounterB1.CounterDataWidth = SmartX.SmartInputCounter.DATAWIDTH._32BIT;
            this.smartInputCounter1.InputCounterB1.PortMode = SmartX.SmartInputCounter.PORTMODES.NotUsed;
            this.smartInputCounter1.InputCounterB2.CounterDataWidth = SmartX.SmartInputCounter.DATAWIDTH._32BIT;
            this.smartInputCounter1.InputCounterB2.PortMode = SmartX.SmartInputCounter.PORTMODES.NotUsed;
            // 
            // smartGPIO1
            // 
            this.smartGPIO1.Data0 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data1 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data2 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data3 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data4 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data5 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data6 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.Data7 = SmartX.SmartGPIO.PinStatus.Low;
            this.smartGPIO1.DirPin0 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin1 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin2 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin3 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin4 = SmartX.SmartGPIO.PINDIR.OUTPUT;
            this.smartGPIO1.DirPin5 = SmartX.SmartGPIO.PINDIR.OUTPUT;
            this.smartGPIO1.DirPin6 = SmartX.SmartGPIO.PINDIR.OUTPUT;
            this.smartGPIO1.DirPin7 = SmartX.SmartGPIO.PINDIR.OUTPUT;
            this.smartGPIO1.PortDatas = 0;
            this.smartGPIO1.PortDirs = 240;
            this.smartGPIO1.PortSelect = SmartX.SmartGPIO.PORTID.PORTB;
            this.smartGPIO1.OnPortDatasChange += new SmartX.SmartGPIO.PortChangeEventHandler(this.smartGPIO1_OnPortDatasChange);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.smartForm1);
            this.Name = "FormMain";
            this.Text = " TSTE";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormMain_Closing);
            this.smartForm1.ResumeLayout(false);
            this.smartGroupBox4.ResumeLayout(false);
            this.smartGroupBox3.ResumeLayout(false);
            this.smartGroupBox2.ResumeLayout(false);
            this.smartGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartForm smartForm1;
        private SmartX.SmartTimer smartTimer1;
        private SmartX.SmartInputCounter smartInputCounter1;
        private SmartX.SmartButton Btn_Stop;
        private SmartX.SmartButton Btn_Start;
        private SmartX.SmartGroupBox smartGroupBox1;
        private SmartX.SmartLabel Lbl_RotaryEncoderVal;
        private SmartX.SmartGroupBox smartGroupBox4;
        private SmartX.SmartLabel Lbl_AdcVal1;
        private SmartX.SmartGroupBox smartGroupBox3;
        private SmartX.SmartButton Btn_Relay4;
        private SmartX.SmartButton Btn_Relay3;
        private SmartX.SmartButton Btn_Relay2;
        private SmartX.SmartButton Btn_Relay1;
        private SmartX.SmartGroupBox smartGroupBox2;
        private SmartX.SmartLabel Lbl_InputVal1;
        private SmartX.SmartGPIO smartGPIO1;
        private SmartX.SmartADC smartADC1;
        private SmartX.SmartLabel Lbl_AdcVal2;
    }
}

