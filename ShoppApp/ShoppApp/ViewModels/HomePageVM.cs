using ShoppApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp.ViewModels
{
    class HomePageVM
    {

        public List<item> itemList { set; get; }
        public HomePageVM() {
            itemList = new List<item>();
            fillData();
        }

        private void fillData()
        {
            item fistItem = new item("organic juic", "this is a description", "20 SR", "juic.jpg", "5-15-2019", "011110101", "Test@organic.net", 21.4918284, 39.2419304);
            var secondItem = new item("Organic skin set ", " An Amazing Ogranic Oil you will love it, /n it's work like a shamp and get your skin moistening ", "350 SR", "alovera.jpg", "1-1-2019", "011110101", "Test@organic.net", 21.4918284, 39.2419304);
            item thirdItem = new item("organic juic", "this is a description", "20 SR", "juic.jpg", "5-15-2019", "011110101", "Test@organic.net", 21.4918284, 39.2419304);
            var item4 = new item("Organic oil ", " An Amazing Ogranic Oil you will love it, /n it's work like a shamp and get your skin moistening ", "100 SR", "oil.jpg", "1-1-2019", "011110101", "Test@organic.net", 21.4918284, 39.2419304);

            itemList.Add(fistItem);
            itemList.Add(secondItem);
            itemList.Add(thirdItem);
            itemList.Add(item4);

        }

    }
}
