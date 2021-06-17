# XF_NavBarBackBtnOverride
Navigation Bar Back Button Override using separate Back button custom actions class

When I wanted to catch the Back Button of the Navigation Bar in a Xamarin.Forms page the following was suggested in the forums.xamarin.com in my thread [How to Catc the Back Button of a Navigation Bar](https://forums.xamarin.com/discussion/186165/how-to-catch-the-back-button-of-a-navigation-bar-not-the-physical-back-button-like-on-android#latest):

[Override Nav Bar Back Button Click](https://theconfuzedsourcecode.wordpress.com/2017/03/12/lets-override-navigation-bar-back-button-click-in-xamarin-forms/comment-page-1/#comment-1167)

This Xamarin.Forms solution implements this. This is implemented here only for normal Xamarin.Forms.ContentPage. When I tried to implement it for a TabbedPage, it didn't work for Android. Later I could implement it for a TabbedPage using NavigationPage.TitelView as demonstrated in my GitHub repo - [XF_NavBarBkBtnOver](https://github.com/shantimohan/XF_NavBarBkBtnOver/tree/master).
