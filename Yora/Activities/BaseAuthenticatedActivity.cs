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

namespace Yora.Activities
{
    public abstract class BaseAuthenticatedActivity : BaseActivity
    {
        protected sealed override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (!application.Auth.User.IsLoggedin)
            {
                StartActivity(new Intent(this, typeof(LoginActivity)));
                Finish();
                return;
            }

            OnYoraCreate(savedInstanceState);
        }

        protected abstract void OnYoraCreate(Bundle savedInstanceState);
    }
}