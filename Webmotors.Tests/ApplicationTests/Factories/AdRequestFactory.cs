using Webmotors.Application.Requests;
using Webmotors.Domain.Interfaces.Requests;

namespace Webmotors.Tests.ApplicationTests.Factories
{
    public class AdRequestFactory
    {
        public IAdRequest GetAdRequest(bool valid = true)
        {
            return valid ? ValidRequest : InvalidRequest;
        }

        private AdRequest ValidRequest 
        {
            get
            {
                var request = new AdRequest();
                request.Make = "VOLKSWAGEN";
                request.Model = "FUSCA";
                request.Version = "1.3 8V GASOLINA 2P MANUAL";
                request.Year = 1981;
                request.Mileage = 150000;
                request.Note = "fusca muito bonito";

                return request;
            }
        }

        private AdRequest InvalidRequest
        {
            get
            {
                var request = new AdRequest();
                request.Make = "MARCA MUITO LONGA QUE NÃO VAI CABER NO LIMITE DE QUARENTA E CINCO CARACTERES PROPOSTO NESTE DESAFIO";
                request.Model = "";
                request.Version = null;
                //Ano, Km e Obs omitidos

                return request;
            }
        }
    }
}
