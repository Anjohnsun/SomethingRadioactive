using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPanel : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    private Game _game;
    public Game Game { get => _game; set => _game = value; }

    public void onButtonClick()
    {
        Game.StartGame();
    }

    public void ShowPanel()
    {
        _endPanel.SetActive(true);
    }
    public void HidePanel()
    {
        _endPanel.SetActive(false);
    }

}
