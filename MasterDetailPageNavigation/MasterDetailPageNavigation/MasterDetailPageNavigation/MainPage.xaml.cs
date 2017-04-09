﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new MaterialsPage());
            masterPage.ListView.ItemSelected += OnItemSelected;

            if (Device.OS == TargetPlatform.Windows)
            {
                Master.Icon = "swap.png";
            }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

        void NavigationPage_Appearing(object sender, System.EventArgs e)
        {
            NaviPage.Effects.Add(new ShadowEffect()
            {
                Radius = 15,
                DistanceX = -20,
                DistanceY = 0,
                Color = Color.Black
            });
        }
    }
}
