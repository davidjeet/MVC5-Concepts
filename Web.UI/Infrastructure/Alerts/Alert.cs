﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.UI.Infrastructure.Alerts
{
    [Serializable]
    public class Alert
    {
        public string AlertClass { get; set; }
        public string Message { get; set; }

        public Alert(string alertClass, string message)
        {
            AlertClass = alertClass;
            Message = message;
        }
    }
}