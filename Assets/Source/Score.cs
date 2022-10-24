using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreValueText;
    [SerializeField] int scoreValue;

    [SerializeField] float _increaseDelay;

    public void StartScoreIncreasing()
    {
        StartCoroutine(IncreaseScoreCoroutine());
    }

    public void StopScoreIncreasing()
    {
        StopAllCoroutines();
    }

    private IEnumerator IncreaseScoreCoroutine()
    {
        yield return new WaitForSeconds(_increaseDelay);
        scoreValue++;
        scoreValueText.text = scoreValue.ToString();
        yield return StartCoroutine(IncreaseScoreCoroutine());
    }
}
