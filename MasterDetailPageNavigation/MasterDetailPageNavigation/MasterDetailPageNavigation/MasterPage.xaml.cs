using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Materials",
                IconSource = "tab_feed.png",
                TargetType = typeof(MaterialsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Suppliers",
                IconSource = "tab_feed.png",
                TargetType = typeof(SuppliersPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Defects",
                IconSource = "tab_feed.png",
                TargetType = typeof(DefectsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Process Cards",
                IconSource = "tab_feed.png",
                TargetType = typeof(ProcessCardsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Tools",
                IconSource = "tab_feed.png",
                TargetType = typeof(ToolsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Privacy",
                IconSource = "tab_feed.png",
                TargetType = typeof(PrivacyPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Disclaimer",
                IconSource = "tab_feed.png",
                TargetType = typeof(DisclaimerPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About",
                IconSource = "tab_about.png",
                TargetType = typeof(AboutPage)
            });
            listView.ItemsSource = masterPageItems;
        }
    }
}
