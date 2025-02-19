﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Crimelife
{
    public class Configuration
    {
        public static readonly bool whitelist = false;
        private static readonly string host = "localhost";
        private static readonly string username = "root";
        private static readonly string database = "nexuscrimelife";

        #region SENSIBEL
        private static readonly string password = "";
        #endregion

        public static string connectionString = "Server=" + Configuration.host + "; Database=" + Configuration.database + "; UID=" + Configuration.username + "; PASSWORD=" + Configuration.password;
    }
}
