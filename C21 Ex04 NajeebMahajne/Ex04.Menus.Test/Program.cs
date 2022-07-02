using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
   public class Program
    {
        static void Main()
        {
            Ex04.Menus.interfaces.MainMenu firstMenu = new Ex04.Menus.interfaces.MainMenu();
            Ex04.Menus.interfaces.Option firstoption = new Ex04.Menus.interfaces.Option("Version And Spaces");
            firstMenu.r_Options.Add(firstoption);
            Ex04.Menus.interfaces.Option secondoption = new Ex04.Menus.interfaces.Option("Show Date/Time");
            firstMenu.r_Options.Add(secondoption);
            Ex04.Menus.interfaces.Option thirdoption = new Ex04.Menus.interfaces.Option("Count Spaces");
            Ex04.Menus.interfaces.Option forthoption = new Ex04.Menus.interfaces.Option("Show Version");
            Ex04.Menus.interfaces.Option fifthoption = new Ex04.Menus.interfaces.Option("Show Time");
            Ex04.Menus.interfaces.Option sixthoption = new Ex04.Menus.interfaces.Option("Show Date");
            firstMenu.r_Options[0].r_SecondLevelOptions.Add(thirdoption);
            firstMenu.r_Options[0].r_SecondLevelOptions.Add(forthoption);
            firstMenu.r_Options[1].r_SecondLevelOptions.Add(fifthoption);
            firstMenu.r_Options[1].r_SecondLevelOptions.Add(sixthoption);

            firstMenu.Show();
            Ex04.Menus.Delegates.MainMenu secondMenu = new Ex04.Menus.Delegates.MainMenu();
            Ex04.Menus.Delegates.Option secondMenuFirstOption = new Ex04.Menus.Delegates.Option("Version And Spaces");
            Ex04.Menus.Delegates.Option secondMenuSecondOption = new Ex04.Menus.Delegates.Option("Show Date/Time");
            Ex04.Menus.Delegates.Option secondMenuThirdOption = new Ex04.Menus.Delegates.Option("Count Spaces");
            Ex04.Menus.Delegates.Option secondMenuForthOption = new Ex04.Menus.Delegates.Option("Show Version");
            Ex04.Menus.Delegates.Option secondMenuFifthOption = new Ex04.Menus.Delegates.Option("Show Time");
            Ex04.Menus.Delegates.Option secondMenuSixithOption = new Ex04.Menus.Delegates.Option("Show Date");
            secondMenu.r_Options.Add(secondMenuFirstOption);

            secondMenu.r_Options.Add(secondMenuSecondOption);

            secondMenu.r_Options[0].r_SecondLevelOptions.Add(secondMenuThirdOption);
            secondMenu.r_Options[0].r_SecondLevelOptions.Add(secondMenuForthOption);
            secondMenu.r_Options[1].r_SecondLevelOptions.Add(secondMenuFifthOption);
            secondMenu.r_Options[1].r_SecondLevelOptions.Add(secondMenuSixithOption);

            secondMenu.Show();
        }
    }
}
