using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.Models
{
    public class ItemModel : INotifyPropertyChanged
    {
        int amount;
        bool visible;
        Color textColor1;
        Color textColor2;

        public event PropertyChangedEventHandler PropertyChanged;
        public string ItemText { get; set; }
        public double Price { get; set; }
        public int Min { get; set; }

        public Uri ProductImage { get; set; }

        public ItemModel(string ItemText, double Price, int Amount, int Min, Uri ProductImage, bool Visible, Color TextColor1, Color TextColor2)
        {
            this.ItemText = ItemText;
            this.Price = Price;
            this.Amount = Amount;
            this.Min = Min;
            this.ProductImage = ProductImage;
            this.Visible = Visible;
            this.TextColor1 = TextColor1;
            this.TextColor2 = TextColor2;
        }

        public int Amount
        {
            set
            {
                if (amount != value)
                {
                    amount = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Amount"));
                    }
                }
            }
            get
            {
                return amount;
            }
        }

        public bool Visible
        {
            set
            {
                if (visible != value)
                {
                    visible = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
                    }
                }
            }
            get
            {
                return visible;
            }
        }

        public Color TextColor1
        {
            set
            {
                if (textColor1 != value)
                {
                    textColor1 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TextColor1"));
                    }
                }
            }
            get
            {
                return textColor1;
            }
        }

        public Color TextColor2
        {
            set
            {
                if (textColor2 != value)
                {
                    textColor2 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TextColor2"));
                    }
                }
            }
            get
            {
                return textColor2;
            }
        }
    }
}

