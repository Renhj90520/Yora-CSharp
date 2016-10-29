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
using Android.Support.V7.App;
using Yora.Infrastructure;

namespace Yora.Activities
{
    public abstract class BaseActivity : AppCompatActivity
    {
        protected YoraApplication application;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            application = (YoraApplication)Application;
        }
    }
}