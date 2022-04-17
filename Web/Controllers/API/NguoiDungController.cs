﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Web.Models;

namespace Web.Controllers.API
{
    public class NguoiDungController : ApiController
    {
        Movie12Entities db = new Movie12Entities();
        [HttpGet]
        public List<User> GetUser()
        {
            var u = db.Users.Where(n => n.Permission == false).ToList();
            var lstuser = new List<User>();
            foreach(var item in u)
            {
                lstuser.Add(new User()
                {
                    Email = item.Email,
                    FullName=item.FullName,
                    Password=item.Password
                });
                
            }
            return lstuser;
        }
        [HttpGet]
        public User GetUserById(String email)
        {
            var item = db.Users.SingleOrDefault(n => n.Permission == false && n.Email==email);
            var  user=new User()
                {
                    Email = item.Email,
                    FullName = item.FullName,
                    Password = item.Password
                };

            
            return user;
        }
        [HttpPost]
        public JsonResult<bool> insert(UserModel userModel)
        {
            var item = db.Users.SingleOrDefault(n => n.Email == userModel.email);
            if(item == null)
            {
                User u = new User() {Email=userModel.email,FullName=userModel.fullname,Password=userModel.password,Permission=false };
                db.Users.Add(u);
                db.SaveChanges();
                return Json(true);
            }
            return Json(false);
        }
        [HttpPut]
        public bool update(string email, string fullname, string pass)
        {
            var item = db.Users.SingleOrDefault(n => n.Email == email);
            if (item != null)
            {
                item.Email = email;
                item.FullName = fullname;
                item.Password = pass;                
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool delete(string email)
        {
            User item = db.Users.SingleOrDefault(n => n.Email == email);
            if (item != null)
            {
                List<MyList> ml = db.MyLists.Where(n => n.Email == email).ToList();
                if(ml.Count!=0) { 
                foreach(var s in ml)
                {
                        db.MyLists.Remove(s);
                }
                }
                db.Users.Remove(item);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
