using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Modulo2Licao1
{
    [Activity(Label = "Modulo2Licao1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnConverter = null;
        EditText txtEM = null;
        EditText txtSM = null;
        EditText txtEC = null;
        EditText txtSC = null;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.Main);
            btnConverter = this.FindViewById<Button>(Resource.Id.btnConverter);
            txtEM = this.FindViewById<EditText>(Resource.Id.txtEMexico);
            txtSM = this.FindViewById<EditText>(Resource.Id.txtSMexico);
            txtEC = this.FindViewById<EditText>(Resource.Id.txtEColombia);
            txtSC = this.FindViewById<EditText>(Resource.Id.txtSColombia);

            btnConverter.Click += BtnConverter_Click;
        }

        private void BtnConverter_Click(object sender, System.EventArgs e)
        {
            try
            {
                double em = double.Parse(txtEM.Text);
                double sm = double.Parse(txtSM.Text);
                double ec = double.Parse(txtEC.Text);
                double sc = double.Parse(txtSC.Text);

                double mexico = em - sm;
                double colombia = ec - sc;
                Carregar(mexico,colombia);
            }
            catch (System.Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short);
            }
        }

        private void Carregar(double mexico,double colombia)
        {
            Intent objIntent = new Intent(this, typeof(Page2Activity));
            objIntent.PutExtra("txtMexico", mexico);
            objIntent.PutExtra("txtColombia", colombia);
            StartActivity(objIntent);

        }
    }
}

