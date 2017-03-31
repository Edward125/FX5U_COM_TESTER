using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace FX5U_COM_TESTER
{
    public partial class Form1 : Form
    {
        #region IntiallizeForm

        public Form1()
        {
            InitializeComponent();
        }

        string exeTitle = "FX5U COM Tester,Ver.:" + Application.ProductVersion + ",Author:Edward";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = exeTitle;
            //
            getSerialPort(comboPortName);
            comboBaudRate.SelectedIndex = 0;
            comboDataBits.SelectedIndex = 3;
            comboStopBits.SelectedIndex = 0;
            comboParity.SelectedIndex = 0;

        }
        
        #endregion

        #region ParamDefine

        //
        const string  _ENQ = "05";
        const string _FRAME_FLAG_4C = "4638";
        const string _FRAME_FLAG_3C = "4639";
        const string _STAGE_FLAG ="3030";
        const string _NET_FLAG = "3030";
        const string _PLC_FLAG = "4646";
        const string _ENQ_IO_FLAG = "30334646";
        const string _ENQ_TARGET_FLAG = "3030";
        const string _UPPER_STAGE_FLAG = "3030";
        const string _END = "0D0A";

        const string _COMM_HEAD_4C = _ENQ + _FRAME_FLAG_4C + _STAGE_FLAG + _NET_FLAG+ _PLC_FLAG + _ENQ_IO_FLAG +  _ENQ_TARGET_FLAG + _UPPER_STAGE_FLAG;
        const string _COMM_HEAD_3C = _ENQ + _FRAME_FLAG_3C + _STAGE_FLAG + _NET_FLAG + _PLC_FLAG + _ENQ_TARGET_FLAG ;
        //

        private string _COMMAND = string.Empty;
        private string _SUBCOMMAND = string.Empty;

        //
        delegate void Display(Byte[] buffer);

        delegate void DisplayT(string text);

        private void DisplayHEX(Byte[] buffer)
        {
            txtDisplay.Text += String.Format("{0}{1}", BitConverter.ToString(buffer), Environment.NewLine);
            //totalLength = totalLength + buffer.Length;
            //Label2.Text = totalLength.ToString();
        }

        private void DisplayText(string text)
        {
            txtDisplay.Text += text;
        }


        #endregion

        #region COM Select

        private void comboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            spPLC.BaudRate = Convert.ToInt32(comboBaudRate.Text.Trim());

        }

        private void comboParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectParity();
        }

        private void selectParity()
        {
            switch (comboParity.Text.Trim().ToUpper ())
            {

                case "NONE":
                    spPLC.Parity = Parity.None;
                    break;
               case "EVEN":
                    spPLC.Parity = Parity.Even ;
                    break;
                case "ODD" :
                    spPLC.Parity = Parity.Odd;
                    break;
                case "MARK":
                    spPLC.Parity = Parity.Mark;
                    break;
                case "SPACE":
                    spPLC.Parity = Parity.Space ;
                    break;
                default:
                    break;
            }
        }

        private void comboDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            spPLC.DataBits = Convert.ToInt16(comboDataBits .Text.Trim());

        }

        private void comboStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectStopBits();
        }

        private void selectStopBits()
        {
            switch (comboStopBits.Text.Trim())
            {
                case "1":
                    spPLC.StopBits = StopBits.One;
                    break;
                case "1.5":
                    spPLC.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    spPLC.StopBits = StopBits.Two;
                    break;
                default:
                    spPLC.StopBits = StopBits.None;
                    break;
            }
        }

        private void getSerialPort(ComboBox comboportname)
        {
            foreach (string st in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboportname.Items.Add(st);
            }

            if (comboportname.Items.Count > 0)
                comboportname.SelectedIndex = 0;
        }

        private void comboPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            spPLC.PortName = comboPortName.Text.Trim();

        }

        #endregion

        #region OPEN CLOSE COM

        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (!spPLC.IsOpen)
            {
                try
                {
                    spPLC.Open();
                    btnOpen.Text = "CLOSE";
                    this.Text = exeTitle + "->" + spPLC.PortName + " already OPEN";
                    //
                    portOpen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    spPLC.Close();
                    btnOpen.Text = "OPEN";
                    this.Text = exeTitle + "->" + spPLC.PortName + " already CLOSED";
                    portClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }


        }

        private void portOpen()
        {
            comboPortName.Enabled = false;
            comboBaudRate.Enabled = false;
            comboStopBits.Enabled = false;
            comboDataBits.Enabled = false;
            comboParity.Enabled = false;
        }
        private void portClose()
        {
            comboPortName.Enabled = true;
            comboBaudRate.Enabled = true;
            comboStopBits.Enabled = true;
            comboDataBits.Enabled = true;
            comboParity.Enabled = true;
        }
        #endregion





        /// <summary>
        /// 獲取校驗碼，不包含命令頭
        /// </summary>
        /// <param name="allStr">不包含命令頭的數據</param>
        /// <param name="headFlag">含有命令頭,true；不含有命令頭,false</param>
        /// <returns>返回sum值</returns>
        public static string Get422Sum(string allStr, bool headFlag)
        {
            string result = string.Empty;
            Int32 tempsum = 0;
            string tempGetSum = string.Empty;

            if (headFlag)  //含有命令頭，去掉
            {
                try
                {
                    allStr = allStr.Substring(2, allStr.Length - 2);
                }
                catch (Exception)
                {

                    throw;
                }

            }

            try
            {
                for (int i = 0; i <= allStr.Length - 1; i += 2)
                {
                    tempsum = tempsum + Convert.ToInt32(ConverString(allStr.Substring(i, 2).ToUpper(), 16, 10));
                }
                tempGetSum = ConverString(tempsum.ToString(), 10, 16).ToUpper();
                tempGetSum = tempGetSum.ToString().Substring(tempGetSum.ToString().Length - 2, 2);//防止溢出
                for (int i = 0; i <= 1; i++)
                {
                    result = result + ConverString(Asc(tempGetSum.Substring(i, 1)).ToString(), 10, 16);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        /// <summary>
        /// 進制轉換
        /// </summary>
        /// <param name="value">需要轉換的值</param>
        /// <param name="fromBase">原進制</param>
        /// <param name="toBase">需要轉換的進制</param>
        /// <returns>返回的結果</returns>
        public static string ConverString(string value, int fromBase, int toBase)
        {
            Int32 n = Convert.ToInt32(value, fromBase);
            return Convert.ToString(n, toBase);
        }

        /// <summary>
        /// 獲取校驗碼，不包含命令頭
        /// </summary>
        /// <param name="allStr">不包含命令頭的數據</param>
        /// <returns>返回Sum值</returns>
        public static string Get422Sum(string allStr)
        {
            string result = string.Empty;
            Int32 tempsum = 0;
            string tempGetSum = string.Empty;
            try
            {
                for (int i = 0; i <= allStr.Length - 1; i += 2)
                {
                    tempsum = tempsum + Convert.ToInt32(ConverString(allStr.Substring(i, 2).ToUpper(), 16, 10));
                }
                tempGetSum = ConverString(tempsum.ToString(), 10, 16).ToUpper();
                tempGetSum = tempGetSum.ToString().Substring(tempGetSum.ToString().Length - 2, 2);//防止溢出
                for (int i = 0; i <= 1; i++)
                {
                    result = result + ConverString(Asc(tempGetSum.Substring(i, 1)).ToString(), 10, 16);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }



        #region Asc Chr convert
        /// <summary>
        /// convert the asc code to character
        /// </summary>
        /// <param name="asciiCode"></param>
        /// <returns></returns>
        public static string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }

        }

        /// <summary>
        /// convert the character to Asc code
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static int Asc(string character)
        {
            if (character.Length == 1)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
                return (intAsciiCode);
            }
            else
            {
                throw new Exception("Character is not valid.");
            }
        }
        #endregion

        private void btnPLC_RUN_Click(object sender, EventArgs e)
        {
            _COMMAND = "31303031";
            _SUBCOMMAND = "303030303030303130303030";

            string _SUM_CHECK = _COMM_HEAD_3C + _COMMAND + _SUBCOMMAND;
            string SEND_STRING = _SUM_CHECK + Get422Sum(_SUM_CHECK, true) + _END;

            if (spPLC.IsOpen)
            {
                sendHex(spPLC, SEND_STRING);
            }
            else
            {
                MessageBox.Show("Port is not OPEN.");
                return;
            }
        }


        private void sendHex(SerialPort spport, string strdata)
        {
            try
            {
                byte[] outBytes = new byte[strdata.Length / 2];
                for (int i = 1; i <= strdata.Length - 1; i += 2)
                {
                    outBytes[(i - 1) / 2] = (byte)Convert.ToInt32(("0x" + strdata.Substring(i - 1, 2)), 16);
                }
                spport.Write(outBytes, 0, outBytes.Length);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void btnPLC_STOP_Click(object sender, EventArgs e)
        {
            _COMMAND = "31303032";
            _SUBCOMMAND = "3030303030303030";

            string _SUM_CHECK = _COMM_HEAD_3C + _COMMAND + _SUBCOMMAND;
            string SEND_STRING = _SUM_CHECK + Get422Sum(_SUM_CHECK, true) + _END;

            if (spPLC.IsOpen)
            {
                sendHex(spPLC, SEND_STRING);
            }
            else
            {
                MessageBox.Show("Port is not OPEN.");
                return;
            }
        }

        private void btnGetPLCType_Click(object sender, EventArgs e)
        {
            _COMMAND = "30313031";
            _SUBCOMMAND = "30303030";

            string _SUM_CHECK = _COMM_HEAD_3C + _COMMAND + _SUBCOMMAND;
            string SEND_STRING = _SUM_CHECK + Get422Sum(_SUM_CHECK, true) + _END;

            if (spPLC.IsOpen)
            {
                sendHex(spPLC, SEND_STRING);
            }
            else
            {
                MessageBox.Show("Port is not OPEN.");
                return;
            }
        }

        private void spPLC_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            if (rabHEX.Checked )
            {
                Byte[] buffer = new Byte[1024];
                Int32 length = (sender as SerialPort).Read(buffer, 0, buffer.Length);
                Array.Resize(ref buffer, length);
                Display d = new Display(DisplayHEX);
                this.Invoke(d, new Object[] { buffer });
            }

            if (rabASCII.Checked)
            {



                string temp = spPLC.ReadExisting();

                DisplayT d = new DisplayT(DisplayText);

                this.Invoke(d, new object[] { temp });

            }
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnReadDevices_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty (txtReadPLCDevice .Text.Trim ()))
                return;
            if (txtReadPLCDevice.Text.Trim().ToUpper().StartsWith("D"))
            {


                _COMMAND = "30343031";
                _SUBCOMMAND = "30303030";

                string _DEVICE = "442A";

                string _DEVICE_FLAG = formatstring2Hex(txtReadPLCDevice.Text.Substring(1, txtReadPLCDevice.Text.Trim().Length - 1), 6);

                string _DEVICE_COUNT = formatstring2Hex(txtWriteDeviceCount.Text.Trim(), 4);

                MessageBox.Show(_DEVICE_COUNT);


                string _SUM_CHECK = _COMM_HEAD_3C + _COMMAND + _SUBCOMMAND + _DEVICE + _DEVICE_FLAG + _DEVICE_COUNT;
                string SEND_STRING = _SUM_CHECK + Get422Sum(_SUM_CHECK, true) + _END;


                //txtDisplay.Text = SEND_STRING;

                if (spPLC.IsOpen)
                {
                    sendHex(spPLC, SEND_STRING);
                }
                else
                {
                    MessageBox.Show("Port is not OPEN.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Current only support 'D' device.");
                return;
            }
        }



        private string formatstring2Hex(string oldstring, int newstringlength)
        {
            string result = string.Empty;

            //string tempdevice = txtReadPLCDevice.Text.Substring(1, txtReadPLCDevice.Text.Trim().Length - 1);

            //if (tempdevice.Length <= 6)
            //{
            //    for (int i = 0; i <= (6 - tempdevice.Length); i++)
            //    {
            //        tempdevice = "0" + tempdevice;
            //    }
            //}

            //string _DEVICE_FLAG = string.Empty;

            //for (int i = 0; i < tempdevice.Length; i++)
            //{
            //    _DEVICE_FLAG = _DEVICE_FLAG + ConverString(Asc(tempdevice.Substring(i, 1)).ToString(), 10, 16);
            //} 

            ////===========
           // string tempdevice = oldstring.Substring(1, oldstring.Length   - 1);

            if (oldstring.Length <= newstringlength )
            {
                for (int i = 0; i <= (6 - oldstring.Length); i++)
                {
                    oldstring = "0" + oldstring;
                }
            }

            string _DEVICE_FLAG = string.Empty;

            for (int i = 0; i < oldstring.Length; i++)
            {
               result  = result  + ConverString(Asc(oldstring.Substring(i, 1)).ToString(), 10, 16);
            }

            return result;



        }

        private void btnWriteDevice_Click(object sender, EventArgs e)
        {

       
            if (string.IsNullOrEmpty (txtWritePLCDevice .Text.Trim ()))
                return ;
            if (string.IsNullOrEmpty (txtWriteDeviceCount .Text.Trim ()))
                return ;
            if (string.IsNullOrEmpty (txtWriteValue .Text.Trim ()))
                return ;

            if (txtWritePLCDevice.Text.Trim().ToUpper().StartsWith("D"))
            {
               // MessageBox.Show(Asc("0").ToString());

                _COMMAND = "31343031";
                _SUBCOMMAND = "30303030";

                string _DEVICE = "442A";

                string _DEVICE_FLAG = formatstring2Hex(txtWritePLCDevice.Text.Substring(1, txtWritePLCDevice.Text.Trim().Length - 1), 6);


               // MessageBox.Show(_DEVICE_FLAG);


                string _DEVICE_COUNT = formatstring2Hex(txtWriteDeviceCount.Text.Trim(), 4);
               // MessageBox.Show(_DEVICE_COUNT);

                string _DEVICE_VALUE = string.Empty;

                //MessageBox.Show(_DEVICE_COUNT);

                _DEVICE_VALUE = ConverString(txtWriteValue.Text.Trim(), 10, 16);
              //  MessageBox.Show(_DEVICE_VALUE);

                for (int i = 0; i <= (4 - _DEVICE_VALUE.Length); i++)
                {
                    _DEVICE_VALUE = "0" + _DEVICE_VALUE;
                }



                string temp_device = string.Empty;

                for (int i = 0; i < _DEVICE_VALUE.Length; i++)
                {
                    temp_device =temp_device + ConverString(Asc(_DEVICE_VALUE.Substring(i, 1)).ToString(), 10, 16);
                }
                _DEVICE_VALUE = temp_device;

               // MessageBox.Show(_DEVICE_VALUE);

                //MessageBox.Show(_DEVICE_VALUE);
                //return;


                string _SUM_CHECK = _COMM_HEAD_3C + _COMMAND + _SUBCOMMAND + _DEVICE + _DEVICE_FLAG + _DEVICE_COUNT + _DEVICE_VALUE;
                string SEND_STRING = _SUM_CHECK + Get422Sum(_SUM_CHECK, true) + _END;


                //txtDisplay.Text = _SUM_CHECK;
                //txtDisplay.Text = SEND_STRING;

                //MessageBox.Show(_SUM_CHECK);

                //txtDisplay.Text = SEND_STRING;

                if (spPLC.IsOpen)
                {
                    sendHex(spPLC, SEND_STRING);
                }
                else
                {
                    MessageBox.Show("Port is not OPEN.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Current only support 'D' device.");
                return;
            }
        }


    }
}
