using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFolha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();

            ButtonA.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new A());
            };

            ButtonB.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new B());
            };
        }
    }
}
