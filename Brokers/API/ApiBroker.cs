using RESTFulSense.Clients;

namespace CashOverFlow.Portal.Brokers.API
{
    public class ApiBroker : IApiBroker
    {
        private readonly IRESTFulApiFactoryClient apiClient;
        public ApiBroker(IRESTFulApiFactoryClient apiClient) =>
            this.apiClient = apiClient;
        
    }
}
