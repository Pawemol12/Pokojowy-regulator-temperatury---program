using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;



namespace Pokojowy_regulator_temperatury
{
    public partial class Form1 : Form
    {
        string dataIN;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LoadCOMPortsComboBox()
        {
            COMPortsComboBox.Items.Clear();
            COMPortsComboBox.Items.AddRange(SerialPort.GetPortNames());

            if (COMPortsComboBox.Items.Count > 0)
            {
                COMPortsComboBox.SelectedIndex = 0;
            }

            BoudRateComboBox.SelectedIndex = 0;
        }

        private void RefreshCOMPortListButton_Click(object sender, EventArgs e)
        {
            LoadCOMPortsComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCOMPortsComboBox();
        }

        private void OpenCOMPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMPortsComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Wybierz port", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                serialPortMain.PortName = COMPortsComboBox.Text;
                serialPortMain.BaudRate = Convert.ToInt32(BoudRateComboBox.Text);

                serialPortMain.Open();
                serialPortMain.Write("FETCH_SETTINGS\r\n");

                SerialPortProgressBar.Value = 100;
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseCOMPortButton_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.Close();
                SerialPortProgressBar.Value = 0;
            }
        }

        private void serialPortMain_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPortMain.ReadLine();
            Invoke(new EventHandler(HandleCOMData));
        }

        private void HandleCOMData(object sender, EventArgs e)
        {
            string[] input = dataIN.Split('|');

            if (input.Length > 0)
            {
                if (input[0] == "TEMP_INFO")
                {
                    CurrentTempValueLabel.Text = input[1] + " °C";
                    MaxTempValueLabel.Text = input[2] + " °C";
                    MinTempValueLabel.Text = input[3] + " °C";
                    //MessageBox.Show(input[1], "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (input[0] == "OSTERESIS_SETTINGS_INFO")
                {
                    OsteresisValueTextBox.Text = input[1];
                }

                else if (input[0] == "TRANSMITER_SETTTINGS_INFO")
                {
                    int transmiterNumber = Convert.ToInt32(input[1]);

                    switch (transmiterNumber)
                    {
                        case 0:
                            {
                                Transmiter1ValueTextBox.Text = input[2];
                                break;
                            }
                        case 1:
                            {
                                Transmiter2ValueTextBox.Text = input[2];
                                break;
                            }
                        case 2:
                            {
                                Transmiter3ValueTextBox.Text = input[2];
                                break;
                            }
                    }
                }
                else if (input[0] == "LED_SETTTINGS_INFO")
                {
                    int ledNumber = Convert.ToInt32(input[1]);

                    switch (ledNumber)
                    {
                        case 0:
                        {
                            Led1ValueTextBox.Text = input[2];
                            break;
                        }
                        case 1:
                        {
                            Led2ValueTextBox.Text = input[2];
                            break;
                        }
                        case 2:
                        {
                            Led3ValueTextBox.Text = input[2];
                            break;
                        }
                        case 3:
                        {
                            Led4ValueTextBox.Text = input[2];
                            break;
                        }
                        case 4:
                        {
                            Led5ValueTextBox.Text = input[2];
                            break;
                        }
                        case 5:
                        {
                            Led6ValueTextBox.Text = input[2];
                            break;
                        }
                        case 6:
                        {
                            Led7ValueTextBox.Text = input[2];
                            break;
                        }
                        case 7:
                        {
                            Led8ValueTextBox.Text = input[2];
                            break;
                        }
                    }
                }
            }
        }

        private void TemperatureValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && OsteresisValueTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void FetchSettingsButton_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.Write("FETCH_SETTINGS\r\n");
            } else
            {
                MessageBox.Show("Port COM nie jest otwarty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetOsteresisValueButton_Click(object sender, EventArgs e)
        {
            float hysteresis;
            if (Single.TryParse(OsteresisValueTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out hysteresis))
            {
                if (hysteresis < 0)
                {
                    MessageBox.Show("Wartość histerezy nie może być mniejsza niż 0!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (hysteresis > Constants.HYSTERESIS_MAX_TEMP)
                {
                    MessageBox.Show("Wartość histerezy nie może być większa niż " + Constants.HYSTERESIS_MAX_TEMP.ToString() + "!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (serialPortMain.IsOpen)
                {
                    string command = "SET_OSTERESIS|" + hysteresis.ToString("0.00", CultureInfo.InvariantCulture) + "\r\n";
                    serialPortMain.Write(command);
                }
                else
                {
                    MessageBox.Show("Port COM nie jest otwarty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format ustawienia histerezy!!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Transmiter1SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Transmiter1ValueTextBox.Text;
            SetTransmiterValue(ref text, 0);
        }

        private void Transmiter2SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Transmiter2ValueTextBox.Text;
            SetTransmiterValue(ref text, 1);
        }

        private void Transmiter3SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Transmiter3ValueTextBox.Text;
            SetTransmiterValue(ref text, 2);
        }

        private void SetTransmiterValue(ref string valueText, int transmiterNumber)
        {
            float value;

            if (float.TryParse(valueText, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                if (value < Constants.DS1621_MIN_TEMP)
                {
                    MessageBox.Show("Temperatura załączania przekaźnika nie może być mniejsza niż "+ Constants.DS1621_MIN_TEMP.ToString() + "!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (value > Constants.DS1621_MAX_TEMP)
                {
                    MessageBox.Show("Temperatura załączania przekaźnika nie może być większa niż " + Constants.DS1621_MAX_TEMP.ToString() + "!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (serialPortMain.IsOpen)
                {
                    string command = "SET_TRANSMITER_VALUE|" + transmiterNumber.ToString() + "|" + value.ToString("0.00", CultureInfo.InvariantCulture) + "\r\n";
                    serialPortMain.Write(command);
                }
                else
                {
                    MessageBox.Show("Port COM nie jest otwarty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format ustawienia transmitera " + (transmiterNumber + 1).ToString() +"!!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetLedValue(ref string valueText, int ledNumber)
        {
            float value;

            if (float.TryParse(valueText, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                if (value < Constants.DS1621_MIN_TEMP)
                {
                    MessageBox.Show("Temperatura załączania diody led nie może być mniejsza niż " + Constants.DS1621_MIN_TEMP.ToString() + "!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (value > Constants.DS1621_MAX_TEMP)
                {
                    MessageBox.Show("Temperatura załączania diody led nie może być większa niż " + Constants.DS1621_MAX_TEMP.ToString() + "!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (serialPortMain.IsOpen)
                {
                    string command = "SET_LED_VALUE|" + ledNumber.ToString() + "|" + value.ToString("0.00", CultureInfo.InvariantCulture) + "\r\n";
                    serialPortMain.Write(command);
                }
                else
                {
                    MessageBox.Show("Port COM nie jest otwarty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format ustawienia diody led " + (ledNumber + 1).ToString() + "!!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Led1SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led1ValueTextBox.Text;
            SetLedValue(ref text, 0);
        }

        private void Led2SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led2ValueTextBox.Text;
            SetLedValue(ref text, 1);
        }

        private void Led3SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led3ValueTextBox.Text;
            SetLedValue(ref text, 2);
        }

        private void Led4SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led4ValueTextBox.Text;
            SetLedValue(ref text, 3);
        }

        private void Led5SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led5ValueTextBox.Text;
            SetLedValue(ref text, 4);
        }

        private void Led6SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led6ValueTextBox.Text;
            SetLedValue(ref text, 5);
        }

        private void Led7SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led7ValueTextBox.Text;
            SetLedValue(ref text, 6);
        }

        private void Led8SetValueButton_Click(object sender, EventArgs e)
        {
            string text = Led8ValueTextBox.Text;
            SetLedValue(ref text, 7);
        }
    }
}
