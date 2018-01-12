﻿using Aurora.Shared.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Aurora.Music.ViewModels
{
    public class CategoryListItem : ViewModelBase
    {
        public string Title { get; set; }

        private bool isCurrent;
        public bool IsCurrent
        {
            get { return isCurrent; }
            set { SetProperty(ref isCurrent, value); }
        }

        public Type NavigatType { get; set; }

        public double GetHeight(bool b)
        {
            return b ? 250d : 150d;
        }

        public double GetVerticalShift(bool b)
        {
            return b ? 0d : -250d;
        }
        public IList<ImageSource> HeroImages { get; set; }
    }
}
