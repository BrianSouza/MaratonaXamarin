
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using AppFinalXamarin.Azure;
using AppFinalXamarin.Entidades;

namespace AppFinalXamarin
{
    [Activity(Label = "AddClienteActivity")]
    public class AddClienteActivity : AppCompatActivity
    {
        Android.Widget.EditText txtRazao = null;
        Android.Widget.RadioButton rbTPCPF = null;
        Android.Widget.RadioButton rbTPCNPJ = null;

        Android.Widget.EditText txtDocumento = null;
        Android.Widget.EditText txtEndereco = null;
        Android.Widget.EditText txtNumero = null;
        Android.Widget.EditText txtBairro = null;
        Android.Widget.EditText txtCidade = null;
        Android.Widget.Spinner spEstado = null;
        Android.Widget.EditText txtCEP = null;
        Android.Widget.EditText txtTelefone = null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.AddCliente);
            var toolbar = this.FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbarAddClient);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            GetControles();

            var lista = new List<string> {"SP","RJ" };
            var adpt = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, lista);
            spEstado.Adapter = adpt;

        }

        private void GetControles()
        {
            try
            {
                txtBairro = FindViewById<Android.Widget.EditText>(Resource.Id.txtBairro);
                txtCEP = FindViewById<Android.Widget.EditText>(Resource.Id.txtCEP);
                txtCidade = FindViewById<Android.Widget.EditText>(Resource.Id.txtCidade);
                txtDocumento = FindViewById<Android.Widget.EditText>(Resource.Id.txtDocumento);
                txtEndereco = FindViewById<Android.Widget.EditText>(Resource.Id.txtEndereco);
                txtNumero = FindViewById<Android.Widget.EditText>(Resource.Id.txtNumero);
                txtRazao = FindViewById<Android.Widget.EditText>(Resource.Id.txtRazao);
                txtTelefone = FindViewById<Android.Widget.EditText>(Resource.Id.txtTelefone);
                spEstado = FindViewById<Android.Widget.Spinner>(Resource.Id.spEstado);
                rbTPCNPJ = FindViewById<Android.Widget.RadioButton>(Resource.Id.rbCNPJ);
                rbTPCPF = FindViewById<Android.Widget.RadioButton>(Resource.Id.rbCPF);
            }
            catch (System.Exception)
            {
                Android.Widget.Toast.MakeText(this, "Erro ao receber controles.", Android.Widget.ToastLength.Short).Show();
            }
            
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.addcliente_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if(item.ItemId == Resource.Id.menu_salvar)
            {
                Clientes cliente = new Clientes();
                GetInfo(cliente);
                SalvarDadosAzure salvarAzure = new SalvarDadosAzure(cliente);
                salvarAzure.SalvarClienteNoAzure();
            }

            return base.OnOptionsItemSelected(item);
        }

        private void GetInfo(Clientes cliente)
        {
            cliente.Bairro = txtBairro.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Documento = txtDocumento.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Estado = spEstado.SelectedItem.ToString();
            cliente.Numero = txtNumero.Text;
            cliente.Razao = txtRazao.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.TipoDocumento = rbTPCNPJ.Checked ? "CNPJ" : "CPF";
        }
    }
}