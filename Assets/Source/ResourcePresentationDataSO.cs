using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NuclearReactorSystem
{
    [CreateAssetMenu(fileName = "NewResourcePresentationDataSO", menuName = "SO/ New Resource Presentation Data")]
    public class ResourcePresentationDataSO : ScriptableObject
    {
        [SerializeField] private List<ResourcePresentationData> _resources;
        public List<ResourcePresentationData> Resources => _resources;
    }

    [Serializable]
    public class ResourcePresentationData
    {
        [SerializeField] private ResourceType _resourceType;
        [SerializeField] private Sprite _enabledIcon;
        [SerializeField] private Sprite _disabledIcon;

        public ResourceType ResourceType => _resourceType;
        public Sprite EnabledIcon => _enabledIcon;
        public Sprite DisabledIcon => _disabledIcon;
    }
}