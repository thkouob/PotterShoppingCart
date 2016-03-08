using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class CalculatedShoppingCart
    {
        decimal oneBookPrice = 100;

        private Dictionary<string, int> bookList = new Dictionary<string, int>();

        public decimal CalculateTotalPrice() 
        {
            decimal sum = 0;
            int[] booksCount = bookList.Values.OrderByDescending(x => x).ToArray();
            
            for (var bookSet = bookList.Count; bookSet >= 1; bookSet--)
            {
                int setCount = 0;
                if (bookSet == bookList.Count)//第一筆
                {
                    setCount = booksCount[bookSet - 1];
                }
                else
                {
                    setCount = booksCount[bookSet - 1] - booksCount[bookSet];
                }

                //價格+=折扣*單價*數量差*書的種類數
                sum += this.GetDisCount(bookSet) * setCount * bookSet * oneBookPrice;

            }
            return sum;
        }

        public void AddBook(string vol, int count) 
        {
            bookList.Add(vol, count);
        }

        private decimal GetDisCount(int bookSet) 
        {
            decimal discount = 0;
            switch (bookSet) 
            {
                case 2:
                    discount = 0.95m;
                    break;
                case 3:
                    discount = 0.9m;
                    break;
                case 4:
                    discount = 0.8m;
                    break;
                case 5:
                    discount = 0.75m;
                    break;
                default:
                    discount = 1;
                    break;
            }

            return discount;
        }
    }
}
