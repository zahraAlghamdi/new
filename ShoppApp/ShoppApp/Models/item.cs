using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp.Models
{
    public class item
    {
        public item()
        {
        }

        public item(string _title, string _description, string _price, string _image, string _date , string _phoneNumber , string _emailAdress , double lat , double lang )
        {
            title = _title;
            description = _description;
            price = _price;
            image = _image;
            date =_date;
            phoneNumber = _phoneNumber;
            emailAdress = _emailAdress;
            MapLang = lang;
            MapLat = lat;


        }

        public string title { set; get; }
        public string description { set; get; }
        public string price { set; get; }
        public string image { set; get; }
        public string date { set; get; }
        public string phoneNumber { set; get; }
        public string emailAdress { set; get; }
        public double MapLat { set; get; }
        public double MapLang { set; get; }

    }

}
