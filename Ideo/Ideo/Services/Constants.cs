using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Ideo.Services
{
   public class Constants
    {
        //public static string RestUrl = DeviceInfo.Platform == DevicePlatform.Android ? "https://10.0.2.2:5000/api/" : "https://localhost:5001/api/";
        public static string RestUrl = DeviceInfo.Platform == DevicePlatform.Android ? "https://192.168.1.19:44360/" : "http://localhost:5001/api/";
    }
}
