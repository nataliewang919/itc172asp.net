using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


public class CommunityService : ICommunityService
{
    Community_AssistEntities db=new Community_AssistEntities();

    public List<GrantRequestInfo> GetRequestGrantAmount()
    {
        throw new NotImplementedException();
    }

    public int Login(string user, string password)
    {
        
        int key = 0;
        int result = db.usp_Login(user, password);
        if (result != -1)
        {
            var userKey = (from k in db.People
                           where k.PersonEmail.Equals(user)
                           select k.PersonKey).FirstOrDefault();
            key = (int)userKey;
        }
        return result;
    }

    public bool RegisterUser(string lastname, string firstname, string email, string password, string Apartment, string Street, string City, string State, string Zipcode, string HomePhone, string WorkPhone)
    {
        bool result = true;
        int rev = db.usp_Register(lastname, firstname, email, password, Apartment,
            Street, City, State, Zipcode, HomePhone, WorkPhone);

        return result;
    }

    
}
