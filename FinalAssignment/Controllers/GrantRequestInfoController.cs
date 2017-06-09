using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalAssignment.Models;

namespace FinalAssignment.Controllers
{
    
        public class GrantRequestInfoController : Controller
        {
            Community_AssistEntities db = new Community_AssistEntities();
            // GET: GrantRequestInfo
            public ActionResult Index()
            {
                var per = from g in db.GrantRequests
                          from r in db.GrantReviews
                          select new
                          {
                              g.GrantRequestDate,
                              g.GrantRequestExplanation,
                              g.GrantRequestAmount,
                              r.GrantReviewDate,
                              r.GrantRequestStatus,
                              r.GrantAllocationAmount
                          };
                List<GrantRequestInfo> gr = new List<GrantRequestInfo>();

                foreach (var pers in per)
                {
                    GrantRequestInfo gre = new GrantRequestInfo();
                    gre.GrantRequestDate = pers.GrantRequestDate.ToString();
                    gre.GrantRequestAmount = pers.GrantRequestAmount.ToString();
                    gre.GrantRequestExplanation = pers.GrantRequestExplanation;
                    gre.GrantRequestStatus = pers.GrantRequestStatus;
                    gre.GrantReviewDate = pers.GrantReviewDate.ToString();
                    gre.GrantAllocationAmount = pers.GrantAllocationAmount.ToString();
                    gr.Add(gre);
                }
                return View(gr);
            }
        }
    }