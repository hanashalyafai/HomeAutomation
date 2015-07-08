using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAutomation
{
    static class Serial
    {

        private static SerialPort sp;
        public static string data = "";

        public static string[] getPortNames()
        {
            return System.IO.Ports.SerialPort.GetPortNames();
        }

        public static bool init_serial()
        {
            sp = new SerialPort();

            String spName = SettingsData.serialPort; // System.IO.Ports.SerialPort.GetPortNames()[0]; // can be changed to whatever !

            //            MessageBox.Show(spName);

            if (sp != null && sp.IsOpen)
                sp.Close();

            sp = new SerialPort(spName, Convert.ToInt32(SettingsData.baudRate));
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            sp.Open();


            return true;
        }
        public static void write(string data)
        {
            try
            {
                sp.Write(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       // public static StreamWriter sw = new StreamWriter("aything.jpg");
        private static void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //  MessageBox.Show("Data Recieved");
            

            try
            {

                data = sp.ReadTo("#end"); // + "\x03"; // to be sent to Website .. via Socket 
                
                /// this if else condition is just for testing 
                //if (!data.Contains("done!"))
                //{
                //    // copy data to bytes array !! 
                    //Serial.sw.Write(data);
               // }
                //else
                //{
                    //Serial.sw.Close();
                //}
                //MessageBox.Show(data);
                Socket.Write(data);
                
                // Socket.Write(data);

                // mainForm.status.Text = data;
                // mainForm.ActiveForm.Activate();

            }

            catch (Exception ex)
            {
                throw ex;
                /// check settings 


                // MessageBox.Show(ex.Message);

            }


            //MessageBox.Show(data);

        }


        internal static void Close()
        {
            try
            {
                sp.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
