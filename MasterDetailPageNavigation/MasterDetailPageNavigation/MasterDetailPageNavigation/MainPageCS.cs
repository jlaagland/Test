using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public class MainPageCS : MasterDetailPage
    {
        MasterPageCS masterPage;

        public MainPageCS()
        {
            MasterBehavior = MasterBehavior.Popover;
            masterPage = new MasterPageCS();
            Master = masterPage;
            Detail = new NavigationPage(new ContactsPageCS());
        }
    }
}
