using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAutomation
{
    
    public partial class Settings : Form
    {
        internal class ComboBoxItem
        {

            public string Text { get; set; }
            public object Value { get; set; }
            public ComboBoxItem(string Text, string Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
            public override string ToString()
            {
                return Text;
            }
        }
        string path = "settings.dat";
        mainForm main;
        public Settings()
        {
            InitializeComponent();


        }
        internal List<string> settingsList;

        internal void init(mainForm main)
        {
            /*
             * read settings from user
             * set defaults of form to them
             * plah plah 
             */
           
            if (File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path)) {
                   settingsList = new List<string>();
                    string s="";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if(s[0] != '#')
                            settingsList.Add(s);
                    }
                    sr.Close();

                    foreach(string elem in settingsList){
                        string[] parts = elem.Split(' ');
                        Control c = this.Controls.Find(parts[0], true)[0];
                        c.Text = parts[1];
                    }
                }

            }
            else
            {
                MessageBox.Show("Settings file doesn't exist, please sove this problem first!", "Error!!", MessageBoxButtons.OK);
                closeSettings();
            }
                /*
            else if (File.Exists("default.dat")) { 
                
            }
                 * */
            this.caution.Text = "Make sure to select the correct settings,\nother wise leave defaults as is!";
            /*
             * 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, or 115200.
             * */

            string[] items = {"300","600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200"};
            foreach (string item in items)
            {
                this.baudRate.Items.Add(new ComboBoxItem(item,item));
            }
            string[] ports = Serial.getPortNames();
            foreach (string item in ports)
            {
                this.serialPort.Items.Add(new ComboBoxItem(item, item));
            }

            this.Refresh();
            this.Show();
            this.main = main;
            this.main.Hide();
            //MessageBox.Show("Hello maaaaaaaan ");
        }

        private void closeSettings()
        {
            this.Close();
            this.main.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {   
            DialogResult res = MessageBox.Show("Do you want to save new settings an quit?", "Save and quit?", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                // save to file :) 
                // then close !! :)
                using (StreamWriter sw = new StreamWriter(path))
                {
                    string str="";
                    foreach (string item in settingsList)
                    {
                        string[] parts = item.Split(' ');
                        str += item.Replace(parts[1],this.Controls.Find(parts[0], true)[0].Text)+"\n";

                    }
                    str.Remove(str.Length - 1);
                    sw.Write(str);
                    sw.Close();

                }
                closeSettings();
            }      
            else if (res == DialogResult.No)
            {   
                this.Close();
                this.main.Show();
            }   
            else if (res == DialogResult.Cancel)
            {   
                // do nothing :)
                
                return;
            }   
        }

        private void loadDefault_Click(object sender, EventArgs e)
        {
            if (File.Exists("default.dat"))
            {
                using (StreamReader sr = File.OpenText("default.dat"))
                using( StreamWriter sw = new StreamWriter(path)){
                    string str="";
                    str = sr.ReadToEnd();
                    sw.Write(str);
                    sr.Close();
                    sw.Close();
                }
                init(this.main);

            }
            else
            {
                MessageBox.Show("Settings file doesn't exist, please sove this problem first!", "Error!!", MessageBoxButtons.OK);
                //closeSettings();
            }

        }

        
    }
}
