using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFolha.View;
using ProjectFolha.View.MenuItems;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFolha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Master : ContentPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public Master()
        {
            InitializeComponent();

            menuList = new List<MasterPageItem>();

            var Page1 = new MasterPageItem() { Title = "Home", Icon = "home", TargetType = typeof(A) };
            var Page2 = new MasterPageItem() { Title = "Ficha do Funcionário", Icon = "ficha", TargetType = typeof(B) };
            var Page3 = new MasterPageItem() { Title = "Comprovante de Rendimento", Icon = "comprovante", TargetType = typeof(B) };
            var Page4 = new MasterPageItem() { Title = "Recibo de Pagamento", Icon = "recibo",TargetType = typeof(B) };

            menuList.Add(Page1);
            menuList.Add(Page2);
            menuList.Add(Page3);
            menuList.Add(Page4);

            navigationDrawerList.ItemsSource = menuList;

            //ButtonA.Clicked += async (sender, e) =>
            //{
            //    await App.NavigateMasterDetail(new A());
            //};

            //ButtonB.Clicked += async (sender, e) =>
            //{
            //    await App.NavigateMasterDetail(new B());
            //};

            //navigationDrawerList.ItemSelected += async (sender, e) =>
            //{
            //    var item = (MasterPageItem)e.SelectedItem;
            //    Type page = item.TargetType;

            //    await App.NavigateMasterDetail( );
            //};
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            App.MasterDetail.Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            App.MasterDetail.IsPresented = false;
            
            //Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            //IsPresented = false;
        }
    }
}
