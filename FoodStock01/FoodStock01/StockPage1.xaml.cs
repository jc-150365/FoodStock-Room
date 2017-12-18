using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StockPage1 : ContentPage
	{
		public StockPage1 (string title)
		{
            //タブに表示される文字列
            Title = title;

            InitializeComponent ();
		}

        //更新ボタンが押された時
        private void Update_Button_Clicked(object sender, EventArgs e)
        {
            Title = "保存";

            InitializeComponent();

        }

        //プラスがクリックされた
        void OnPlus_Clicked(object sender, EventArgs args)
        {
           int num = Convert.ToInt32(((CustomButton)sender).CountText) + 1;
           string name = ((CustomButton)sender).NameText;
           //DisplayAlert("1足しました", name+"　"+num.ToString(), "ok");
      
            /***ここから試し02***/
           List<StockFoodModel> n = StockFoodModel.SelectStock02(name,num-1);

            StockFoodModel.UpdateStockPlus02(n);

            Title = "保存";

            InitializeComponent();
            /***ここまで試し02***/

            /***ここから試し***/
            /*
            StockFoodModel.UpdateStockPlus();

            Title = "保存";
            
            InitializeComponent();
            */
            /***ここまで試し***/
        }

        //マイナスがクリックされた
        void OnMinus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((CustomButtonMinus)sender).CountText) - 1;
            string name = ((CustomButtonMinus)sender).NameText;
            DisplayAlert("1引きました", name+"　"+num.ToString(), "ok");
        }
    }
}