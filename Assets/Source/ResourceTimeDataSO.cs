using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NuclearReactorSystem
{
    [CreateAssetMenu(fileName = "NewResourceTimeDataSO", menuName = "SO/New Resource Time Data")]
    public class ResourceTimeDataSO : ScriptableObject
    {
        [SerializeField] private List<ResourceTimeData> _resources;

        public List<ResourceTimeData> Resources => _resources;
    }

    [Serializable]
    public class ResourceTimeData
    {
        [SerializeField] private ResourceType _resource;
        [SerializeField] private float _decayTime;
        [SerializeField] private float _enrichmentTime;

        public ResourceType Resource => _resource;
        public float DecayTime => _decayTime;
        public float EnrichmentTime => _enrichmentTime;
    }
}