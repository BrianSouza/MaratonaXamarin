using System;

using UIKit;

namespace Modulo3Licao1
{
    public partial class ViewController : UIViewController
    {

        double conta = 0;
        double banco = 0;
        double contaAPagar = 0;
        double pagoACredito = 0;
        double pagoFornecedores = 0;
        double renda = 0;
        double capital = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnCalcular.TouchUpInside += BtnCalcular_TouchUpInside;
        }

        private void BtnCalcular_TouchUpInside(object sender, EventArgs e)
        {
            try
            {
                conta = double.Parse(txtConta.Text);
                banco = double.Parse(txtBanco.Text);
                contaAPagar = double.Parse(txtValor.Text);
                pagoACredito = double.Parse(txtPgCredito.Text);
                pagoFornecedores = double.Parse(txtPgCredito.Text);
                renda = double.Parse(txtRenda.Text);

                capital = (conta + banco + contaAPagar) - (pagoACredito + pagoFornecedores + renda);

                txtCC.Text = capital.ToString();
            }
            catch (Exception ex)
            {
                MessageBox("Erro", ex.Message);
            }
            
        }

        private void MessageBox(string v, string message)
        {
            using (UIAlertView alerta = new UIAlertView())
            {
                alerta.Title = v;
                alerta.Message = message;
                alerta.AddButton("Aceitar");
                alerta.Show();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}