using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Text Score;
    [SerializeField] private Text ScoreValue;
    [SerializeField] private Text BestScore;
    [SerializeField] private Text BestScoreValue;
    [SerializeField] private Button resetButton;
    [SerializeField] private Text resetText;
    [SerializeField] private Text Gameover;
    [SerializeField] private GameObject GameOverpanel;
    [SerializeField] private GameObject Scorepanel;
    [SerializeField] private Text TapText;
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TapText.enabled = false;
        }
    }

    public void GameStart()
    {
        Score.enabled = false;
        ScoreValue.enabled = false;
        BestScore.enabled = false;
        BestScoreValue.enabled = false;
        resetButton.image.enabled = false;
        resetText.enabled = false;
        Gameover.enabled = false;
        GameOverpanel.GetComponent<Image>().enabled = false;
        Scorepanel.GetComponent<Image>().enabled = false;
    }

    public void GameOver()
    {
        Score.enabled = true;
        ScoreValue.enabled = true;
        BestScore.enabled = true;
        BestScoreValue.enabled = true;
        resetButton.image.enabled = true;
        resetText.enabled = true;
        Gameover.enabled = true;
        GameOverpanel.GetComponent<Image>().enabled = true;
        Scorepanel.GetComponent<Image>().enabled = true;
    }

    public void Reset()
    {
    }

}
