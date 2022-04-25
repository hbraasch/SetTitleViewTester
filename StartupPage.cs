using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetTitleViewTester
{
    internal class StartupPage : ContentPage
    {
        public StartupPage()
        {
            var titleLabel = new Label { Text = "StartupPage", BackgroundColor = Colors.Orange };
            NavigationPage.SetTitleView(this, titleLabel);

            Content = new Label { Text = titleLabel.Text };
        }

    }
}
