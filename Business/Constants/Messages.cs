using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba bilgileri eklendi";
        public static string CarUpdated = "Araba bilgileri güncellendi";
        public static string CarDeleted = "Araba bilgileri silindi";

        public static string CarInvalidName = "İsim geçersiz";
        public static string CarImageDeleted = "Resim silindi";
        public static string CarImageLimitExceeded = "Resim yükleme limiti dolu";
        public static string CarImageIsNotExists = "Resim alanı boş olamaz!";
        public static string CarImages = "Araba resimleri listelendi";
        public static string CarRental="Araç Kiralandı";
        public static string CarImageUpdated = "Resim güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserAdded = "Kullanıcı kayıt edildi.";
        public static string UserRegistered = "Kullanıcı Kayıtlı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";

        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
     
        public static string AccessTokenCreated = "Token oluşturuldu";
        
    }
}
