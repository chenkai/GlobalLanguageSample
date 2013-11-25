using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GlobalLanguageDemo.Resources;

using System.Resources;
using System.Reflection;
namespace GlobalLanguageDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {     
       
        }

        private void LanguageChanged_LP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        #region Swithc System Language When Application ReStart

        #region Property Language
        ResourceManager _englisthManager;
        ResourceManager _chineseManager;

        AppResources _englishResources;
        AppResources _chineseResources;

        LocalizedStrings locStrings;
        #endregion

        private void ChangeLanguageInit()
        {
            #region Switch UI English Language
            _englisthManager = new System.Resources.ResourceManager("GlobalLanguageDemo.Resources.SwitchLanguage.AppResources-en-US", Assembly.Load("GlobalLanguageDemo"));
            _englishResources = new AppResources();
            #endregion

            #region Switch UI Chinese Language
            _chineseManager = new System.Resources.ResourceManager("GlobalLanguageDemo.Resources.SwitchLanguage.AppResources", Assembly.Load("GlobalLanguageDemo"));
            locStrings = Application.Current.Resources["LocalizedStrings"] as LocalizedStrings;
            _chineseResources = locStrings.LocalizedResources;
            #endregion

        }

        private void SwitchLanguageByConfig(string saveLanguageConfig)
        {
            if (string.IsNullOrEmpty(saveLanguageConfig))
                return;

            switch (saveLanguageConfig)
            {
                case "Chinese Simplified":
                    AppResources.ResourceManager = _chineseManager;
                    break;
                case "English":
                    AppResources.ResourceManager = _englisthManager;
                    break;       
            }
        }
        #endregion
    }
} 