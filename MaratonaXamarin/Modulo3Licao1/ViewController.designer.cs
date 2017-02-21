// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Modulo3Licao1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCalcular { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBanco { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCC { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtConta { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPgCredito { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPGForn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtRenda { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtValor { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCalcular != null) {
                btnCalcular.Dispose ();
                btnCalcular = null;
            }

            if (txtBanco != null) {
                txtBanco.Dispose ();
                txtBanco = null;
            }

            if (txtCC != null) {
                txtCC.Dispose ();
                txtCC = null;
            }

            if (txtConta != null) {
                txtConta.Dispose ();
                txtConta = null;
            }

            if (txtPgCredito != null) {
                txtPgCredito.Dispose ();
                txtPgCredito = null;
            }

            if (txtPGForn != null) {
                txtPGForn.Dispose ();
                txtPGForn = null;
            }

            if (txtRenda != null) {
                txtRenda.Dispose ();
                txtRenda = null;
            }

            if (txtValor != null) {
                txtValor.Dispose ();
                txtValor = null;
            }
        }
    }
}