using ECommerce.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ECommerce
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            getCategoryList();
            getCaarouselViewList();
            getProductList();
        }

        void getCaarouselViewList()
        {
            ObservableCollection<CarouselItemListClass> CarouselItem = new ObservableCollection<CarouselItemListClass>();
            CarouselItem.Add(new CarouselItemListClass { Id = "1", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYtJjlpBLV1_HvdRTKwqmiWC7r7OCU_SyFBQ&usqp=CAU" });
            CarouselItem.Add(new CarouselItemListClass { Id = "2", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNgeHA0SK41ZMn3S_xdxmhf144t3NH1ZvGfA&usqp=CAU" });
            CarouselViews.ItemsSource = CarouselItem;
        }

        void getCategoryList()
        {
            ObservableCollection<CategoryListClass> Categories = new ObservableCollection<CategoryListClass>();
            Categories.Add(new CategoryListClass { Id = "1",CategoryName= "Vegetable",Image= "https://cdn0.iconfinder.com/data/icons/fruit-and-vegetable-15/200/broccoli_green_fruit_vegetable-48.png"});
            Categories.Add(new CategoryListClass { Id = "2",CategoryName= "Fruit",Image= "https://cdn0.iconfinder.com/data/icons/fruit-and-vegetable-15/200/purple_grave_fruit_vegetable-48.png"});

            for (int a =0; a< Categories.Count; a++)
            {
                Button btn = new Button();
                btn.Text = Categories[a].CategoryName;
                btn.ImageSource = Categories[a].Image;
                btn.AutomationId = Categories[a].Id;
                btn.TextTransform = TextTransform.None;
                btn.CornerRadius = 10;
                btn.Padding = new Thickness(5,0,5,0);
                btn.BackgroundColor = Color.Transparent;
                btn.TextColor = Color.White;
                btn.BorderColor = Color.White;
                btn.BorderWidth = 1;
                btn.HeightRequest = 40;
                btn.MinimumHeightRequest = 40;
                CategoryLayout.Children.Add(btn);
            }
        }

        void getProductList()
        {
            ObservableCollection<ProductListClass> Products = new ObservableCollection<ProductListClass>();
            Products.Add(new ProductListClass { CategoryId = "1", ProductName = "Tomato", Price = "10,00", Image = "https://cdn0.iconfinder.com/data/icons/fruits/128/Tomato.png" });
            Products.Add(new ProductListClass { CategoryId = "1", ProductName = "Peach", Price = "10,00", Image = "https://cdn0.iconfinder.com/data/icons/fruits/128/Peach.png" });
            Products.Add(new ProductListClass { CategoryId = "1", ProductName = "Banana", Price = "10,00", Image = "https://cdn0.iconfinder.com/data/icons/fruits/128/Banana.png" });
            Products.Add(new ProductListClass { CategoryId = "1", ProductName = "Strawberry", Price = "10,00", Image = "https://cdn0.iconfinder.com/data/icons/fruits/128/Strawberry.png" });
            Products.Add(new ProductListClass { CategoryId = "1", ProductName = "Lemon", Price = "10,00", Image = "https://cdn0.iconfinder.com/data/icons/fruits/128/Lemon.png" });

            for (int a = 0; a < Products.Count; a++)
            {
                StackLayout stk = new StackLayout();
                stk.Orientation = StackOrientation.Horizontal;
                Button addtocard = new Button();
                addtocard.Text = "Add To Card";
                addtocard.TextTransform = TextTransform.None;
                addtocard.FontSize = 10;
                addtocard.CornerRadius = 10;
                addtocard.Padding = new Thickness(0, 0, 5, 0);
                addtocard.BackgroundColor = Color.Transparent;
                addtocard.TextColor = Color.White;
                addtocard.BorderColor = Color.White;
                addtocard.BorderWidth = 1;
                addtocard.WidthRequest = 60;
                addtocard.MinimumWidthRequest = 60;

                Button btn = new Button();
                btn.Text = Products[a].ProductName+"\n"+ Products[a].Price+" ₺";
                btn.AutomationId = Products[a].CategoryId;
                btn.ImageSource = Products[a].Image;
                btn.TextTransform = TextTransform.None;
                btn.FontSize = 20;
                btn.CornerRadius = 10;
                btn.Padding = new Thickness(20, 0, 5, 0);
                btn.HorizontalOptions = LayoutOptions.FillAndExpand;
                btn.BackgroundColor = Color.Transparent;
                btn.TextColor = Color.White;
                btn.BorderColor = Color.White;
                btn.BorderWidth = 1;
                btn.HeightRequest = 100;
                btn.MinimumHeightRequest = 100;
                stk.Children.Add(btn);
                stk.Children.Add(addtocard);
                ProductLayout.Children.Add(stk);
            }
        }
    }
}
