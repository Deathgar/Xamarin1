﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinPokemons.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(Entry), typeof(SquadEntryRenderer))]
namespace XamarinPokemons.Droid.CustomRenderers
{
    class SquadEntryRenderer : EntryRenderer
    {
        public SquadEntryRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (Entry)Element;

                var rect = new GradientDrawable();

                rect.SetShape(ShapeType.Rectangle);
                rect.SetColor(view.BackgroundColor.ToAndroid());
                rect.SetStroke(1, global::Android.Graphics.Color.Black);
                rect.SetCornerRadius(25f);
                rect.SetSize(200, 10);

                // rect.SetSize(Convert.ToInt32(view.WidthRequest), Convert.ToInt32(view.HeightRequest));
                Control.SetBackground(rect);
                Control.SetPadding(20, 5, 20, 0);
                Control.SetHeight(60);
            }
        }
    }
}