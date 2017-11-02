using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BANK
{
    class BankAccount
    {
        private string id ;
        private double checking,saving;
        public BankAccount(){id="???";checking=0;saving=0;}
        public BankAccount(String initID, double initChecking, double initSaving)
        {
            id = initID;
            checking = initChecking;
            saving=initSaving;
        }
        public double Checking
        { 
            get { return checking; } 
            set { checking = value; }
        }
        public double Saving
        {
            get { return saving; }
            set { saving = value; }
        }
        public String getID() { return id; }
        public void setID(String name){id=name;}
        public	void addInterest()
        {
            if(checking<=1000)
            {
                checking=checking*1.025;
                saving=saving*1.025;
            }
            if (checking>1000&&checking<5000)
            {
                 checking=checking*1.035;
                 saving=saving*1.035;
            }
            if (checking>=5000)
            {
                 checking=checking*1.045;
                 saving=saving*1.045;
            }
        }
        public void display()
        {
            Console.WriteLine("ID:{0}", id);
            Console.WriteLine("Checking Balance: ${0:N}", checking);
            Console.WriteLine("Saving Balance: ${0:N}", saving);
        }
    }
}
