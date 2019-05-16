using CES.Database.Context;
using System.Net.Http;


namespace CES.Services
{
    /**
     * This class should be used for communicating external service only,
     * and the communication between Telstar with the 3rd party service can be achieved 
     * by HTTP request
     **/
    public class ShipProviderGatewayService : IShipProvider
	{
        // db context
        private CesContext _context;

        public ShipProviderGatewayService(CesContext context)
        {
            _context = context;
        }
    }
}
