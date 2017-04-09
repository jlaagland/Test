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
                IconSource = "materials.png",
                TargetType = typeof(MaterialsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Suppliers",
                IconSource = "factory.png",
                TargetType = typeof(SuppliersPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Defects",
                IconSource = "defects.png",
                TargetType = typeof(DefectsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Process Cards",
                IconSource = "processcard.png",
                TargetType = typeof(ProcessCardsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Calculations",
                IconSource = "formula.png",
                TargetType = typeof(ToolsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Privacy",
                IconSource = "privacy.png",
                TargetType = typeof(PrivacyPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Disclaimer",
                IconSource = "disclaimer.png",
                TargetType = typeof(DisclaimerPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About",
                IconSource = "about.png",
                TargetType = typeof(AboutPage)
            });
            listView.ItemsSource = masterPageItems;
        }
    }
}
