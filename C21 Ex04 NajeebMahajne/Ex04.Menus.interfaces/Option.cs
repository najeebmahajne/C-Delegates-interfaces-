using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.interfaces
{
    public interface INotify 
    {
        void OnClick(Option i_option);
    }

    public class Option
    {
        private String m_Text;
        private bool m_Clicked;

        public bool Click
            { get { return m_Clicked; }
            set { m_Clicked = value;
                doWhenClicked();
            }
        }
        public readonly List<Option> r_SecondLevelOptions = new List<Option>();

        private void doWhenClicked()
        {


            if (m_Clicked == true && this.r_SecondLevelOptions.Count == 0)
            {
                switch (this.OptionText)
                {
                    case "Count Spaces":
                        MainMenu.CountSpaces();


                        break;
                    case "Show Version":
                        MainMenu.ShowVersion();
                        break;
                    case "Show Time":
                        MainMenu.ShowTime();

                        break;
                    case "Show Date":
                        MainMenu.ShowDate();

                        break;

                }
            }
            else if (m_Clicked == true && this.r_SecondLevelOptions != null)
            {
                Console.Clear();
                bool flag = true;
                while (flag)
                {
                    
                Console.WriteLine(this.OptionText + " :");
                Console.WriteLine("==============================");
                int i = 1;
                foreach (Option option in this.r_SecondLevelOptions)
                {
                    Console.WriteLine(i + " - " + option.OptionText);
                    i++;
                }
                Console.WriteLine("0 to BACK ");
                Console.WriteLine("Please Enter an Option :");
                
                    String input = Console.ReadLine();
                    int integerInput = int.Parse(input);
                    if (integerInput == 0)
                    {
                        flag = false;
                        Console.Clear();
                        (m_Notify as MainMenu).Show();
                        
                    }
                    if (integerInput != 0 && integerInput <= r_SecondLevelOptions.Count)
                    {

                        integerInput--;
                        
                        m_Notify.OnClick(this.r_SecondLevelOptions[integerInput]);
                        


                    }
                    

                }
            }
            
        }

        
        private INotify m_Notify;
        public INotify Notify
        {
            get { return m_Notify; }
            set { m_Notify = value; }
        }
        public Option(String i_OptionText)
        {
            this.OptionText = i_OptionText;
        }
        public string OptionText
        {
            get { return m_Text; }
            set { m_Text = value; }
        }
       
        
    }
}
