using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class NetworkConnection : ICloneable
    {
        private string IP;
        private string importantData;


        public void setIp(string ip)
        {
            this.IP = ip;
        }
        public void setImportantdata(string importantdata)
        {
            this.importantData = importantdata;
        }
        public string getImportantData() 
        { 
            return this.importantData;
        }


        public void loadimportantData()
        {
            //If it take more time then during object creation of every time it will take a lot time 
            this.importantData = "Important Data";

            //We we added to check load data for first object it will take time but for second it will not take lot time.
            Thread.Sleep(3000);
        }

        public override string ToString()
        {
            return this.importantData + ": " + this.IP;  
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
