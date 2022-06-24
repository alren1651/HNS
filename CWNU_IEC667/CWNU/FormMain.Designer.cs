namespace CWNU
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
            this.smartGroupBox1 = new SmartX.SmartGroupBox();
            this.Btn_CtrlMode = new SmartX.SmartButton();
            this.smartGroupBox2 = new SmartX.SmartGroupBox();
            this.Btn_Pump_ALL = new SmartX.SmartButton();
            this.Btn_Pump_RH = new SmartX.SmartButton();
            this.Btn_Pump_LH = new SmartX.SmartButton();
            this.smartGroupBox4 = new SmartX.SmartGroupBox();
            this.Lbl_Pump_RH = new SmartX.SmartLabel();
            this.Lbl_Pump_LH = new SmartX.SmartLabel();
            this.smartGroupBox3 = new SmartX.SmartGroupBox();
            this.Lbl_Level_RH = new SmartX.SmartLabel();
            this.Lbl_Level_LH = new SmartX.SmartLabel();
            this.smartPWM1 = new SmartX.SmartPWM(this.components);
            this.smartGPIO1 = new SmartX.SmartGPIO(this.components);
            this.smartForm1.SuspendLayout();
            this.smartGroupBox1.SuspendLayout();
            this.smartGroupBox2.SuspendLayout();
            this.smartGroupBox4.SuspendLayout();
            this.smartGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // smartForm1
            // 
            this.smartForm1.BackGroundFillStyle = SmartXUIBase.SmartUIControlFormBase.BackGroundFillStyles.GradationColor1;
            this.smartForm1.BackImage = ((System.Drawing.Image)(resources.GetObject("smartForm1.BackImage")));
            this.smartForm1.CenterLocation = false;
            this.smartForm1.Controls.Add(this.smartGroupBox1);
            this.smartForm1.Controls.Add(this.smartGroupBox2);
            this.smartForm1.Controls.Add(this.smartGroupBox4);
            this.smartForm1.Controls.Add(this.smartGroupBox3);
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
            // smartGroupBox1
            // 
            this.smartGroupBox1.BackGround = null;
            this.smartGroupBox1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox1.BackImage = null;
            this.smartGroupBox1.Controls.Add(this.Btn_CtrlMode);
            this.smartGroupBox1.FrameLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.smartGroupBox1.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox1.FrameLineThickness = 2;
            this.smartGroupBox1.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox1.HeaderHeightOffset = 5;
            this.smartGroupBox1.Location = new System.Drawing.Point(50, 30);
            this.smartGroupBox1.Name = "smartGroupBox1";
            this.smartGroupBox1.RoundRadius = 5;
            this.smartGroupBox1.Size = new System.Drawing.Size(280, 140);
            this.smartGroupBox1.TabIndex = 4;
            this.smartGroupBox1.Text = "Draft control mode";
            this.smartGroupBox1.TextColor = System.Drawing.Color.White;
            // 
            // Btn_CtrlMode
            // 
            this.Btn_CtrlMode.BackGround = null;
            this.Btn_CtrlMode.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_CtrlMode.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Btn_CtrlMode.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_CtrlMode.ButtonImageAutoSize = true;
            this.Btn_CtrlMode.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_CtrlMode.ButtonText = "AUTO";
            this.Btn_CtrlMode.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_CtrlMode.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_CtrlMode.GroupID = 0;
            this.Btn_CtrlMode.ImageDisable = null;
            this.Btn_CtrlMode.ImageDown = null;
            this.Btn_CtrlMode.ImageUp = null;
            this.Btn_CtrlMode.Location = new System.Drawing.Point(30, 50);
            this.Btn_CtrlMode.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_CtrlMode.Name = "Btn_CtrlMode";
            this.Btn_CtrlMode.NestedClickEventPrevent = false;
            this.Btn_CtrlMode.OutlinePixel = 2;
            this.Btn_CtrlMode.OverlapOptimize = true;
            this.Btn_CtrlMode.RepeatInterval = 200;
            this.Btn_CtrlMode.RepeatIntervalAccelerate = null;
            this.Btn_CtrlMode.SafeInterval = 200;
            this.Btn_CtrlMode.Size = new System.Drawing.Size(220, 70);
            this.Btn_CtrlMode.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_CtrlMode.TabIndex = 2;
            this.Btn_CtrlMode.Text = null;
            this.Btn_CtrlMode.TextColor = System.Drawing.Color.White;
            this.Btn_CtrlMode.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_CtrlMode.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_CtrlMode.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_CtrlMode.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_CtrlMode.Click += new System.EventHandler(this.Btn_CtrlMode_Click);
            // 
            // smartGroupBox2
            // 
            this.smartGroupBox2.BackGround = null;
            this.smartGroupBox2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox2.BackImage = null;
            this.smartGroupBox2.Controls.Add(this.Btn_Pump_ALL);
            this.smartGroupBox2.Controls.Add(this.Btn_Pump_RH);
            this.smartGroupBox2.Controls.Add(this.Btn_Pump_LH);
            this.smartGroupBox2.FrameLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.smartGroupBox2.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox2.FrameLineThickness = 2;
            this.smartGroupBox2.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox2.HeaderHeightOffset = 5;
            this.smartGroupBox2.Location = new System.Drawing.Point(350, 30);
            this.smartGroupBox2.Name = "smartGroupBox2";
            this.smartGroupBox2.RoundRadius = 5;
            this.smartGroupBox2.Size = new System.Drawing.Size(400, 140);
            this.smartGroupBox2.TabIndex = 3;
            this.smartGroupBox2.Text = "워터 펌프 수동 작동";
            this.smartGroupBox2.TextColor = System.Drawing.Color.White;
            // 
            // Btn_Pump_ALL
            // 
            this.Btn_Pump_ALL.BackGround = null;
            this.Btn_Pump_ALL.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Pump_ALL.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Btn_Pump_ALL.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Pump_ALL.ButtonImageAutoSize = true;
            this.Btn_Pump_ALL.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Pump_ALL.ButtonText = "ALL";
            this.Btn_Pump_ALL.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Pump_ALL.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Pump_ALL.GroupID = 0;
            this.Btn_Pump_ALL.ImageDisable = null;
            this.Btn_Pump_ALL.ImageDown = null;
            this.Btn_Pump_ALL.ImageUp = null;
            this.Btn_Pump_ALL.Location = new System.Drawing.Point(150, 50);
            this.Btn_Pump_ALL.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Pump_ALL.Name = "Btn_Pump_ALL";
            this.Btn_Pump_ALL.NestedClickEventPrevent = false;
            this.Btn_Pump_ALL.OutlinePixel = 2;
            this.Btn_Pump_ALL.OverlapOptimize = true;
            this.Btn_Pump_ALL.RepeatInterval = 200;
            this.Btn_Pump_ALL.RepeatIntervalAccelerate = null;
            this.Btn_Pump_ALL.SafeInterval = 200;
            this.Btn_Pump_ALL.Size = new System.Drawing.Size(100, 70);
            this.Btn_Pump_ALL.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Pump_ALL.TabIndex = 5;
            this.Btn_Pump_ALL.Text = null;
            this.Btn_Pump_ALL.TextColor = System.Drawing.Color.White;
            this.Btn_Pump_ALL.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Pump_ALL.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Pump_ALL.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Pump_ALL.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Pump_ALL.Click += new System.EventHandler(this.Btn_Pump_ALL_Click);
            // 
            // Btn_Pump_RH
            // 
            this.Btn_Pump_RH.BackGround = null;
            this.Btn_Pump_RH.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Pump_RH.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Btn_Pump_RH.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Pump_RH.ButtonImageAutoSize = true;
            this.Btn_Pump_RH.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Pump_RH.ButtonText = "R";
            this.Btn_Pump_RH.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Pump_RH.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Pump_RH.GroupID = 0;
            this.Btn_Pump_RH.ImageDisable = null;
            this.Btn_Pump_RH.ImageDown = null;
            this.Btn_Pump_RH.ImageUp = null;
            this.Btn_Pump_RH.Location = new System.Drawing.Point(270, 50);
            this.Btn_Pump_RH.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Pump_RH.Name = "Btn_Pump_RH";
            this.Btn_Pump_RH.NestedClickEventPrevent = false;
            this.Btn_Pump_RH.OutlinePixel = 2;
            this.Btn_Pump_RH.OverlapOptimize = true;
            this.Btn_Pump_RH.RepeatInterval = 200;
            this.Btn_Pump_RH.RepeatIntervalAccelerate = null;
            this.Btn_Pump_RH.SafeInterval = 200;
            this.Btn_Pump_RH.Size = new System.Drawing.Size(100, 70);
            this.Btn_Pump_RH.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Pump_RH.TabIndex = 4;
            this.Btn_Pump_RH.Text = null;
            this.Btn_Pump_RH.TextColor = System.Drawing.Color.White;
            this.Btn_Pump_RH.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Pump_RH.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Pump_RH.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Pump_RH.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Pump_RH.Click += new System.EventHandler(this.Btn_Pump_RH_Click);
            // 
            // Btn_Pump_LH
            // 
            this.Btn_Pump_LH.BackGround = null;
            this.Btn_Pump_LH.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Btn_Pump_LH.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Btn_Pump_LH.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.Btn_Pump_LH.ButtonImageAutoSize = true;
            this.Btn_Pump_LH.ButtonStyle = SmartX.SmartButton.ButtonStyles.Round3D;
            this.Btn_Pump_LH.ButtonText = "L";
            this.Btn_Pump_LH.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.Btn_Pump_LH.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Pump_LH.GroupID = 0;
            this.Btn_Pump_LH.ImageDisable = null;
            this.Btn_Pump_LH.ImageDown = null;
            this.Btn_Pump_LH.ImageUp = null;
            this.Btn_Pump_LH.Location = new System.Drawing.Point(30, 50);
            this.Btn_Pump_LH.Mode = SmartX.SmartButton.BUTTONMODE.PUSH;
            this.Btn_Pump_LH.Name = "Btn_Pump_LH";
            this.Btn_Pump_LH.NestedClickEventPrevent = false;
            this.Btn_Pump_LH.OutlinePixel = 2;
            this.Btn_Pump_LH.OverlapOptimize = true;
            this.Btn_Pump_LH.RepeatInterval = 200;
            this.Btn_Pump_LH.RepeatIntervalAccelerate = null;
            this.Btn_Pump_LH.SafeInterval = 200;
            this.Btn_Pump_LH.Size = new System.Drawing.Size(100, 70);
            this.Btn_Pump_LH.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.Btn_Pump_LH.TabIndex = 3;
            this.Btn_Pump_LH.Text = null;
            this.Btn_Pump_LH.TextColor = System.Drawing.Color.White;
            this.Btn_Pump_LH.TextColorDisable = System.Drawing.Color.Gray;
            this.Btn_Pump_LH.TextDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Btn_Pump_LH.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.Btn_Pump_LH.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.Btn_Pump_LH.Click += new System.EventHandler(this.Btn_Pump_LH_Click);
            // 
            // smartGroupBox4
            // 
            this.smartGroupBox4.BackGround = null;
            this.smartGroupBox4.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox4.BackImage = null;
            this.smartGroupBox4.Controls.Add(this.Lbl_Pump_RH);
            this.smartGroupBox4.Controls.Add(this.Lbl_Pump_LH);
            this.smartGroupBox4.FrameLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.smartGroupBox4.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox4.FrameLineThickness = 2;
            this.smartGroupBox4.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox4.HeaderHeightOffset = 5;
            this.smartGroupBox4.Location = new System.Drawing.Point(50, 360);
            this.smartGroupBox4.Name = "smartGroupBox4";
            this.smartGroupBox4.RoundRadius = 5;
            this.smartGroupBox4.Size = new System.Drawing.Size(700, 200);
            this.smartGroupBox4.TabIndex = 1;
            this.smartGroupBox4.Text = "펌프 작동 상태";
            this.smartGroupBox4.TextColor = System.Drawing.Color.White;
            // 
            // Lbl_Pump_RH
            // 
            this.Lbl_Pump_RH.BackGround = null;
            this.Lbl_Pump_RH.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Pump_RH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Pump_RH.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_Pump_RH.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_Pump_RH.LineSpacing = 0F;
            this.Lbl_Pump_RH.Location = new System.Drawing.Point(370, 65);
            this.Lbl_Pump_RH.Name = "Lbl_Pump_RH";
            this.Lbl_Pump_RH.OverlapOptimize = true;
            this.Lbl_Pump_RH.PasswordChar = '\0';
            this.Lbl_Pump_RH.Radius = 30;
            this.Lbl_Pump_RH.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Pump_RH.Size = new System.Drawing.Size(250, 100);
            this.Lbl_Pump_RH.TabIndex = 2;
            this.Lbl_Pump_RH.Text = "Right OFF";
            this.Lbl_Pump_RH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Pump_RH.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_Pump_RH.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_Pump_RH.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_Pump_RH.Wordwrap = false;
            // 
            // Lbl_Pump_LH
            // 
            this.Lbl_Pump_LH.BackGround = null;
            this.Lbl_Pump_LH.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Pump_LH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Pump_LH.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_Pump_LH.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_Pump_LH.LineSpacing = 0F;
            this.Lbl_Pump_LH.Location = new System.Drawing.Point(70, 65);
            this.Lbl_Pump_LH.Name = "Lbl_Pump_LH";
            this.Lbl_Pump_LH.OverlapOptimize = true;
            this.Lbl_Pump_LH.PasswordChar = '\0';
            this.Lbl_Pump_LH.Radius = 30;
            this.Lbl_Pump_LH.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Pump_LH.Size = new System.Drawing.Size(250, 100);
            this.Lbl_Pump_LH.TabIndex = 1;
            this.Lbl_Pump_LH.Text = "Left OFF";
            this.Lbl_Pump_LH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Pump_LH.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_Pump_LH.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_Pump_LH.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_Pump_LH.Wordwrap = false;
            // 
            // smartGroupBox3
            // 
            this.smartGroupBox3.BackGround = null;
            this.smartGroupBox3.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.smartGroupBox3.BackImage = null;
            this.smartGroupBox3.Controls.Add(this.Lbl_Level_RH);
            this.smartGroupBox3.Controls.Add(this.Lbl_Level_LH);
            this.smartGroupBox3.FrameLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.smartGroupBox3.FrameLineColor2 = System.Drawing.Color.White;
            this.smartGroupBox3.FrameLineThickness = 2;
            this.smartGroupBox3.FrameStyle = SmartX.SmartGroupBox.FRAMESTYLES.HeaderBar;
            this.smartGroupBox3.HeaderHeightOffset = 5;
            this.smartGroupBox3.Location = new System.Drawing.Point(50, 191);
            this.smartGroupBox3.Name = "smartGroupBox3";
            this.smartGroupBox3.RoundRadius = 5;
            this.smartGroupBox3.Size = new System.Drawing.Size(700, 150);
            this.smartGroupBox3.TabIndex = 0;
            this.smartGroupBox3.Text = "수위레벨 센서 상태";
            this.smartGroupBox3.TextColor = System.Drawing.Color.White;
            // 
            // Lbl_Level_RH
            // 
            this.Lbl_Level_RH.BackGround = null;
            this.Lbl_Level_RH.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Level_RH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Level_RH.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_Level_RH.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_Level_RH.LineSpacing = 0F;
            this.Lbl_Level_RH.Location = new System.Drawing.Point(370, 65);
            this.Lbl_Level_RH.Name = "Lbl_Level_RH";
            this.Lbl_Level_RH.OverlapOptimize = true;
            this.Lbl_Level_RH.PasswordChar = '\0';
            this.Lbl_Level_RH.Radius = 30;
            this.Lbl_Level_RH.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Level_RH.Size = new System.Drawing.Size(250, 50);
            this.Lbl_Level_RH.TabIndex = 0;
            this.Lbl_Level_RH.Text = "Right OFF";
            this.Lbl_Level_RH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Level_RH.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_Level_RH.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_Level_RH.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_Level_RH.Wordwrap = false;
            // 
            // Lbl_Level_LH
            // 
            this.Lbl_Level_LH.BackGround = null;
            this.Lbl_Level_LH.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Level_LH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Level_LH.BorderStyle = SmartX.SmartLabel.BorderStyles.RoundRect;
            this.Lbl_Level_LH.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_Level_LH.LineSpacing = 0F;
            this.Lbl_Level_LH.Location = new System.Drawing.Point(70, 65);
            this.Lbl_Level_LH.Name = "Lbl_Level_LH";
            this.Lbl_Level_LH.OverlapOptimize = true;
            this.Lbl_Level_LH.PasswordChar = '\0';
            this.Lbl_Level_LH.Radius = 30;
            this.Lbl_Level_LH.RoundRectFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.Lbl_Level_LH.Size = new System.Drawing.Size(250, 50);
            this.Lbl_Level_LH.TabIndex = 0;
            this.Lbl_Level_LH.Text = "Left OFF";
            this.Lbl_Level_LH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Lbl_Level_LH.TextColorDisable = System.Drawing.Color.Gray;
            this.Lbl_Level_LH.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.Lbl_Level_LH.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.Lbl_Level_LH.Wordwrap = false;
            // 
            // smartPWM1
            // 
            this.smartPWM1.ClockDivider1 = SmartX.SmartPWM.CLOCKDIVIDER.DIVIDE4;
            this.smartPWM1.ClockDivider2 = SmartX.SmartPWM.CLOCKDIVIDER.DIVIDE4;
            this.smartPWM1.DeadTime = ((byte)(0));
            this.smartPWM1.DutyRate1 = 50;
            this.smartPWM1.DutyRate2 = 50;
            this.smartPWM1.Polarity1 = SmartX.SmartPWM.POLARITY.HIGHACTIVE;
            this.smartPWM1.Polarity2 = SmartX.SmartPWM.POLARITY.HIGHACTIVE;
            this.smartPWM1.PreScaler = ((byte)(240));
            this.smartPWM1.PWMCounter1 = ((uint)(100u));
            this.smartPWM1.PWMCounter2 = ((uint)(100u));
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
            this.smartGPIO1.DirPin4 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin5 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin6 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.DirPin7 = SmartX.SmartGPIO.PINDIR.INPUT;
            this.smartGPIO1.PortDatas = 0;
            this.smartGPIO1.PortDirs = 0;
            this.smartGPIO1.PortSelect = SmartX.SmartGPIO.PORTID.NONE;
            this.smartGPIO1.OnPortDatasChange += new SmartX.SmartGPIO.PortChangeEventHandler(this.smartGPIO1_OnPortDatasChange);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.smartForm1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.Name = "FormMain";
            this.Text = " TSTE - CWNU";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormMain_Closing);
            this.smartForm1.ResumeLayout(false);
            this.smartGroupBox1.ResumeLayout(false);
            this.smartGroupBox2.ResumeLayout(false);
            this.smartGroupBox4.ResumeLayout(false);
            this.smartGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartForm smartForm1;
        private SmartX.SmartGroupBox smartGroupBox4;
        private SmartX.SmartGroupBox smartGroupBox3;
        private SmartX.SmartButton Btn_CtrlMode;
        private SmartX.SmartGroupBox smartGroupBox2;
        private SmartX.SmartButton Btn_Pump_ALL;
        private SmartX.SmartButton Btn_Pump_RH;
        private SmartX.SmartButton Btn_Pump_LH;
        private SmartX.SmartLabel Lbl_Pump_RH;
        private SmartX.SmartLabel Lbl_Pump_LH;
        private SmartX.SmartLabel Lbl_Level_RH;
        private SmartX.SmartLabel Lbl_Level_LH;
        private SmartX.SmartPWM smartPWM1;
        private SmartX.SmartGPIO smartGPIO1;
        private SmartX.SmartGroupBox smartGroupBox1;
    }
}

