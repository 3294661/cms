﻿using System;
using System.Collections.Generic;

namespace SiteServer.Abstractions
{
    [Serializable]
    public class PermissionsSettings
    {
        public IList<MenuPermission> App { get; set; }
        public IList<MenuPermission> Site { get; set; }
        public IList<MenuPermission> Channel { get; set; }
    }
}