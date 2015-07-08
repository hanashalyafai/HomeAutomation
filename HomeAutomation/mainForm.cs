using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAutomation
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            try
            {
                SettingsData.getSettingsData();
            }
            catch (Exception ex )
            {
                string str = ex.StackTrace;

                MessageBox.Show("couldn't load settings!\n", "FATAL ERROR", MessageBoxButtons.OK);
                Application.Exit();

            }
            //communicationHandler();

        }

        private void communicationHandler()
        {

            string ss = "";
            if (ss != "")
            {
                Serial.write(ss);
                ss = "";
            }


            //throw new NotImplementedException();
        }


        private void stopWhole_Click(object sender, EventArgs e)
        {
            try
            {
                stopSerialPort_();
                stopSocketPort_();


                //Serial.write("1#");
                this.status.Text = "The whole program is stopped!\n";
                error = "";
            }
            catch (Exception ex)
            {
                this.status.Text = "Couldn't stop the program!\n";
                this.status.Text += ex.Message;

                error = ex.StackTrace;
            }
            finally {
                this.Refresh();
            }

        }

        private void stopSocketPort_()
        {
            try
            {
                thread.Abort();
                Socket.Close();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

       

        private void quit_Click(object sender, EventArgs e)
        {
            //MessageBox
            DialogResult res = MessageBox.Show("closing this application may isolate your home system!", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
                /*
                try
                {
                    thread.Abort();
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    this.status.Text = "Couldn't quit the program!\n";
                    this.status.Text += ex.Message;
                    error = ex.StackTrace;
//                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Refresh();
                }
                 * 
                 */
            }
        }

        private void startWhole_Click(object sender, EventArgs e)
        {
            try
            {
                startSerialPort_();
                startSocketPort_();
                this.status.Text = "The whole program is running!";
                error = "";
            }
            catch (Exception ex) {
                error = ex.StackTrace;
                this.status.Text = "The program couldn't start up!\n";
                this.status.Text += "Technical info:\n" + ex.Message;
            }
            finally
            {
                this.Refresh();
            }
        }
        private void startSerialPort_() {
            try
            {
                Serial.init_serial();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void startSerialPort_Click(object sender, EventArgs e)
        {
            // call to fun in other calss ^^ :) 
            try
            {
                startSerialPort_();
                error = "";
                this.status.Text = "serial is initialized!\n";
            }
            catch (Exception ex)
            {
                this.status.Text = "serial couldn't be initialized!\n";
                this.status.Text += ex.Message;
                error = ex.StackTrace;
            }
            finally {
                this.Refresh();
            }
        }

        private void stopSerialPort_() {
            try
            {
                Serial.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void stopSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                stopSerialPort_();
                this.status.Text = "Serial port is closed!";
                error = "";
            }
            catch (Exception ex)
            {
                this.status.Text = "Couldn't close serial port!\n";
                this.status.Text += ex.Message;
                error = ex.StackTrace;
//                MessageBox.Show(ex.Message, "try again later!");
            }
            finally
            {
                this.Refresh();
            }
        }

        private void stopSocketPort_Click(object sender, EventArgs e)
        {
            try
            {

                stopSocketPort_();
                this.status.Text = "Socket is stopped!\nYour house is isolated!";
                error = "";
            }
            catch (Exception ex)
            {
                this.status.Text = "Couldn't stop socket port!\n";
                this.status.Text += ex.Message;
                error = ex.StackTrace;
                

                //MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Refresh();
            }
        }
        private void startSocketPort_() {
            try
            {
                Socket.init_socket();

                thread = new Thread(new ThreadStart(Socket.Read));
                thread.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void startSocketPort_Click(object sender, EventArgs e)
        {
            try
            {
                //Serial.init_serial();
                startSocketPort_();
               // MessageBox.Show("Working");
               
                this.status.Text = "Socket is started!";
                error = "";
                //MessageBox.Show("Working");

            }
            catch (Exception ex)
            {
               // MessageBox.Show("dddddddd");
                this.status.Text = "couldn't start the socket!\n";
                this.status.Text += ex.Message;
                error = ex.StackTrace;

//                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Refresh();
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // open a new form that takes input from user 

            Settings settings = new Settings();
            settings.init(this);
            
            //this.Hide();

            //this.Show();


            /*
            try
            {
                //Settings.getSettings();
                this.status.Text = "Settings loadded!\n";
                error = "";
            }
            catch (Exception ex)
            {
                this.status.Text = "couldn't load settings, this application may not work properly!\n";
                this.status.Text += ex.Message;
                error = ex.StackTrace;
            }
            finally {
                this.Refresh();
            }
            */
        }

        private void startLogging_Click(object sender, EventArgs e)
        {

        }

        

        public string error { get; set; }

        private void notSet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(error);

        }

        private void stopLogging_Click(object sender, EventArgs e)
        {

        }

        private void flushLog_Click(object sender, EventArgs e)
        {

        }

        public Thread thread { get; set; }

       
    }
}
