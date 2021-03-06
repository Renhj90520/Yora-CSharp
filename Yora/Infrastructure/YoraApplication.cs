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
    public class YoraApplication : Application
    {
        public Auth Auth { get; private set; }

        public override void OnCreate()
        {
            base.OnCreate();
            Auth = new Auth(this);
        }
    }
}