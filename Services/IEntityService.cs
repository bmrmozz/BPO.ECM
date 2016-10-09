using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

public namespace BPO.ECM.Services
{
    public interface IEntityService
    {
        object GetEntityDefinition(string entityID);

        object GetEntityStub(string entityID);

        object GetEntityObject(string entityID, string objectID);
    }

    public class EntityService : IEntityService {

        public EntityService ()
        {
          
        }

        public object GetEntityDefinition(string entityID){
            return null;
        }

        public object GetEntityStub(string entityID)
        {
            return null;
        }

        public object GetEntityObject(string entityID, string objectID)
        {
            return null;
        }

    }
}