using Microsoft.WindowsAzure.MobileServices;
using AppFinalXamarin.Entidades;
using System.Threading.Tasks;

namespace AppFinalXamarin.Azure
{
    public class SalvarDadosAzure
    {
        Clientes _Cliente = null;
        public static MobileServiceClient MobileService;
        public SalvarDadosAzure(Clientes cliente)
        {
            _Cliente = cliente;
            MobileService = new MobileServiceClient("https://demoxamarinbds.azurewebsites.net");
        }

        public async void SalvarClienteNoAzure()
        {
            try
            {
                CurrentPlatform.Init();
                await MobileService.GetTable<Clientes>().InsertAsync(_Cliente);
            }
            catch (System.Exception ex)
            {
                throw;
            }
            

        }
    }
}