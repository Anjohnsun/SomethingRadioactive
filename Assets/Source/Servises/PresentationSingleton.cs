using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NuclearReactorSystem
{
    public class PresentationSingleton
    {
        private const string PRESENTATION_SO_PATH = "ResourcePresentation";
        private static PresentationSingleton instance;
        private ResourcePresentationDataSO resources = Resources.Load<ResourcePresentationDataSO>(PRESENTATION_SO_PATH);

        public static PresentationSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PresentationSingleton();
                }

                return instance;
            }
        }
        public void ChangeViewToActive(Image sourceImage, ResourceType resourceType)
        {
            foreach(ResourcePresentationData presentationData in resources.Resources)
            {
                if (presentationData.ResourceType.Equals(resourceType))
                {
                    sourceImage.sprite = presentationData.EnabledIcon;
                }
            }
        }

        public void ChangeViewToDisabled(Image sourceImage, ResourceType resourceType)
        {
            foreach (ResourcePresentationData presentationData in resources.Resources)
            {
                if (presentationData.ResourceType.Equals(resourceType))
                {
                    sourceImage.sprite = presentationData.DisabledIcon;
                }
            }
        }
    }
}
