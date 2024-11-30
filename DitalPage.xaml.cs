using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp333.Mehanism;

namespace MauiApp333;

public partial class DitalPage : ContentPage
{
    public DitalPage(NextPage vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}