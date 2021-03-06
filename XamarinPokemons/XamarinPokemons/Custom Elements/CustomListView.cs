﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinPokemons.Custom_Elements
{
    class CustomListView : ListView
    {
        public static BindableProperty ItemClickCommandProperty = BindableProperty.Create<CustomListView, ICommand>(x => x.ItemClickCommand, null);
        public CustomListView()
        {
            this.ItemTapped += this.OnItemTapped;
        }

        public ICommand ItemClickCommand
        {
            get { return (ICommand)this.GetValue(ItemClickCommandProperty); }
            set { this.SetValue(ItemClickCommandProperty, value); }
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null && this.ItemClickCommand != null && this.ItemClickCommand.CanExecute(e))
            {
                this.ItemClickCommand.Execute(e.Item);
                this.SelectedItem = null;
            }
        }
    }
}
