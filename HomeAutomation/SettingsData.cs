using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation
{
    
    static class SettingsData
    {
        static internal string path = "settings.dat";
        static internal string IP = "";
        static internal string serialPort = "";
        static internal string baudRate = "";
        static internal string socketPort = "";
        static internal void getSettingsData(){
            try{
                using (StreamReader sr = File.OpenText(path))
                {

                    setData(sr.ReadLine());
                    setData(sr.ReadLine());
                    setData(sr.ReadLine());
                    setData(sr.ReadLine());
                    sr.Close();
                }
            }catch(Exception ex){
                throw ex;
            }
        }
        static private void setData(string str)
        {
            if(str.Split(' ')[0].Equals("IP"))
            {
                IP = str.Split(' ')[1];
            }
            else if (str.Split(' ')[0].Equals("serialPort"))
            {
                serialPort = str.Split(' ')[1];
            }
            else if (str.Split(' ')[0].Equals("baudRate"))
            {
                baudRate = str.Split(' ')[1];
            }
            else if (str.Split(' ')[0].Equals("portNumber"))
            {
                socketPort = str.Split(' ')[1];
            }

        }

    }
}
