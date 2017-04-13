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
                Title = MasterDetailPageNavigation.Resources.AppResources.Materials,
                IconSource = "materials.png",
                TargetType = typeof(MaterialsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.Suppliers,
                IconSource = "factory.png",
                TargetType = typeof(SuppliersListViewPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.Defects,
                IconSource = "defects.png",
                TargetType = typeof(DefectsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.ProcessCards,
                IconSource = "processcard.png",
                TargetType = typeof(ProcessCardsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.Calculations,
                IconSource = "formula.png",
                TargetType = typeof(ToolsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.Privacy,
                IconSource = "privacy.png",
                TargetType = typeof(PrivacyPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.Disclaimer,
                IconSource = "disclaimer.png",
                TargetType = typeof(DisclaimerPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.AboutTheApp,
                IconSource = "about.png",
                TargetType = typeof(AboutPage)
            });
/*
 *            masterPageItems.Add(new MasterPageItem
            {
                Title = MasterDetailPageNavigation.Resources.AppResources.AboutValuedApps,
                IconSource = "world.png",
                TargetType = typeof(OnTheWebPage)
            });
*/
            listView.ItemsSource = masterPageItems;
        }
    }
}
