﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace UMSAgent.MyObject
{
    public class Pushid
    {
        private string product_key;
        private string client_id;
        private string device_id;

        public string appkey
        {
            get { return product_key; }
            set { product_key = value; }
        }

        public string clientid
        {
            get { return client_id; }
            set { client_id = value; }
        }

        public string deviceid
        {
            get { return device_id; }
            set { device_id = value; }
        }
    }
}
