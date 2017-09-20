using System;
using Xamarin.Forms;

namespace Hanselman1.Portable.Controls
{
    public class Hanselman1NavigationPage : NavigationPage
    {
        public Hanselman1NavigationPage(Page root) : base(root)
        {
            Init();
        }

        public Hanselman1NavigationPage()
        {
            Init();
        }

        void Init()
        {

            BarBackgroundColor = Color.FromHex("#03A9F4");
            BarTextColor = Color.White;
        }
    }
}

