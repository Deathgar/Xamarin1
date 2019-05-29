using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Test3.Custom_Elements
{
    public class ValidTextNumbBehavior : Behavior<SquadEntry>
    {
        protected override void OnAttachedTo(SquadEntry bindable)
        {
            bindable.TextChanged += NumberValidation; 
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SquadEntry bindable)
        {
            base.OnDetachingFrom(bindable);
        }

        void NumberValidation(object sender, TextChangedEventArgs args)
        {
            int result;
            ((SquadEntry) sender).TextColor = int.TryParse(args.NewTextValue, out result) ? Color.Black : Color.Red;
        }
    }
}
