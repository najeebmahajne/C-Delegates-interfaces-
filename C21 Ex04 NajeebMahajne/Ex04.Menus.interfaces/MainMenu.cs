using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.interfaces
{
    public class MainMenu:INotify
    {
        public readonly List<Option> r_Options = new List<Option>();


       



        public void Show()
        {
            Console.WriteLine("Welcome To Main Menu level 1 :");
            Console.WriteLine("==============================");
            int i = 1;
            foreach (Option option in r_Options)
            {
                Console.WriteLine(i+" - "  + option.OptionText);
                option.Notify = this;
                i++;
            }
            Console.WriteLine("Please Choose a number or 0 To Exit");
            string input = Console.ReadLine();
            int integerInput = int.Parse(input);
            if (integerInput == 0)
            {
                Console.WriteLine("Exit , BYE BYE!");
            }
            if (integerInput != 0 && integerInput <= r_Options.Count)
            {
                
                integerInput--;
                r_Options[integerInput].Click=true;
                
                
                
            }
           
        }
        public void OnClick(Option i_Option)
        {
            i_Option.Click = true;
            Console.WriteLine("Button " + i_Option.OptionText+ " Was Clicked!");


        }
        public static void CountSpaces()
        {
            Console.WriteLine("Please Enter a String : ");
            String input = Console.ReadLine();
            int count = 0;
            
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            Console.WriteLine("There Was "+count+" Spaces in your String"); 
        }
        public static void ShowVersion()
        {
            Console.WriteLine("Version: 21.3.4.8933");
        }
        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm tt"));
        }
        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
        }



    }
}
