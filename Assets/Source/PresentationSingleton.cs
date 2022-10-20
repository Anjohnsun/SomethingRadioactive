using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NuclearReactorSystem
{
    public class PresentationSingleton : MonoBehaviour
    {
        private const string PRESENTATION_SO_PATH = "ResourcePresentation";

        private static PresentationSingleton instance;
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
        public void ChangeViewToActive(GameObject button)
        {
         //   button.GetComponent<Button>().image.sprite = Resources.Load(PRESENTATION_SO_PATH, typeof(ResourcePresentationDataSO));
        }

        public void ChangeViewToDisabled()
        {

        }
    }
}
