using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AngularTest.Models.AODB;
using Microsoft.Extensions.Configuration;

namespace AngularTest.Controllers
{
    [Route("api/[controller]")]
    public class FeaturesController : Controller
    {
        private readonly AODBContext Context;
        public IConfiguration Configuration { get; }

        public FeaturesController(AODBContext context, IConfiguration configuration)
        {
            this.Context = context;
            this.Configuration = configuration;
        }

        [HttpGet("[action]")]
        public IEnumerable<FeatureModel> GetFeatures()
        {
            var features = Context.Feature.OrderBy(f => f.Name).Select(f => new FeatureModel
            {
                FeatureId = f.FeatureId,
                Name = f.Name,
                Active = f.Active
            }).ToList();

            return features;
        }

        [HttpGet("[action]")]
        public IEnumerable<FeatureClientModel> GetFeatureClients(int featureId)
        {
            var featureClients = (from f in Context.FeatureClient
                                  from c in Context.Client
                                  where c.ClientId == f.ClientId 
                                    && f.FeatureId == featureId
                                    && c.DeactivateDateTime == null
                                  select new FeatureClientModel
                                  {
                                      FeatureId = f.FeatureId,
                                      ClientId = f.ClientId,
                                      CompanyName = c.CompanyName,
                                      Active = f.Active
                                  }).ToList().OrderBy(fc => fc.CompanyName);

            return featureClients;
        }

        [HttpGet("[action]")]
        public IEnumerable<ClientModel> GetClientsAvailableForFeature(int featureId)
        {
            var featureClientIds = from fc in Context.FeatureClient
                                   where fc.FeatureId == featureId
                                   select fc.ClientId;

            var clients = (from c in Context.Client
                                  where !featureClientIds.Contains(c.ClientId)
                                    && c.DeactivateDateTime == null
                                  select new ClientModel
                                  {
                                      ClientId = c.ClientId,
                                      CompanyName = c.CompanyName
                                  }).ToList().OrderBy(fc => fc.CompanyName);

            return clients;
        }

        [HttpGet("[action]")]
        public void ActivateFeatureForClient(int featureId, int clientID)
        {
            
            var featureClient = Context.FeatureClient.Where(fc => fc.FeatureId == featureId && fc.ClientId == clientID).FirstOrDefault();

            if (featureClient != null)
            {
                featureClient.Active = true;
                Context.SaveChanges();
            }                    
        }

        [HttpGet("[action]")]
        public void DeactivateFeatureForClient(int featureId, int clientID)
        {
            
            var featureClient = Context.FeatureClient.Where(fc => fc.FeatureId == featureId && fc.ClientId == clientID).FirstOrDefault();

            if (featureClient != null)
            {
                featureClient.Active = false;
                Context.SaveChanges();
            }
        }

        [HttpGet("[action]")]
        public void AddClientToFeature(int featureId, int clientID)
        {

            var newFeatureClient = new FeatureClient()
            {
                FeatureId = featureId,
                ClientId = clientID,
                Active = true,
                CreateDateTime = DateTime.UtcNow,
                CreateUser = ""
            };

            Context.FeatureClient.Add(newFeatureClient);
            Context.SaveChanges();
        }

        [HttpGet("[action]")]
        public void RemoveClientFromFeature(int featureId, int clientID)
        {

            var featureClientToRemove = Context.FeatureClient.Where(fc => fc.FeatureId == featureId && fc.ClientId == clientID).FirstOrDefault();

            if (featureClientToRemove != null)
            {
                Context.FeatureClient.Remove(featureClientToRemove);
                Context.SaveChanges();
            }
        }

        [HttpGet("[action]")]
        public IEnumerable<FeatureFlagModel> GetFeatureFlags(int featureId)
        {
            var featureFlags = from fc in Context.FeatureConfig
                               from ff in Context.FeatureFlag
                               where fc.FeatureId == featureId
                               && fc.FeatureFlagId == ff.FeatureFlagId
                               select new FeatureFlagModel
                               {
                                   FeatureId = fc.FeatureId,
                                   FeatureFlagId = fc.FeatureFlagId,
                                   FlagName = ff.FlagName,
                                   FlagValue = fc.FeatureFlagValue
                               };

            return featureFlags;
        }

        [HttpGet("[action]")]
        public IEnumerable<ServerModel> GetServers()
        {
            var serversSetting = Configuration.GetSection("Servers")?.Get<List<ServerModel>>();

            return serversSetting;
        }
    }

    public class FeatureModel
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }

    public class FeatureClientModel
    {
        public int FeatureId { get; set; }
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public bool Active { get; set; }
    }

    public class FeatureFlagModel
    {
        public int FeatureId { get; set; }
        public int FeatureFlagId { get; set; }
        public string FlagName { get; set; }
        public int FlagValue { get; set; }
    }

    public class ClientModel
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
    }

    public class ServerModel
    {
        public string Name { get; set; }
        public bool CredsRequiredToUpdate { get; set; }
    }

}