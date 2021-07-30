using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{

    public GameObject hey;

    public GameObject hey2;

    public GameObject hey3;

    public GameObject hey4;

    public GameObject black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(play());
    }

    public void ExitGame()
    {
       StartCoroutine(quit());
    }

    IEnumerator quit()
    {
        black.SetActive(true);
        yield return new WaitForSeconds(1);
         Application.Quit();
    }

     IEnumerator play()
    {
        black.SetActive(true);
        yield return new WaitForSeconds(1);
         ScoreManager.score = 0;
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitPressed()
    {
        hey.SetActive(false);
        hey2.SetActive(true);
    }

    public void QuitNotPressed()
    {
         hey.SetActive(true);
        hey2.SetActive(false);
    }

    public void PlayNotPressed()
    {
        hey3.SetActive(true);
        hey4.SetActive(false);
        Debug.Log("huh");
    }

    public void PlayPressed()
    {
         hey3.SetActive(false);
         hey4.SetActive(true);
    }
}
