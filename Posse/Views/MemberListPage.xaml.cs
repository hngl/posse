using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Posse
{
    public partial class MemberListPage : ContentPage
    {
        public MemberListPage()
        {
            InitializeComponent();
        }

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = await App.Database.GetItemsAsync();
		}

		async void OnItemAdded(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MemberPage
			{
				BindingContext = new Member()
			});
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			await Navigation.PushAsync(new MemberPage
			{
				BindingContext = e.SelectedItem as Member
			});
		}
    }
}
