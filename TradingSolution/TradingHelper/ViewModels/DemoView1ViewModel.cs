﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TradingHelper.ViewModels
{
    public class DemoView1ViewModel : BindableBase
    {
        private string info = "Hello from View1";
        public string Info
        {
            get { return info; }
            set { SetProperty(ref info, value); }
        }

        public DemoView1ViewModel()
        {

        }
    }
}
