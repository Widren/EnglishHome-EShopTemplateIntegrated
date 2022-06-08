using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    class PageLoginViewModel : PageBaseViewModel
    {
        private string _username;

        public string Username
        {
            set
            {
                this._username = value;
                OnPropertyChanged();
            }
            get { return this._username; }

        }

        private string _Ad;

        public string Ad
        {
            set
            {
                this._Ad = value;
                OnPropertyChanged();
            }
            get { return this._Ad; }

        }
        private string _Soyad;

        public string Soyad
        {
            set
            {
                this._Soyad = value;
                OnPropertyChanged();
            }
            get { return this._Soyad; }

        }
        private int _TelNo;

        public int TelNo
        {
            set
            {
                this._TelNo = value;
                OnPropertyChanged();
            }
            get { return this._TelNo; }

        }
        private string _Password;

        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
            get { return this._Password; }

        }
        private bool _IsBusy;

        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
            get { return this._IsBusy; }

        }
        private bool _Result;

        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get { return this._Result; }

        }

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        //public PageLoginViewModel()
        //{
        //    LoginCommand = new Command(async () => await LoginCommandAsync());
        //    RegisterCommand = new Command(async () => await RegisterCommandAsync());
        //}

        //private async Task RegisterCommandAsync()
        //{
        //    if (IsBusy)
        //        return;
        //    try
        //    {
        //        IsBusy = true;
        //        var userService = new UserService();
        //        Result = await userService.RegisterUser(Username, Password, Ad, Soyad, TelNo);
        //        if (Result)
        //        {
        //            await Application.Current.MainPage.DisplayAlert("Tebrikler", "Üyelik Kaydı Başarılı!", "Tamam");
        //            await Application.Current.MainPage.Navigation.PopAsync();

        //        }
        //        else
        //            await Application.Current.MainPage.DisplayAlert("Hata", "Bu e-mail adresiyle zaten bir üyelik mevcut!", "Tamam");

        //    }
        //    catch (Exception ex)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}

        //private async Task LoginCommandAsync()
        //{
        //    if (IsBusy)
        //        return;
        //    try
        //    {
        //        IsBusy = true;
        //        var userService = new UserService();
        //        Result = await userService.LoginUser(Username, Password);
        //        if (Result)
        //        {
        //            Preferences.Set("Username", Username);
        //            Shell.Current.GoToAsync("//PageMain");
        //        }
        //        else
        //        {
        //            await Application.Current.MainPage.DisplayAlert("Hata", "Kullanıcı adı veya şifre hatalı!", "OK");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}
    }
}
