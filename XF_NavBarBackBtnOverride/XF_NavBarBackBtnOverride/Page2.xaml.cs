using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavBarBackBtnOverride
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : BackButtonCustomActionPage
    {
        public Page2()
        {
            InitializeComponent();

            if (EnableBackButtonOverride)
            {
                this.CustomBackButtonAction = async () =>
                {
                    // uncomment the following line to use SfPopupLayout
                    //popup.Show();

                    // comment the following two lines when using SfPopupLayout
                    var result = await this.DisplayAlert(null,
                        "Hey wait now! Are you sure you want to go back?",
                        "Yes go back", "Nope");

                    if (result)
                        await Navigation.PopAsync(true);
                };
            }
        }

        // Note: As suggested by @MilenMarinov in the comments of https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167
        //  for use in UWP
        //protected override bool OnBackButtonPressed()
        //{
        //    // uncomment the following line to use SfPopupLayout
        //    popup.Show();

        //    // comment the following line when using SfPopupLayout
        //    //Check2ClosePage();

        //    return true;
        //}

        private async void Check2ClosePage()
        {
            // Note: As suggested by @MilenMarinov in the comments of https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167
            if (await this.DisplayAlert(null,
                        "Hey wait now! Are you sure you want to go back?",
                        "Yes go back", "Nope"))
                await Navigation.PopAsync(true);
        }

        // uncomment the following 3 event handlers to use SfPopupLayout
        private async void Save_Clicked(object sender, EventArgs e)
        {
            //popup.Dismiss();
            await DisplayAlert("SAVE Operation", "Details saved successfully", "Continue...");
            await Navigation.PopAsync(true);
        }

        private async void GoBack_Clicked(object sender, EventArgs e)
        {
            //popup.Dismiss();
            await Navigation.PopAsync();
        }

        private void StayHere_Clicked(object sender, EventArgs e)
        {
            //popup.Dismiss();
        }
    }
}