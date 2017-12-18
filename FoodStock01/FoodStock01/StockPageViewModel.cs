using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FoodStock01
{
    class StockPageViewModel
    {
        public ObservableCollection<Stock> Stocks
        {
            get;
            private set;
        }

        public StockPageViewModel()
        {
            if (StockFoodModel.SelectStock() != null)
            {
                var query = StockFoodModel.SelectStock();

                Stocks = new ObservableCollection<Stock>();

                foreach (var stock in query)
                {
                    Stock s = new Stock
                    {
                        S_no = stock.S_no,//試し
                        S_name = stock.S_name,
                        S_num = stock.S_num,
                        S_unit = stock.S_unit
                    };
                    Stocks.Add(s);//
                }
            }
            else
            {
                Stocks = new ObservableCollection<Stock>
                {
                    new Stock
                    {
                        S_name = "NoData",
                        S_num = 0,
                        S_unit = "個"
                    }
                };
            }            
        }
    }

    public class Stock
    {
        public int S_no { get; set; }//試し
        public string S_name{ get; set; }
        public int S_num { get; set; }
        public string S_unit { get; set; }
    }
}
