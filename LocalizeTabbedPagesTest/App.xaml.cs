﻿namespace LocalizeTabbedPagesTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainTabbedPage();
        }
    }
}