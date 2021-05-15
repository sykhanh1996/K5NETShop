using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K5NETShop.BackendServer.API.Constants;
using Microsoft.AspNetCore.Mvc;

namespace K5NETShop.BackendServer.API.Authorization
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(FunctionCode functionId, CommandCode commandId)
            : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { functionId, commandId };
        }
    }
}
