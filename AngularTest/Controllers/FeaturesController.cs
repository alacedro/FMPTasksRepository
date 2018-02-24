using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AngularTest.Models.AODB;

namespace AngularTest.Controllers
{
    [Route("api/[controller]")]
    public class FeaturesController : Controller
    {
        private readonly AODBContext context;

        public FeaturesController(AODBContext context)
        {
            this.context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<FeatureModel> GetFeatures()
        {
            var features = context.Feature.OrderBy(f => f.Name).Select(f => new FeatureModel
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
            var featureClients = (from f in context.FeatureClient
                                  from c in context.Client
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
            var featureClientIds = from fc in context.FeatureClient
                                   where fc.FeatureId == featureId
                                   select fc.ClientId;

            var clients = (from c in context.Client
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
            
            var featureClient = context.FeatureClient.Where(fc => fc.FeatureId == featureId && fc.ClientId == clientID).FirstOrDefault();

            if (featureClient != null)
            {
                featureClient.Active = true;
                context.SaveChanges();
            }                    
        }

        [HttpGet("[action]")]
        public void DeactivateFeatureForClient(int featureId, int clientID)
        {
            
            var featureClient = context.FeatureClient.Where(fc => fc.FeatureId == featureId && fc.ClientId == clientID).FirstOrDefault();

            if (featureClient != null)
            {
                featureClient.Active = false;
                context.SaveChanges();
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

            context.FeatureClient.Add(newFeatureClient);
            context.SaveChanges();
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

    public class ClientModel
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
    }

}