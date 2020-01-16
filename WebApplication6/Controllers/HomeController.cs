using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using System.Dynamic;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        WMSEntities1 db = new WMSEntities1();
        public ActionResult Index()
        {
            List<Request> requests = db.Requests.ToList();
            return View(requests);
        }

        public ActionResult Edit()
        {
            List<Release> releases = db.Releases.ToList();
           
            return View(releases);
        }
        [HttpPost]
        public ActionResult Edit(String IsChecked)
        {
           
            
                try
                {
                    List<Release> releases = db.Releases.ToList();
                    Release release = new Release();

                    ass a = new ass();
                    a.Emp_Id = release.Emp_Id;
                    db.asses.Add(a);
                    db.SaveChanges();
                    // Employee employee = new Employee();

                    return View(releases);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            
        }

         
       

        
                
            }
        }
    
