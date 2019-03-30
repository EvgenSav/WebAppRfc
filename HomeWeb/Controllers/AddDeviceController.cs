﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Driver.Mtrf64;
using Microsoft.AspNetCore.Mvc;
using Home.Web.Extensions;
using Home.Web.Models;
using Home.Web.Services;

namespace Home.Web.Controllers
{
    public class AddDeviceController : Controller
    {
        private readonly Mtrf64Context mtrf64Context;
        private readonly BindingService bindingService;
        public static DevicesService devService { get; set; }
        public AddDeviceController(Mtrf64Context mtrf64Context, BindingService bindingService)
        {
            this.mtrf64Context = mtrf64Context;
            this.bindingService = bindingService;
        }

        public IActionResult RoomSelected([FromBody] NewDevModel newDev)
        {
            if (newDev != null && newDev.Name != "")
            {
                bindingService.RoomSelected(newDev);
            }
            return Ok(new { Channel = bindingService.FindedChannel, Status = bindingService.Status });
        }

        public IActionResult SendBind()
        {
            bindingService.SendBind();
            return Ok(new { Status = bindingService.Status });
        }

        public IActionResult Add()
        {
            bindingService.SendAdd();
            return Ok(new { Device = bindingService.Device, Status = bindingService.Status });
        }

        public OkResult CheckBind([FromBody] Device dev)
        {
            dev.SetSwitch(mtrf64Context);
            return new OkResult();
        }
        public OkResult CancelBind()
        {
            return new OkResult();
        }
    }
}