﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataStorage;
using Home.Web.Domain.Automation.Condition;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Home.Web.Domain.Automation;
using Home.Web.Domain.Automation.Result;
using Home.Web.Models;
using Home.Web.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Caching.Memory;
using MongoDB.Bson;

namespace Home.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomationController : ControllerBase
    {
        private readonly IAutomationService _automationService;
        public AutomationController(IAutomationService automationService)
        {
            _automationService = automationService;
        }
        [HttpGet]
        public async Task<IEnumerable<IAutomationItem>> Test()
        {
            //var condItem = new DeviceCmdCondition
            //{
            //    DeviceCmd = NooCmd.Switch,
            //    DeviceId = 3,
            //    Name = "1st cmd condition. A chn"
            //};
            //var cond = new Condition();
            //cond.AddConditionItem(condItem);
            //var resItem = new ResultItem { DeviceId = 34029, State = new DeviceState { Bright = 100, LoadState = LoadStateEnum.On } };
            //var res = new AutomationResult();
            //res.AddResultItem(resItem);
            //var aut = new AutomationItem {Condition = cond, Result = res};
            //await _store.AddAsync("automation", aut);
            var automations = await _automationService.GetAutomationItems();
            return automations;
        }
        [HttpGet("create")]
        public async Task<IAutomationItem> Create()
        {
            var condItem = new DeviceStateCondition()
            {
                Id = Guid.NewGuid(),
                DeviceId = 3,
                Name = "2nd cmd condition.",
                State = new DeviceState
                {
                    Bright = 80,
                    MeasuredData = new Dictionary<string, double> { { SensorDataTypeEnum.Humidity.ToString(), 50 } }
                }
            };
            var cond = new Condition();
            cond.AddConditionItem(condItem);
            var resItem = new ResultItem { DeviceId = 34029, State = new DeviceState { Bright = 100, LoadState = LoadStateEnum.On } };
            var res = new AutomationResult();
            res.AddResultItem(resItem);
            var aut = new AutomationItem { Condition = cond, Result = res };
            var automation = await _automationService.AddAutomation(aut);
            return automation;
        }
        [HttpPatch("{automationId}")]
        public async Task<IAutomationItem> Patch(string automationId, [FromBody] JsonPatchDocument<IAutomationItem> patch)
        {
            var item = await _automationService.GetAutomationItem(ObjectId.Parse(automationId));
            patch.ApplyTo(item);
            await _automationService.UpdateAutomationItem(item);
            return item;
        }
    }
}