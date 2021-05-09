using GameMembershipDemo.Abstract;
using GameMembershipDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembershipDemo.Adapters
{
    class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(), user.LastName.ToUpper(),
                user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
