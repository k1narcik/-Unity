using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    public int score;
    public Text distance;

    private Coroutine scoreCoroutine;

    void Start () {
        score = 0;
        scoreCoroutine = StartCoroutine(updateScoreManager(1f, 1));
    }

    IEnumerator updateScoreManager(float totalTime, int amount) {
        while(true) {
            score += amount; 
            distance.text = score.ToString();
            yield return new WaitForSeconds (2f);
        }
    }

    // example of ending game
    void EndGame() {
        StopCoroutine(scoreCoroutine);
        scoreCoroutine = null;
    }
}

