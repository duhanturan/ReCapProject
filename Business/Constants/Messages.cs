﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi.";
        public static string CarNameInvalid = "Arabanın adı minimum 2 karakter olmalıdır.";

        public static string CarListed = "Arabalar Listelendi.";

        public static string BrandListed = "Markalar Listelendi.";

        public static string ColorListed = "Renkler Listelendi";

        public static string CustomerListed = "Müşteriler Listelendi.";

        public static string BrandListedById = "Markalar Id lere gore Listelendi.";

        public static string BrandDetailsListed = "Markaların Detayları Listelendi.";

        public static string BrandAdded = "Marka Eklendi";

        public static string BrandDeleted = "Marka Silindi";

        public static string BrandUpdated = "Marka Güncellendi.";

        public static string CarListedById = "Arabalar Id lere gore Listelendi";

        public static string CarDetailsListed = "Arabaların Detayları Listelendi";

        public static string CarUpdated = "Araba Güncellendi";

        public static string CarDeleted = "Araba Silindi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListedById = "Renkler Id lere Gore Listelendi";
        public static string ColorDetailsListed = "Renklerin Detayları Listelendi";
        public static string ColorUpdated = "Renk Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerListedById = "Müşteriler ID lere gore Listelendi";
        public static string CustomerDetailsListed = "Müşterilerin Detayları Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string UserAdded = "Kullanıcı Eklendi";

        public static string UserDeleted = "Kullanıcı Silindi";

        public static string UserListed = "Kullanıcılar Listelendi";

        public static string UserListedById = "Kullanıcılar Id lere gore Listelendi";

        public static string UserDetailsListed = "Kullanıcı Detayları Listelendi";

        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string RentalNotAdded = "Araba kiralamak için arabayı teslim etmeniz gerekmektedir";

        public static string RentalAdded = "Araba başarıyla kiralandı";

        public static string CarImageAdded = "Araba resmi yüklendi.";

        public static string CarImageDeleted = "Araba resmi silindi";

        public static string CarImageUpdated = "Resim güncellendi";

        public static string CarImageLimit = "En fazla 5 resim ekleyebilirsiniz.";

        public static string AuthorizationDenied = "yetkiniz yok";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Şifre hatalı";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";

        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
