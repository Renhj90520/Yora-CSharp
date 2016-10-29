using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Yora.Infrastructure
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string AvatarUrl { get; set; }
        public bool IsLoggedin { get; set; }
        public bool HasPassword { get; set; }
        public string Email { get; set; }
    }
}