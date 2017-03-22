using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using UWP_SemanticZoom_Gridview.Common;

namespace UWP_SemanticZoom_Gridview
{
    public sealed partial class Movies
    {
        public Movies()
        {
            this.InitializeComponent();

            var viewModel = new MoviesPageViewModel();
            this.DataContext = viewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var collectionGroups = groupedItemsViewSource.View.CollectionGroups;
            ((ListViewBase)this.Zoom.ZoomedOutView).ItemsSource = collectionGroups;
        }
    }
}
