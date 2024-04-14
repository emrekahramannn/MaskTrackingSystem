using Business.Abstract;
using Entities.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        // This method (service) checks if the person is a real person or not using MERNIS Service
        public bool CheckIfRealPerson(IPerson person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(long.Parse(person.NationalityId), person.FirstName.ToUpper(), person.LastName.ToUpper(), person.BirthDate.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
