using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Animator text;
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI highScoreText;

    public TextMeshProUGUI logbookHighScoreText;
    static public float score;

    static public float highScore;

    public GameObject RhythmGameMapper;

    public float realerScore;

    // Start is called before the first frame update
    void Start()
    { 
        if (score == null)
        {
            score = 0;
        }

        highScore = PlayerPrefs.GetFloat("High Score", 0);
        
        scoreText.SetText(score.ToString());

        highScoreText.SetText("High Score: " + highScore);
        logbookHighScoreText.SetText(highScore.ToString());
        highScoreText.SetText(highScore.ToString());
        //RhythmGameMapper.SetActive(false);
    }

    void Awake()
    {
        //StartCoroutine(pancakes());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore()
    {
        score += 1;
        scoreText.SetText(score.ToString());
        StartCoroutine(addScoreAnimation());
    }

    IEnumerator addScoreAnimation()
    {
        text.SetBool("addScore", true);
        yield return new WaitForSeconds(0.2f);
        text.SetBool("addScore", false);

    }

    IEnumerator pancakes()
    {
        yield return new WaitForSeconds(2f);
        RhythmGameMapper.SetActive(true);
    }

    public void SaveScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("High Score", highScore);
        }
    }
}
