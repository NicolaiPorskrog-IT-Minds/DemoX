using DemoX;
using DemoX.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(RoundCornerEntry), typeof(RoundCornerEntryRenderer))]
namespace DemoX.Droid
{
    class RoundCornerEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.RoundCornerEntry);
                Control.SetTextColor(Color.Black);
            }
        } 
    }
}