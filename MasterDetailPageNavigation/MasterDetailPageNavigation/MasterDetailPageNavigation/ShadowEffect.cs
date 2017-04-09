using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using MasterDetailPageNavigation;

[assembly: ExportEffect(typeof(ShadowEffect), "ShadowEffect")]
namespace MasterDetailPageNavigation
{
    public class ShadowEffect : RoutingEffect
    {
        public float Radius { get; set; }
        public Color Color { get; set; }
        public float DistanceX { get; set; }
        public float DistanceY { get; set; }
        public ShadowEffect() : base("MasterDetailPageNavigation.PanelShadowEffect")
        {
        }
    }
}
