namespace Pokojowy_regulator_temperatury
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshCOMPortListButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SerialPortProgressBar = new System.Windows.Forms.ProgressBar();
            this.CloseCOMPortButton = new System.Windows.Forms.Button();
            this.OpenCOMPortButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoudRateComboBox = new System.Windows.Forms.ComboBox();
            this.COMPortsComboBox = new System.Windows.Forms.ComboBox();
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.monitorGtoupBox = new System.Windows.Forms.GroupBox();
            this.MinTempValueLabel = new System.Windows.Forms.Label();
            this.MaxTempValueLabel = new System.Windows.Forms.Label();
            this.CurrentTempValueLabel = new System.Windows.Forms.Label();
            this.MinTempLabel = new System.Windows.Forms.Label();
            this.MaxTempLabel = new System.Windows.Forms.Label();
            this.CurrentTempLabel = new System.Windows.Forms.Label();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.FetchSettingsButton = new System.Windows.Forms.Button();
            this.LedsGroupBox = new System.Windows.Forms.GroupBox();
            this.Led8SetValueButton = new System.Windows.Forms.Button();
            this.Led8CelsiusLabel = new System.Windows.Forms.Label();
            this.Led8ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led8Label = new System.Windows.Forms.Label();
            this.Led7SetValueButton = new System.Windows.Forms.Button();
            this.Led7CelsiusLabel = new System.Windows.Forms.Label();
            this.Led7ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led7Label = new System.Windows.Forms.Label();
            this.Led6SetValueButton = new System.Windows.Forms.Button();
            this.Led6CelsiusLabel = new System.Windows.Forms.Label();
            this.Led6ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led6Label = new System.Windows.Forms.Label();
            this.Led5SetValueButton = new System.Windows.Forms.Button();
            this.Led5CelsiusLabel = new System.Windows.Forms.Label();
            this.Led5ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led5Label = new System.Windows.Forms.Label();
            this.Led4SetValueButton = new System.Windows.Forms.Button();
            this.Led4CelsiusLabel = new System.Windows.Forms.Label();
            this.Led4ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led4Label = new System.Windows.Forms.Label();
            this.Led3SetValueButton = new System.Windows.Forms.Button();
            this.Led3CelsiusLabel = new System.Windows.Forms.Label();
            this.Led3ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led3Label = new System.Windows.Forms.Label();
            this.Led2SetValueButton = new System.Windows.Forms.Button();
            this.Led2CelsiusLabel = new System.Windows.Forms.Label();
            this.Led2ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led2Label = new System.Windows.Forms.Label();
            this.Led1SetValueButton = new System.Windows.Forms.Button();
            this.Led1CelsiusLabel = new System.Windows.Forms.Label();
            this.Led1ValueTextBox = new System.Windows.Forms.TextBox();
            this.Led1Label = new System.Windows.Forms.Label();
            this.TransmitersGroupBox = new System.Windows.Forms.GroupBox();
            this.Transmiter3SetValueButton = new System.Windows.Forms.Button();
            this.Transmiter3CelsiusSign = new System.Windows.Forms.Label();
            this.Transmiter3ValueTextBox = new System.Windows.Forms.TextBox();
            this.Transmiter3Label = new System.Windows.Forms.Label();
            this.Transmiter2SetValueButton = new System.Windows.Forms.Button();
            this.Transmiter2CelsiusSign = new System.Windows.Forms.Label();
            this.Transmiter2ValueTextBox = new System.Windows.Forms.TextBox();
            this.Transmiter2Label = new System.Windows.Forms.Label();
            this.Transmiter1SetValueButton = new System.Windows.Forms.Button();
            this.Transmiter1CelsiusSign = new System.Windows.Forms.Label();
            this.Transmiter1ValueTextBox = new System.Windows.Forms.TextBox();
            this.Transmiter1Label = new System.Windows.Forms.Label();
            this.OsteresisValueCelsiusLabel = new System.Windows.Forms.Label();
            this.SetOsteresisValueButton = new System.Windows.Forms.Button();
            this.OsteresisValueTextBox = new System.Windows.Forms.TextBox();
            this.OsteresisLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.monitorGtoupBox.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.LedsGroupBox.SuspendLayout();
            this.TransmitersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshCOMPortListButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BoudRateComboBox);
            this.groupBox1.Controls.Add(this.COMPortsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(32, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia portu COM";
            // 
            // RefreshCOMPortListButton
            // 
            this.RefreshCOMPortListButton.Location = new System.Drawing.Point(6, 86);
            this.RefreshCOMPortListButton.Name = "RefreshCOMPortListButton";
            this.RefreshCOMPortListButton.Size = new System.Drawing.Size(210, 23);
            this.RefreshCOMPortListButton.TabIndex = 5;
            this.RefreshCOMPortListButton.Text = "Odśwież liste portów";
            this.RefreshCOMPortListButton.UseVisualStyleBackColor = true;
            this.RefreshCOMPortListButton.Click += new System.EventHandler(this.RefreshCOMPortListButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SerialPortProgressBar);
            this.groupBox2.Controls.Add(this.CloseCOMPortButton);
            this.groupBox2.Controls.Add(this.OpenCOMPortButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SerialPortProgressBar
            // 
            this.SerialPortProgressBar.Location = new System.Drawing.Point(17, 50);
            this.SerialPortProgressBar.Name = "SerialPortProgressBar";
            this.SerialPortProgressBar.Size = new System.Drawing.Size(157, 23);
            this.SerialPortProgressBar.TabIndex = 2;
            // 
            // CloseCOMPortButton
            // 
            this.CloseCOMPortButton.Location = new System.Drawing.Point(99, 21);
            this.CloseCOMPortButton.Name = "CloseCOMPortButton";
            this.CloseCOMPortButton.Size = new System.Drawing.Size(75, 23);
            this.CloseCOMPortButton.TabIndex = 1;
            this.CloseCOMPortButton.Text = "Zamknij";
            this.CloseCOMPortButton.UseVisualStyleBackColor = true;
            this.CloseCOMPortButton.Click += new System.EventHandler(this.CloseCOMPortButton_Click);
            // 
            // OpenCOMPortButton
            // 
            this.OpenCOMPortButton.Location = new System.Drawing.Point(17, 20);
            this.OpenCOMPortButton.Name = "OpenCOMPortButton";
            this.OpenCOMPortButton.Size = new System.Drawing.Size(75, 23);
            this.OpenCOMPortButton.TabIndex = 0;
            this.OpenCOMPortButton.Text = "Otwórz";
            this.OpenCOMPortButton.UseVisualStyleBackColor = true;
            this.OpenCOMPortButton.Click += new System.EventHandler(this.OpenCOMPortButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Com";
            // 
            // BoudRateComboBox
            // 
            this.BoudRateComboBox.FormattingEnabled = true;
            this.BoudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BoudRateComboBox.Location = new System.Drawing.Point(95, 55);
            this.BoudRateComboBox.Name = "BoudRateComboBox";
            this.BoudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.BoudRateComboBox.TabIndex = 1;
            // 
            // COMPortsComboBox
            // 
            this.COMPortsComboBox.FormattingEnabled = true;
            this.COMPortsComboBox.Location = new System.Drawing.Point(95, 28);
            this.COMPortsComboBox.Name = "COMPortsComboBox";
            this.COMPortsComboBox.Size = new System.Drawing.Size(121, 21);
            this.COMPortsComboBox.TabIndex = 0;
            // 
            // serialPortMain
            // 
            this.serialPortMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortMain_DataReceived);
            // 
            // monitorGtoupBox
            // 
            this.monitorGtoupBox.Controls.Add(this.MinTempValueLabel);
            this.monitorGtoupBox.Controls.Add(this.MaxTempValueLabel);
            this.monitorGtoupBox.Controls.Add(this.CurrentTempValueLabel);
            this.monitorGtoupBox.Controls.Add(this.MinTempLabel);
            this.monitorGtoupBox.Controls.Add(this.MaxTempLabel);
            this.monitorGtoupBox.Controls.Add(this.CurrentTempLabel);
            this.monitorGtoupBox.Location = new System.Drawing.Point(28, 240);
            this.monitorGtoupBox.Name = "monitorGtoupBox";
            this.monitorGtoupBox.Size = new System.Drawing.Size(236, 85);
            this.monitorGtoupBox.TabIndex = 1;
            this.monitorGtoupBox.TabStop = false;
            this.monitorGtoupBox.Text = "Monitoring";
            // 
            // MinTempValueLabel
            // 
            this.MinTempValueLabel.AutoSize = true;
            this.MinTempValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinTempValueLabel.ForeColor = System.Drawing.Color.Red;
            this.MinTempValueLabel.Location = new System.Drawing.Point(181, 60);
            this.MinTempValueLabel.Name = "MinTempValueLabel";
            this.MinTempValueLabel.Size = new System.Drawing.Size(35, 16);
            this.MinTempValueLabel.TabIndex = 5;
            this.MinTempValueLabel.Text = "-.- °C";
            // 
            // MaxTempValueLabel
            // 
            this.MaxTempValueLabel.AutoSize = true;
            this.MaxTempValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxTempValueLabel.ForeColor = System.Drawing.Color.Red;
            this.MaxTempValueLabel.Location = new System.Drawing.Point(181, 38);
            this.MaxTempValueLabel.Name = "MaxTempValueLabel";
            this.MaxTempValueLabel.Size = new System.Drawing.Size(35, 16);
            this.MaxTempValueLabel.TabIndex = 4;
            this.MaxTempValueLabel.Text = "-.- °C";
            // 
            // CurrentTempValueLabel
            // 
            this.CurrentTempValueLabel.AutoSize = true;
            this.CurrentTempValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentTempValueLabel.ForeColor = System.Drawing.Color.Red;
            this.CurrentTempValueLabel.Location = new System.Drawing.Point(181, 16);
            this.CurrentTempValueLabel.Name = "CurrentTempValueLabel";
            this.CurrentTempValueLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrentTempValueLabel.TabIndex = 3;
            this.CurrentTempValueLabel.Text = "-.- °C";
            // 
            // MinTempLabel
            // 
            this.MinTempLabel.AutoSize = true;
            this.MinTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinTempLabel.Location = new System.Drawing.Point(7, 60);
            this.MinTempLabel.Name = "MinTempLabel";
            this.MinTempLabel.Size = new System.Drawing.Size(144, 16);
            this.MinTempLabel.TabIndex = 2;
            this.MinTempLabel.Text = "Minimalna temperatura";
            // 
            // MaxTempLabel
            // 
            this.MaxTempLabel.AutoSize = true;
            this.MaxTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxTempLabel.Location = new System.Drawing.Point(7, 38);
            this.MaxTempLabel.Name = "MaxTempLabel";
            this.MaxTempLabel.Size = new System.Drawing.Size(160, 16);
            this.MaxTempLabel.TabIndex = 1;
            this.MaxTempLabel.Text = "Maksymalna temperatura";
            // 
            // CurrentTempLabel
            // 
            this.CurrentTempLabel.AutoSize = true;
            this.CurrentTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentTempLabel.Location = new System.Drawing.Point(7, 16);
            this.CurrentTempLabel.Name = "CurrentTempLabel";
            this.CurrentTempLabel.Size = new System.Drawing.Size(135, 16);
            this.CurrentTempLabel.TabIndex = 0;
            this.CurrentTempLabel.Text = "Aktualna temperatura";
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.FetchSettingsButton);
            this.SettingsGroupBox.Controls.Add(this.LedsGroupBox);
            this.SettingsGroupBox.Controls.Add(this.TransmitersGroupBox);
            this.SettingsGroupBox.Controls.Add(this.OsteresisValueCelsiusLabel);
            this.SettingsGroupBox.Controls.Add(this.SetOsteresisValueButton);
            this.SettingsGroupBox.Controls.Add(this.OsteresisValueTextBox);
            this.SettingsGroupBox.Controls.Add(this.OsteresisLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(270, 15);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(556, 310);
            this.SettingsGroupBox.TabIndex = 2;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Ustawienia";
            // 
            // FetchSettingsButton
            // 
            this.FetchSettingsButton.Location = new System.Drawing.Point(6, 175);
            this.FetchSettingsButton.Name = "FetchSettingsButton";
            this.FetchSettingsButton.Size = new System.Drawing.Size(256, 38);
            this.FetchSettingsButton.TabIndex = 8;
            this.FetchSettingsButton.Text = "Pobierz ustawienia z AVR";
            this.FetchSettingsButton.UseVisualStyleBackColor = true;
            this.FetchSettingsButton.Click += new System.EventHandler(this.FetchSettingsButton_Click);
            // 
            // LedsGroupBox
            // 
            this.LedsGroupBox.Controls.Add(this.Led8SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led8CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led8ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led8Label);
            this.LedsGroupBox.Controls.Add(this.Led7SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led7CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led7ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led7Label);
            this.LedsGroupBox.Controls.Add(this.Led6SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led6CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led6ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led6Label);
            this.LedsGroupBox.Controls.Add(this.Led5SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led5CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led5ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led5Label);
            this.LedsGroupBox.Controls.Add(this.Led4SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led4CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led4ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led4Label);
            this.LedsGroupBox.Controls.Add(this.Led3SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led3CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led3ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led3Label);
            this.LedsGroupBox.Controls.Add(this.Led2SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led2CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led2ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led2Label);
            this.LedsGroupBox.Controls.Add(this.Led1SetValueButton);
            this.LedsGroupBox.Controls.Add(this.Led1CelsiusLabel);
            this.LedsGroupBox.Controls.Add(this.Led1ValueTextBox);
            this.LedsGroupBox.Controls.Add(this.Led1Label);
            this.LedsGroupBox.Location = new System.Drawing.Point(268, 15);
            this.LedsGroupBox.Name = "LedsGroupBox";
            this.LedsGroupBox.Size = new System.Drawing.Size(270, 252);
            this.LedsGroupBox.TabIndex = 7;
            this.LedsGroupBox.TabStop = false;
            this.LedsGroupBox.Text = "Diody Led";
            // 
            // Led8SetValueButton
            // 
            this.Led8SetValueButton.Location = new System.Drawing.Point(174, 204);
            this.Led8SetValueButton.Name = "Led8SetValueButton";
            this.Led8SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led8SetValueButton.TabIndex = 35;
            this.Led8SetValueButton.Text = "Ustaw";
            this.Led8SetValueButton.UseVisualStyleBackColor = true;
            this.Led8SetValueButton.Click += new System.EventHandler(this.Led8SetValueButton_Click);
            // 
            // Led8CelsiusLabel
            // 
            this.Led8CelsiusLabel.AutoSize = true;
            this.Led8CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led8CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led8CelsiusLabel.Location = new System.Drawing.Point(147, 203);
            this.Led8CelsiusLabel.Name = "Led8CelsiusLabel";
            this.Led8CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led8CelsiusLabel.TabIndex = 34;
            this.Led8CelsiusLabel.Text = "°C";
            // 
            // Led8ValueTextBox
            // 
            this.Led8ValueTextBox.Location = new System.Drawing.Point(93, 203);
            this.Led8ValueTextBox.Name = "Led8ValueTextBox";
            this.Led8ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led8ValueTextBox.TabIndex = 33;
            this.Led8ValueTextBox.Text = "0.0";
            this.Led8ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led8Label
            // 
            this.Led8Label.AutoSize = true;
            this.Led8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led8Label.Location = new System.Drawing.Point(6, 207);
            this.Led8Label.Name = "Led8Label";
            this.Led8Label.Size = new System.Drawing.Size(55, 16);
            this.Led8Label.TabIndex = 32;
            this.Led8Label.Text = "Dioda 8";
            // 
            // Led7SetValueButton
            // 
            this.Led7SetValueButton.Location = new System.Drawing.Point(174, 175);
            this.Led7SetValueButton.Name = "Led7SetValueButton";
            this.Led7SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led7SetValueButton.TabIndex = 31;
            this.Led7SetValueButton.Text = "Ustaw";
            this.Led7SetValueButton.UseVisualStyleBackColor = true;
            this.Led7SetValueButton.Click += new System.EventHandler(this.Led7SetValueButton_Click);
            // 
            // Led7CelsiusLabel
            // 
            this.Led7CelsiusLabel.AutoSize = true;
            this.Led7CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led7CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led7CelsiusLabel.Location = new System.Drawing.Point(147, 174);
            this.Led7CelsiusLabel.Name = "Led7CelsiusLabel";
            this.Led7CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led7CelsiusLabel.TabIndex = 30;
            this.Led7CelsiusLabel.Text = "°C";
            // 
            // Led7ValueTextBox
            // 
            this.Led7ValueTextBox.Location = new System.Drawing.Point(93, 174);
            this.Led7ValueTextBox.Name = "Led7ValueTextBox";
            this.Led7ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led7ValueTextBox.TabIndex = 29;
            this.Led7ValueTextBox.Text = "0.0";
            this.Led7ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led7Label
            // 
            this.Led7Label.AutoSize = true;
            this.Led7Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led7Label.Location = new System.Drawing.Point(6, 178);
            this.Led7Label.Name = "Led7Label";
            this.Led7Label.Size = new System.Drawing.Size(55, 16);
            this.Led7Label.TabIndex = 28;
            this.Led7Label.Text = "Dioda 7";
            // 
            // Led6SetValueButton
            // 
            this.Led6SetValueButton.Location = new System.Drawing.Point(174, 145);
            this.Led6SetValueButton.Name = "Led6SetValueButton";
            this.Led6SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led6SetValueButton.TabIndex = 27;
            this.Led6SetValueButton.Text = "Ustaw";
            this.Led6SetValueButton.UseVisualStyleBackColor = true;
            this.Led6SetValueButton.Click += new System.EventHandler(this.Led6SetValueButton_Click);
            // 
            // Led6CelsiusLabel
            // 
            this.Led6CelsiusLabel.AutoSize = true;
            this.Led6CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led6CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led6CelsiusLabel.Location = new System.Drawing.Point(147, 144);
            this.Led6CelsiusLabel.Name = "Led6CelsiusLabel";
            this.Led6CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led6CelsiusLabel.TabIndex = 26;
            this.Led6CelsiusLabel.Text = "°C";
            // 
            // Led6ValueTextBox
            // 
            this.Led6ValueTextBox.Location = new System.Drawing.Point(93, 144);
            this.Led6ValueTextBox.Name = "Led6ValueTextBox";
            this.Led6ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led6ValueTextBox.TabIndex = 25;
            this.Led6ValueTextBox.Text = "0.0";
            this.Led6ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led6Label
            // 
            this.Led6Label.AutoSize = true;
            this.Led6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led6Label.Location = new System.Drawing.Point(6, 148);
            this.Led6Label.Name = "Led6Label";
            this.Led6Label.Size = new System.Drawing.Size(55, 16);
            this.Led6Label.TabIndex = 24;
            this.Led6Label.Text = "Dioda 6";
            // 
            // Led5SetValueButton
            // 
            this.Led5SetValueButton.Location = new System.Drawing.Point(174, 119);
            this.Led5SetValueButton.Name = "Led5SetValueButton";
            this.Led5SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led5SetValueButton.TabIndex = 23;
            this.Led5SetValueButton.Text = "Ustaw";
            this.Led5SetValueButton.UseVisualStyleBackColor = true;
            this.Led5SetValueButton.Click += new System.EventHandler(this.Led5SetValueButton_Click);
            // 
            // Led5CelsiusLabel
            // 
            this.Led5CelsiusLabel.AutoSize = true;
            this.Led5CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led5CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led5CelsiusLabel.Location = new System.Drawing.Point(147, 118);
            this.Led5CelsiusLabel.Name = "Led5CelsiusLabel";
            this.Led5CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led5CelsiusLabel.TabIndex = 22;
            this.Led5CelsiusLabel.Text = "°C";
            // 
            // Led5ValueTextBox
            // 
            this.Led5ValueTextBox.Location = new System.Drawing.Point(93, 118);
            this.Led5ValueTextBox.Name = "Led5ValueTextBox";
            this.Led5ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led5ValueTextBox.TabIndex = 21;
            this.Led5ValueTextBox.Text = "0.0";
            this.Led5ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led5Label
            // 
            this.Led5Label.AutoSize = true;
            this.Led5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led5Label.Location = new System.Drawing.Point(6, 122);
            this.Led5Label.Name = "Led5Label";
            this.Led5Label.Size = new System.Drawing.Size(55, 16);
            this.Led5Label.TabIndex = 20;
            this.Led5Label.Text = "Dioda 5";
            // 
            // Led4SetValueButton
            // 
            this.Led4SetValueButton.Location = new System.Drawing.Point(174, 91);
            this.Led4SetValueButton.Name = "Led4SetValueButton";
            this.Led4SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led4SetValueButton.TabIndex = 19;
            this.Led4SetValueButton.Text = "Ustaw";
            this.Led4SetValueButton.UseVisualStyleBackColor = true;
            this.Led4SetValueButton.Click += new System.EventHandler(this.Led4SetValueButton_Click);
            // 
            // Led4CelsiusLabel
            // 
            this.Led4CelsiusLabel.AutoSize = true;
            this.Led4CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led4CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led4CelsiusLabel.Location = new System.Drawing.Point(147, 90);
            this.Led4CelsiusLabel.Name = "Led4CelsiusLabel";
            this.Led4CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led4CelsiusLabel.TabIndex = 18;
            this.Led4CelsiusLabel.Text = "°C";
            // 
            // Led4ValueTextBox
            // 
            this.Led4ValueTextBox.Location = new System.Drawing.Point(93, 90);
            this.Led4ValueTextBox.Name = "Led4ValueTextBox";
            this.Led4ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led4ValueTextBox.TabIndex = 17;
            this.Led4ValueTextBox.Text = "0.0";
            this.Led4ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led4Label
            // 
            this.Led4Label.AutoSize = true;
            this.Led4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led4Label.Location = new System.Drawing.Point(6, 94);
            this.Led4Label.Name = "Led4Label";
            this.Led4Label.Size = new System.Drawing.Size(55, 16);
            this.Led4Label.TabIndex = 16;
            this.Led4Label.Text = "Dioda 4";
            // 
            // Led3SetValueButton
            // 
            this.Led3SetValueButton.Location = new System.Drawing.Point(174, 65);
            this.Led3SetValueButton.Name = "Led3SetValueButton";
            this.Led3SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led3SetValueButton.TabIndex = 15;
            this.Led3SetValueButton.Text = "Ustaw";
            this.Led3SetValueButton.UseVisualStyleBackColor = true;
            this.Led3SetValueButton.Click += new System.EventHandler(this.Led3SetValueButton_Click);
            // 
            // Led3CelsiusLabel
            // 
            this.Led3CelsiusLabel.AutoSize = true;
            this.Led3CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led3CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led3CelsiusLabel.Location = new System.Drawing.Point(147, 64);
            this.Led3CelsiusLabel.Name = "Led3CelsiusLabel";
            this.Led3CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led3CelsiusLabel.TabIndex = 14;
            this.Led3CelsiusLabel.Text = "°C";
            // 
            // Led3ValueTextBox
            // 
            this.Led3ValueTextBox.Location = new System.Drawing.Point(93, 64);
            this.Led3ValueTextBox.Name = "Led3ValueTextBox";
            this.Led3ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led3ValueTextBox.TabIndex = 13;
            this.Led3ValueTextBox.Text = "0.0";
            this.Led3ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led3Label
            // 
            this.Led3Label.AutoSize = true;
            this.Led3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led3Label.Location = new System.Drawing.Point(6, 68);
            this.Led3Label.Name = "Led3Label";
            this.Led3Label.Size = new System.Drawing.Size(55, 16);
            this.Led3Label.TabIndex = 12;
            this.Led3Label.Text = "Dioda 3";
            // 
            // Led2SetValueButton
            // 
            this.Led2SetValueButton.Location = new System.Drawing.Point(174, 40);
            this.Led2SetValueButton.Name = "Led2SetValueButton";
            this.Led2SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led2SetValueButton.TabIndex = 11;
            this.Led2SetValueButton.Text = "Ustaw";
            this.Led2SetValueButton.UseVisualStyleBackColor = true;
            this.Led2SetValueButton.Click += new System.EventHandler(this.Led2SetValueButton_Click);
            // 
            // Led2CelsiusLabel
            // 
            this.Led2CelsiusLabel.AutoSize = true;
            this.Led2CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led2CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led2CelsiusLabel.Location = new System.Drawing.Point(147, 39);
            this.Led2CelsiusLabel.Name = "Led2CelsiusLabel";
            this.Led2CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led2CelsiusLabel.TabIndex = 10;
            this.Led2CelsiusLabel.Text = "°C";
            // 
            // Led2ValueTextBox
            // 
            this.Led2ValueTextBox.Location = new System.Drawing.Point(93, 39);
            this.Led2ValueTextBox.Name = "Led2ValueTextBox";
            this.Led2ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led2ValueTextBox.TabIndex = 9;
            this.Led2ValueTextBox.Text = "0.0";
            this.Led2ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led2Label
            // 
            this.Led2Label.AutoSize = true;
            this.Led2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led2Label.Location = new System.Drawing.Point(6, 43);
            this.Led2Label.Name = "Led2Label";
            this.Led2Label.Size = new System.Drawing.Size(55, 16);
            this.Led2Label.TabIndex = 8;
            this.Led2Label.Text = "Dioda 2";
            // 
            // Led1SetValueButton
            // 
            this.Led1SetValueButton.Location = new System.Drawing.Point(174, 13);
            this.Led1SetValueButton.Name = "Led1SetValueButton";
            this.Led1SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Led1SetValueButton.TabIndex = 7;
            this.Led1SetValueButton.Text = "Ustaw";
            this.Led1SetValueButton.UseVisualStyleBackColor = true;
            this.Led1SetValueButton.Click += new System.EventHandler(this.Led1SetValueButton_Click);
            // 
            // Led1CelsiusLabel
            // 
            this.Led1CelsiusLabel.AutoSize = true;
            this.Led1CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led1CelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.Led1CelsiusLabel.Location = new System.Drawing.Point(147, 16);
            this.Led1CelsiusLabel.Name = "Led1CelsiusLabel";
            this.Led1CelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.Led1CelsiusLabel.TabIndex = 6;
            this.Led1CelsiusLabel.Text = "°C";
            // 
            // Led1ValueTextBox
            // 
            this.Led1ValueTextBox.Location = new System.Drawing.Point(93, 16);
            this.Led1ValueTextBox.Name = "Led1ValueTextBox";
            this.Led1ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Led1ValueTextBox.TabIndex = 3;
            this.Led1ValueTextBox.Text = "0.0";
            this.Led1ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Led1Label
            // 
            this.Led1Label.AutoSize = true;
            this.Led1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Led1Label.Location = new System.Drawing.Point(6, 16);
            this.Led1Label.Name = "Led1Label";
            this.Led1Label.Size = new System.Drawing.Size(55, 16);
            this.Led1Label.TabIndex = 2;
            this.Led1Label.Text = "Dioda 1";
            // 
            // TransmitersGroupBox
            // 
            this.TransmitersGroupBox.Controls.Add(this.Transmiter3SetValueButton);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter3CelsiusSign);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter3ValueTextBox);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter3Label);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter2SetValueButton);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter2CelsiusSign);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter2ValueTextBox);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter2Label);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter1SetValueButton);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter1CelsiusSign);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter1ValueTextBox);
            this.TransmitersGroupBox.Controls.Add(this.Transmiter1Label);
            this.TransmitersGroupBox.Location = new System.Drawing.Point(6, 65);
            this.TransmitersGroupBox.Name = "TransmitersGroupBox";
            this.TransmitersGroupBox.Size = new System.Drawing.Size(256, 104);
            this.TransmitersGroupBox.TabIndex = 6;
            this.TransmitersGroupBox.TabStop = false;
            this.TransmitersGroupBox.Text = "Przekaźniki";
            // 
            // Transmiter3SetValueButton
            // 
            this.Transmiter3SetValueButton.Location = new System.Drawing.Point(174, 65);
            this.Transmiter3SetValueButton.Name = "Transmiter3SetValueButton";
            this.Transmiter3SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Transmiter3SetValueButton.TabIndex = 15;
            this.Transmiter3SetValueButton.Text = "Ustaw";
            this.Transmiter3SetValueButton.UseVisualStyleBackColor = true;
            this.Transmiter3SetValueButton.Click += new System.EventHandler(this.Transmiter3SetValueButton_Click);
            // 
            // Transmiter3CelsiusSign
            // 
            this.Transmiter3CelsiusSign.AutoSize = true;
            this.Transmiter3CelsiusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Transmiter3CelsiusSign.ForeColor = System.Drawing.Color.Red;
            this.Transmiter3CelsiusSign.Location = new System.Drawing.Point(147, 64);
            this.Transmiter3CelsiusSign.Name = "Transmiter3CelsiusSign";
            this.Transmiter3CelsiusSign.Size = new System.Drawing.Size(21, 16);
            this.Transmiter3CelsiusSign.TabIndex = 14;
            this.Transmiter3CelsiusSign.Text = "°C";
            // 
            // Transmiter3ValueTextBox
            // 
            this.Transmiter3ValueTextBox.Location = new System.Drawing.Point(93, 64);
            this.Transmiter3ValueTextBox.Name = "Transmiter3ValueTextBox";
            this.Transmiter3ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Transmiter3ValueTextBox.TabIndex = 13;
            this.Transmiter3ValueTextBox.Text = "0.0";
            this.Transmiter3ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Transmiter3Label
            // 
            this.Transmiter3Label.AutoSize = true;
            this.Transmiter3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Transmiter3Label.Location = new System.Drawing.Point(6, 68);
            this.Transmiter3Label.Name = "Transmiter3Label";
            this.Transmiter3Label.Size = new System.Drawing.Size(83, 16);
            this.Transmiter3Label.TabIndex = 12;
            this.Transmiter3Label.Text = "Przekaźnik 3";
            // 
            // Transmiter2SetValueButton
            // 
            this.Transmiter2SetValueButton.Location = new System.Drawing.Point(174, 40);
            this.Transmiter2SetValueButton.Name = "Transmiter2SetValueButton";
            this.Transmiter2SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Transmiter2SetValueButton.TabIndex = 11;
            this.Transmiter2SetValueButton.Text = "Ustaw";
            this.Transmiter2SetValueButton.UseVisualStyleBackColor = true;
            this.Transmiter2SetValueButton.Click += new System.EventHandler(this.Transmiter2SetValueButton_Click);
            // 
            // Transmiter2CelsiusSign
            // 
            this.Transmiter2CelsiusSign.AutoSize = true;
            this.Transmiter2CelsiusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Transmiter2CelsiusSign.ForeColor = System.Drawing.Color.Red;
            this.Transmiter2CelsiusSign.Location = new System.Drawing.Point(147, 39);
            this.Transmiter2CelsiusSign.Name = "Transmiter2CelsiusSign";
            this.Transmiter2CelsiusSign.Size = new System.Drawing.Size(21, 16);
            this.Transmiter2CelsiusSign.TabIndex = 10;
            this.Transmiter2CelsiusSign.Text = "°C";
            // 
            // Transmiter2ValueTextBox
            // 
            this.Transmiter2ValueTextBox.Location = new System.Drawing.Point(93, 39);
            this.Transmiter2ValueTextBox.Name = "Transmiter2ValueTextBox";
            this.Transmiter2ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Transmiter2ValueTextBox.TabIndex = 9;
            this.Transmiter2ValueTextBox.Text = "0.0";
            this.Transmiter2ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Transmiter2Label
            // 
            this.Transmiter2Label.AutoSize = true;
            this.Transmiter2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Transmiter2Label.Location = new System.Drawing.Point(6, 43);
            this.Transmiter2Label.Name = "Transmiter2Label";
            this.Transmiter2Label.Size = new System.Drawing.Size(83, 16);
            this.Transmiter2Label.TabIndex = 8;
            this.Transmiter2Label.Text = "Przekaźnik 2";
            // 
            // Transmiter1SetValueButton
            // 
            this.Transmiter1SetValueButton.Location = new System.Drawing.Point(174, 13);
            this.Transmiter1SetValueButton.Name = "Transmiter1SetValueButton";
            this.Transmiter1SetValueButton.Size = new System.Drawing.Size(75, 23);
            this.Transmiter1SetValueButton.TabIndex = 7;
            this.Transmiter1SetValueButton.Text = "Ustaw";
            this.Transmiter1SetValueButton.UseVisualStyleBackColor = true;
            this.Transmiter1SetValueButton.Click += new System.EventHandler(this.Transmiter1SetValueButton_Click);
            // 
            // Transmiter1CelsiusSign
            // 
            this.Transmiter1CelsiusSign.AutoSize = true;
            this.Transmiter1CelsiusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Transmiter1CelsiusSign.ForeColor = System.Drawing.Color.Red;
            this.Transmiter1CelsiusSign.Location = new System.Drawing.Point(147, 16);
            this.Transmiter1CelsiusSign.Name = "Transmiter1CelsiusSign";
            this.Transmiter1CelsiusSign.Size = new System.Drawing.Size(21, 16);
            this.Transmiter1CelsiusSign.TabIndex = 6;
            this.Transmiter1CelsiusSign.Text = "°C";
            // 
            // Transmiter1ValueTextBox
            // 
            this.Transmiter1ValueTextBox.Location = new System.Drawing.Point(93, 16);
            this.Transmiter1ValueTextBox.Name = "Transmiter1ValueTextBox";
            this.Transmiter1ValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.Transmiter1ValueTextBox.TabIndex = 3;
            this.Transmiter1ValueTextBox.Text = "0.0";
            this.Transmiter1ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // Transmiter1Label
            // 
            this.Transmiter1Label.AutoSize = true;
            this.Transmiter1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Transmiter1Label.Location = new System.Drawing.Point(6, 16);
            this.Transmiter1Label.Name = "Transmiter1Label";
            this.Transmiter1Label.Size = new System.Drawing.Size(83, 16);
            this.Transmiter1Label.TabIndex = 2;
            this.Transmiter1Label.Text = "Przekaźnik 1";
            // 
            // OsteresisValueCelsiusLabel
            // 
            this.OsteresisValueCelsiusLabel.AutoSize = true;
            this.OsteresisValueCelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OsteresisValueCelsiusLabel.ForeColor = System.Drawing.Color.Red;
            this.OsteresisValueCelsiusLabel.Location = new System.Drawing.Point(133, 27);
            this.OsteresisValueCelsiusLabel.Name = "OsteresisValueCelsiusLabel";
            this.OsteresisValueCelsiusLabel.Size = new System.Drawing.Size(21, 16);
            this.OsteresisValueCelsiusLabel.TabIndex = 5;
            this.OsteresisValueCelsiusLabel.Text = "°C";
            // 
            // SetOsteresisValueButton
            // 
            this.SetOsteresisValueButton.Location = new System.Drawing.Point(160, 24);
            this.SetOsteresisValueButton.Name = "SetOsteresisValueButton";
            this.SetOsteresisValueButton.Size = new System.Drawing.Size(75, 23);
            this.SetOsteresisValueButton.TabIndex = 3;
            this.SetOsteresisValueButton.Text = "Ustaw";
            this.SetOsteresisValueButton.UseVisualStyleBackColor = true;
            this.SetOsteresisValueButton.Click += new System.EventHandler(this.SetOsteresisValueButton_Click);
            // 
            // OsteresisValueTextBox
            // 
            this.OsteresisValueTextBox.Location = new System.Drawing.Point(76, 26);
            this.OsteresisValueTextBox.Name = "OsteresisValueTextBox";
            this.OsteresisValueTextBox.Size = new System.Drawing.Size(51, 20);
            this.OsteresisValueTextBox.TabIndex = 2;
            this.OsteresisValueTextBox.Text = "0.0";
            this.OsteresisValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TemperatureValueTextBox_KeyPress);
            // 
            // OsteresisLabel
            // 
            this.OsteresisLabel.AutoSize = true;
            this.OsteresisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OsteresisLabel.Location = new System.Drawing.Point(7, 26);
            this.OsteresisLabel.Name = "OsteresisLabel";
            this.OsteresisLabel.Size = new System.Drawing.Size(65, 16);
            this.OsteresisLabel.TabIndex = 1;
            this.OsteresisLabel.Text = "Histereza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 337);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.monitorGtoupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pokojowy regulator temperatury";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.monitorGtoupBox.ResumeLayout(false);
            this.monitorGtoupBox.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.LedsGroupBox.ResumeLayout(false);
            this.LedsGroupBox.PerformLayout();
            this.TransmitersGroupBox.ResumeLayout(false);
            this.TransmitersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoudRateComboBox;
        private System.Windows.Forms.ComboBox COMPortsComboBox;
        private System.Windows.Forms.ProgressBar SerialPortProgressBar;
        private System.Windows.Forms.Button CloseCOMPortButton;
        private System.Windows.Forms.Button OpenCOMPortButton;
        private System.Windows.Forms.Button RefreshCOMPortListButton;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.GroupBox monitorGtoupBox;
        private System.Windows.Forms.Label MinTempValueLabel;
        private System.Windows.Forms.Label MaxTempValueLabel;
        private System.Windows.Forms.Label CurrentTempValueLabel;
        private System.Windows.Forms.Label MinTempLabel;
        private System.Windows.Forms.Label MaxTempLabel;
        private System.Windows.Forms.Label CurrentTempLabel;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.TextBox OsteresisValueTextBox;
        private System.Windows.Forms.Label OsteresisLabel;
        private System.Windows.Forms.Label OsteresisValueCelsiusLabel;
        private System.Windows.Forms.Button SetOsteresisValueButton;
        private System.Windows.Forms.Button FetchSettingsButton;
        private System.Windows.Forms.GroupBox LedsGroupBox;
        private System.Windows.Forms.Button Led8SetValueButton;
        private System.Windows.Forms.Label Led8CelsiusLabel;
        private System.Windows.Forms.TextBox Led8ValueTextBox;
        private System.Windows.Forms.Label Led8Label;
        private System.Windows.Forms.Button Led7SetValueButton;
        private System.Windows.Forms.Label Led7CelsiusLabel;
        private System.Windows.Forms.TextBox Led7ValueTextBox;
        private System.Windows.Forms.Label Led7Label;
        private System.Windows.Forms.Button Led6SetValueButton;
        private System.Windows.Forms.Label Led6CelsiusLabel;
        private System.Windows.Forms.TextBox Led6ValueTextBox;
        private System.Windows.Forms.Label Led6Label;
        private System.Windows.Forms.Button Led5SetValueButton;
        private System.Windows.Forms.Label Led5CelsiusLabel;
        private System.Windows.Forms.TextBox Led5ValueTextBox;
        private System.Windows.Forms.Label Led5Label;
        private System.Windows.Forms.Button Led4SetValueButton;
        private System.Windows.Forms.Label Led4CelsiusLabel;
        private System.Windows.Forms.TextBox Led4ValueTextBox;
        private System.Windows.Forms.Label Led4Label;
        private System.Windows.Forms.Button Led3SetValueButton;
        private System.Windows.Forms.Label Led3CelsiusLabel;
        private System.Windows.Forms.TextBox Led3ValueTextBox;
        private System.Windows.Forms.Label Led3Label;
        private System.Windows.Forms.Button Led2SetValueButton;
        private System.Windows.Forms.Label Led2CelsiusLabel;
        private System.Windows.Forms.TextBox Led2ValueTextBox;
        private System.Windows.Forms.Label Led2Label;
        private System.Windows.Forms.Button Led1SetValueButton;
        private System.Windows.Forms.Label Led1CelsiusLabel;
        private System.Windows.Forms.TextBox Led1ValueTextBox;
        private System.Windows.Forms.Label Led1Label;
        private System.Windows.Forms.GroupBox TransmitersGroupBox;
        private System.Windows.Forms.Button Transmiter3SetValueButton;
        private System.Windows.Forms.Label Transmiter3CelsiusSign;
        private System.Windows.Forms.TextBox Transmiter3ValueTextBox;
        private System.Windows.Forms.Label Transmiter3Label;
        private System.Windows.Forms.Button Transmiter2SetValueButton;
        private System.Windows.Forms.Label Transmiter2CelsiusSign;
        private System.Windows.Forms.TextBox Transmiter2ValueTextBox;
        private System.Windows.Forms.Label Transmiter2Label;
        private System.Windows.Forms.Button Transmiter1SetValueButton;
        private System.Windows.Forms.Label Transmiter1CelsiusSign;
        private System.Windows.Forms.TextBox Transmiter1ValueTextBox;
        private System.Windows.Forms.Label Transmiter1Label;
    }
}

