using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidRatingBar
{
    [Activity(Label = "AndroidRatingBar", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var ratingBar = FindViewById<RatingBar>(Resource.Id.ratingBar1);
            var btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
            var txtRate = FindViewById<TextView>(Resource.Id.txtRate);

            txtRate.Text = "Rate: ";

            btnSubmit.Click += (s, e) =>
            {
                string ratingValue = ratingBar.Rating.ToString();
                txtRate.Text = "Rate: " + ratingValue;
            };
        }
    }
}

