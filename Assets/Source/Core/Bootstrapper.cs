using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NuclearReactorSystem;
using TMPro;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private List<ResourceButton> _buttons;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private Score _score;
    [SerializeField] private EndPanel _endPanelScript;

    private Game _game;

    private void Start()
    {
        _game = new Game(_buttons, _scoreText, _score, _endPanelScript);
        foreach (ResourceButton button in _buttons)
        {
            button.Game = _game;
        }
        _endPanelScript.Game = _game;
        _game.StartGame();
    }
}
