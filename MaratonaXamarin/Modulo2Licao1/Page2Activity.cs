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

namespace Modulo2Licao1
{
    [Activity(Label = "Page2Activity")]
    public class Page2Activity : Activity
    {
        private EditText txtMexico = null;
        private EditText txtColombia = null;
        private ImageView imgMexico = null;
        private ImageView imgColombia = null;
        double defaultValue = 0;
        Button btnSair = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.Page2);
            txtMexico = this.FindViewById<EditText>(Resource.Id.txtMexico);
            txtColombia = this.FindViewById<EditText>(Resource.Id.txtColombia);
            //imgColombia = this.FindViewById<ImageView>(Resource.Id.imgCol);
            //imgMexico = this.FindViewById<ImageView>(Resource.Id.imgMex);
            btnSair = this.FindViewById<Button>(Resource.Id.btnSair);
            btnSair.Click += BtnSair_Click;
            try
            {

                txtMexico.Text = Intent.GetDoubleExtra("txtMexico", defaultValue).ToString();
                txtColombia.Text = Intent.GetDoubleExtra("txtColombia", defaultValue).ToString();
            }
            catch (Exception e)
            {
                Toast.MakeText(this, e.Message, ToastLength.Short).Show();
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}