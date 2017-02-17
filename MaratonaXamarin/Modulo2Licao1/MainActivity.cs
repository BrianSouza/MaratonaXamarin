using Android.App;
using Android.Widget;
using Android.OS;

namespace Modulo2Licao1
{
    [Activity(Label = "Modulo2Licao1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnConverter = null;
        EditText txtDolar = null;
        EditText txtPeso = null;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.Main);
            btnConverter = this.FindViewById<Button>(Resource.Id.btnConverter);
            txtDolar = this.FindViewById<EditText>(Resource.Id.txtDolares);
            txtPeso = this.FindViewById<EditText>(Resource.Id.txtPesos);

            btnConverter.Click += BtnConverter_Click;
        }

        private void BtnConverter_Click(object sender, System.EventArgs e)
        {
            try
            {
                double dolar = double.Parse(txtDolar.Text);
                double peso = dolar * 19.5;
                txtPeso.Text = peso.ToString();
            }
            catch (System.Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short);
            }
        }
    }
}

