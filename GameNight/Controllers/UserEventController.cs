﻿using GameNight.Models;
using GameNight.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameNight.Controllers
{
    public class UserEventController : Controller
    {

        IRepository<UserEvent> userEventRepo;


        public UserEventController(IRepository<UserEvent> userEventRepo)
        {
            this.userEventRepo = userEventRepo;
        }

        public ViewResult Index()
        {
            return View(userEventRepo.GetAll());
        }
    }

}

