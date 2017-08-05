using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Posse
{
    public partial class MemberPage : ContentPage
    {
        public MemberPage()
        {
            InitializeComponent();
        }

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var member = (Member)BindingContext;
			await App.Database.SaveItemAsync(member);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var member = (Member)BindingContext;
			await App.Database.DeleteItemAsync(member);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
    }
}
