using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NuclearReactorSystem
{
    public class DataSingleton
    {
        private const string TIME_SO_PATH = "ResourceTime";
        private static DataSingleton instance;
        private ResourceTimeDataSO _resources = Resources.Load<ResourceTimeDataSO>(TIME_SO_PATH);

        public static DataSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataSingleton();
                }

                return instance;
            }
        }

        public float GetDecayTime(ResourceType resourceType)
        {
            foreach(ResourceTimeData resourceTime in _resources.Resources)
            {
                if (resourceTime.Resource.Equals(resourceType))
                {
                    return resourceTime.DecayTime;
                }
            }
            return 0;
        }

        public float GetEnrichmentTime(ResourceType resourceType)
        {
            foreach (ResourceTimeData resourceTime in _resources.Resources)
            {
                if (resourceTime.Resource.Equals(resourceType))
                {
                    return resourceTime.EnrichmentTime;
                }
            }
            return 0;
        }
    }
}