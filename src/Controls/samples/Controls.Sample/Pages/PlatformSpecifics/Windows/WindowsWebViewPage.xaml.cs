﻿using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace Maui.Controls.Sample.Pages
{
    public partial class WindowsWebViewPage : ContentPage
    {
        public WindowsWebViewPage()
        {
            InitializeComponent();

            _webView.Source = new HtmlWebViewSource
            {
                Html = @"<html><body><button onclick=""window.alert('Hello World from JavaScript');"">Click Me</button></body></html>"
            };
        }

        void OnToggleButtonClicked(object sender, EventArgs e)
        {
            _webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsJavaScriptAlertEnabled(!_webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().IsJavaScriptAlertEnabled());
        }
    }
}
