using System.Collections;
using System.Collections.Generic;
using TMPro;
using NuclearReactorSystem;

public class Game
{
    private List<ResourceButton> _buttons;
    private TextMeshProUGUI _scoreText;
    private Score _score;
    private EndPanel _endPanelScript; 

    public Game(List<ResourceButton> buttons, TextMeshProUGUI scoreText, Score score, EndPanel endPanelScript)
    {
        _buttons = buttons;
        _scoreText = scoreText;
        _score = score;
        _endPanelScript = endPanelScript;
    }

    public void StartGame()
    {
        _scoreText.text = "0";
        _score.StartScoreIncreasing();
        foreach (ResourceButton button in _buttons)
        {
            button.InitResourceButton();
        }
        _endPanelScript.HidePanel();
    }

    public void StopGame()
    {
        _score.StopScoreIncreasing();
        foreach (ResourceButton button in _buttons)
        {
            button.DisableButton();
        }
        _endPanelScript.ShowPanel();
    }
}
