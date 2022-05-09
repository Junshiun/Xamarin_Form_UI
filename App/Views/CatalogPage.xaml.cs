using App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace App.Views
{
    public partial class CatalogPage : ContentPage
    {
        public CatalogPage()
        {
            InitializeComponent();

        }

        public void ItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ItemModel previous = e.PreviousSelection.FirstOrDefault() as ItemModel;
            ItemModel current = e.CurrentSelection.FirstOrDefault() as ItemModel;

            current.Visible = true;
            current.RowHeight = 45;
            current.TextColor1 = Color.White;
            current.TextColor2 = Color.White;

            if (previous != null)
            {
                //Reset the previous to defaulr color
                previous.Visible = false;
                previous.RowHeight = 0;
                previous.TextColor1 = Color.Black;
                previous.TextColor2 = Color.FromHex("#e76f3a");
            }

        }
    }
}