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
    public class Auth
    {
        public User User { get; }
        private readonly Context context;
        public Auth(Context context)
        {
            this.context = context;
            User = new User();
        }
    }
}