using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NuclearReactorSystem
{
    public class ResourceButton : MonoBehaviour
    {
        [SerializeField] private Button _button; 
        [SerializeField] private ResourceType _resourceType;
        [SerializeField] private bool _isDecaying;

        private Game _game;

        public ResourceType ResourceType => _resourceType;
        public Game Game { get => _game; set => _game = value; }

        public void InitResourceButton()
        {
            StartCoroutine(ChangeStateCoroutine());
        }

        public void onButtonClick()
        {
            StopAllCoroutines();
            _button.interactable = false;
            StartCoroutine(ChangeStateCoroutine());
        }

        public void DisableButton()
        {
            StopAllCoroutines();
            _button.interactable = false;
        }

        private IEnumerator ChangeStateCoroutine()
        {
            PresentationSingleton.Instance.ChangeViewToDisabled(_button.image, _resourceType);
            yield return new WaitForSeconds(DataSingleton.Instance.GetEnrichmentTime(_resourceType));

            _button.interactable = true;
            PresentationSingleton.Instance.ChangeViewToActive(_button.image, _resourceType);
            yield return new WaitForSeconds(DataSingleton.Instance.GetDecayTime(_resourceType));

            _game.StopGame();
        }
    }
}