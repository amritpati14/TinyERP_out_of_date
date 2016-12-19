﻿namespace App.Service.Security.UserGroup
{
    using App.Common.Data;
    using App.Common.Mapping;
    using System;
    using System.Collections.Generic;

    public class GetUserGroupResponse : BaseContent, IMappedFrom<App.Entity.Security.UserGroup>
    {
        public IList<Guid> Permissions { get; set; }
        public GetUserGroupResponse() : base()
        {
            this.Permissions = new List<Guid>();
        }
    }
}
