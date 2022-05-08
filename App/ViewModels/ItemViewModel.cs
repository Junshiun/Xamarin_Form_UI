using App.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class ItemViewModel
    {
        public ObservableCollection<ItemModel> Items { get; set; }
        public ICommand RemoveCommand => new Command(RemoveItem);
        public ICommand AddCommand => new Command(ItemAmountAdd);
        public ICommand MinusCommand => new Command(ItemAmountMinus);
        public ItemViewModel()
        {
            Items = new ObservableCollection<ItemModel>();

            Items.Add(new ItemModel("Mesin Jahit Brother NV800E Computerised Embroidery Machine", 3800.00, 20, 20, new Uri("https://cdn.shopify.com/s/files/1/0415/7400/6938/products/NV800E_Front_01_1500_1024x1024.jpg?v=1592930221"), false, Color.Black, Color.Orange));
            Items.Add(new ItemModel("Mesin Jahit Brother Innovis A80 Computerised Sewing Machine", 850.00, 50, 50, new Uri("https://cf.shopee.com.my/file/29c8d40d321fd42b8383ec890dd33922"), false, Color.Black, Color.Orange));
            Items.Add(new ItemModel("Mesin Jahit Brother 2340CV Coverstitch Machine", 1080.00, 50, 50, new Uri("https://media.karousell.com/media/photos/products/2020/12/13/brother_2340cv_coverlocker_cov_1607858063_87891e4e_progressive"), false, Color.Black, Color.Orange));
            Items.Add(new ItemModel("Adjustable Zipper And Piping Foot (Standard)", 15.00, 100, 100, new Uri("https://www.sewmucheasier.com/assets/full/SME-706L.jpg?20211023211817"), false, Color.Black, Color.Orange));
            Items.Add(new ItemModel("5 Footer Set For Singer 14N655 Home Overlock Machine", 100.00, 50, 50, new Uri("https://ironingpresscompany.com/img/product/main_82_Overlocker-Feet-Set-cropped-enlarged-.jpg?crop=max&width=400&height=347"), false, Color.Black, Color.Orange));
        }

        void ItemAmountAdd(object o)
        {
            ItemModel Item = o as ItemModel;
            Item.Amount += 1;

            System.Diagnostics.Debug.WriteLine("add button clicked");
            System.Diagnostics.Debug.WriteLine(Item.Amount);
        }

        void ItemAmountMinus(object o)
        {
            ItemModel Item = o as ItemModel;

            if (Item.Amount > Item.Min)
                Item.Amount -= 1;

            System.Diagnostics.Debug.WriteLine("minus button clicked");
            System.Diagnostics.Debug.WriteLine(Item.Amount);
        }
        void RemoveItem(object o)
        {
            ItemModel ItemBeingRemoved = o as ItemModel;
            Items.Remove(ItemBeingRemoved);
            System.Diagnostics.Debug.WriteLine("item is delete here");
        }
    }
}

