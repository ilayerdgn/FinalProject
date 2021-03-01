using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride 10'dan fazla ürün olamaz.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string AuthorizationDenied = "Yetkiniz yok";
    }
}
