﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacto : ContentPage
    {
        public Contacto()
        {
            InitializeComponent();

            fecha.Text = DateTime.Now.ToString("d");
        }
    }
}