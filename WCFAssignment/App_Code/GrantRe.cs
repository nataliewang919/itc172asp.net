using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GrantRe" in code, svc and config file together.
public class GrantRe : IGrantRe
{
    Community_AssistEntities db = new Community_AssistEntities();

    public List<GrantRequestInfo> GetRequestGrantAmount(int Key)
    {
        var grant = from g in db.GrantRequests
                    from r in g.GrantReviews
                    where g.PersonKey == Key
                    select new { g.PersonKey, g.GrantRequestDate, g.GrantRequestAmount, g.GrantRequestExplanation,g.GrantTypeKey,
                        r.GrantRequestStatus };

        List<GrantRequestInfo> GRequest = new List<GrantRequestInfo>();

        foreach(var gr in grant)
        {
            GrantRequestInfo gr1 = new GrantRequestInfo();
            gr1.GrantRequestDate = gr.GrantRequestDate.ToShortDateString();
            gr1.GrantRequestExplanation = gr.GrantRequestExplanation;
            gr1.GrantRequestAmount = gr.GrantRequestAmount.ToString();
            gr1.GrantTypeKey = (int)gr.GrantTypeKey;
            gr1.PersonKey = (int)gr.PersonKey;

            gr1.GrantRequestStatus = gr.GrantRequestStatus;
            GRequest.Add(gr1);
            
        }
        return GRequest;
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

    public bool newGrant(GrantRequest r)
    {
        bool result = true;
        try { 
        db.GrantRequests.Add(r);
        db.SaveChanges();
        }catch {
            result = false;
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
