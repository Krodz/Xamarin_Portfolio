using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Portfolio.Catalog;

namespace Portfolio
{
    public partial class CatalogPage : ContentPage
    {
        public CatalogPage()
        {
            InitializeComponent();
            BindingContext = new CatalogViewModel();
        }
    }
}
