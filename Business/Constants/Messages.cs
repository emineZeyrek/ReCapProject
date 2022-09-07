using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages // static verdiğimizde new' lemeyiz
    {
        // Car
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarListed = "Arabalar listelendi";

        //Brand
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncelendi";
        public static string BrandListed = "Markalar Listelendi";


        //Color
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renkler Listelendi";


        public static string MaintenanceTime = "Sistem bakımda";

        //Customer
        public static string CustomersAdded = "Müşteri eklendi";
        public static string CustomersDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomersUpdated = "Müşteri güncellendi";

        //User
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";

        //Rental
        public static string RentalAdded = "Araç Kiralama İşlemi Kaydedildi";
        public static string RentalDeleted = "Araç Kiralama İşlemi Silindi";
        public static string RentalUpdated = "Araç Kiralama İşlemi Güncellendi";
        public static string RentalListed = "Araç kiralama İşlemleri Listelendi";
            


    }

}
