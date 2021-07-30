using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{

    public RhythmGameMapper rhythm;
    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI instructionText;
    public string[] dialogue;

    public string[] instructions;
    public float speed;

    public int textIndex;

    public int instructionIndex;

    public int[] targetIndex;

    public int targetIndexNumber;

    public bool showtime;

    public GameObject instructionText2;

    public GameObject dialogueText2;

    public bool pressed;

    public bool watch;

    public bool back;
    public bool bridge;

    public Animator escape;

    public AudioSource ambience;

    


    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    void Awake()
    {
        targetIndexNumber = 0;
        showtime = false;
        pressed = false;
        watch = false;
        back = false;
        bridge = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (bridge)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                //rhythm.Resume22();
                StartCoroutine(rhythm.fading());
            }
        }
        else
        {
            escape.SetBool("god", true);
        }
        SaveMe();
        if (!showtime)
        {
             if (Input.GetKeyDown(KeyCode.Return))
        {
            if (dialogueText.text == dialogue[textIndex])
            {
                NextLine();
                pressed = true;
                rhythm.Enter.SetBool("change", false);
            }
        }
        rhythm.Pause2();
        }
       
       if (back)
       {
           ambience.Play();
           ScoreManager.score = 0;
           if (Input.GetKeyDown(KeyCode.Return))
           {
                switch(rhythm.loopType)
                {
                    case 1:
                    rhythm.parent.SetActive(false);
                    break;
                    case 2: 
                    rhythm.parent.SetActive(false);
                    break;
                    case 3:
                    rhythm.parent2.SetActive(false);
                    Debug.Log("why");
                    break;
                    case 4:
                     rhythm.parent2.SetActive(false);
                     break;

                    case 5:
                    rhythm.parent3.SetActive(false);
                    break;

                    case 6:
                    rhythm.parent3.SetActive(false);
                    break;

                    case 7: 
                    rhythm.parent4.SetActive(false);
                    break;

                    case 8:
                    rhythm.parent4.SetActive(false);
                    break;
                }
               showtime = false;
               NextLine();
                pressed = true;
                rhythm.Enter.SetBool("change", false);
                dialogueText2.transform.localScale = new Vector3(1, 1, 1);
                instructionText2.transform.localScale = new Vector3(0, 0 ,0);
                rhythm.currentEventNumber = 0;
                rhythm.nextEventRandom = 0;
                rhythm.currentEvent = rhythm.Events[0];
                rhythm.mappingCode.Brazil();
                pressed = false;
                GameObject[] birds = GameObject.FindGameObjectsWithTag("Cardinals");
                foreach(GameObject bird in birds)
                GameObject.Destroy(bird);

                GameObject[] notes = GameObject.FindGameObjectsWithTag("bop");
                foreach(GameObject note in notes)
                note.SetActive(false);
                 back = false;

           }

           if (rhythm.realerScore == 3)
           {
               ambience.Play();
               ScoreManager.score = 0;
                 switch(rhythm.loopType)
                {
                    case 1:
                    rhythm.parent.SetActive(false);
                    break;
                    case 2: 
                    rhythm.parent.SetActive(false);
                    break;
                    case 3: 
                    rhythm.parent2.SetActive(false);
                    break;
                    case 4:
                     rhythm.parent2.SetActive(false);
                     break;

                    case 5:
                    rhythm.parent3.SetActive(false);
                    break;

                    case 6: 
                    rhythm.parent3.SetActive(false);
                    break;

                     case 7: 
                     rhythm.parent4.SetActive(false);
                    break;

                    case 8:
                    rhythm.parent4.SetActive(false);
                    break;
                }
               showtime = false;
               NextLine();
                pressed = true;
                rhythm.Enter.SetBool("change", false);
                dialogueText2.transform.localScale = new Vector3(1, 1, 1);
                instructionText2.transform.localScale = new Vector3(0, 0 ,0);
                rhythm.currentEventNumber = 0;
                rhythm.nextEventRandom = 0;
                rhythm.currentEvent = rhythm.Events[0];
                rhythm.mappingCode.Brazil();
                GameObject[] birds = GameObject.FindGameObjectsWithTag("Cardinals");
                foreach(GameObject bird in birds)
                GameObject.Destroy(bird);
                rhythm.realerScore = 0;

                 GameObject[] notes = GameObject.FindGameObjectsWithTag("bop");
                foreach(GameObject note in notes)
                note.SetActive(false);
                 back = false;
               
           }
       }

       if (showtime)
       {
            
       }
       else
       {
           //rhythm.tutorial = false;
       }

       if (rhythm.realerScore == 3)
       {
           back = true;
       }

       
    }

    void StartDialogue()
    {
        textIndex = 0;
        StartCoroutine(TypeLine());
        StartCoroutine(hey());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in dialogue[textIndex].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSecondsRealtime(speed);
        }
    }

    void NextLine()
    {
        bridge = false;
        if (!showtime)
        {
             StartCoroutine(sus());
             if (textIndex <= targetIndex[targetIndexNumber])
        {
            textIndex++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
            rhythm.Enter.SetBool("change", false);
        }
        else
        {
        }
        if (textIndex >= targetIndex[targetIndexNumber])
        {
            targetIndexNumber++;
            dialogueText2.transform.localScale = new Vector3(0, 0, 0);
            rhythm.Resume22();
            instructionText.text = instructions[instructionIndex];
            instructionText2.transform.localScale = new Vector3(1, 1 ,1);
            instructionIndex++;
            watch = true;
            showtime = true;
            rhythm.paused = false;
            ambience.Pause();
        }
        if (textIndex == 5 || textIndex == 13 || textIndex == 20 || textIndex == 24)
        {
            StartCoroutine(jumpOffABridge());
            rhythm.watching = true;
        }
        else
        {
            rhythm.watching = false;
        }
        }
       

        
    }

    void SaveMe()
    {
        rhythm.loopType = targetIndexNumber;
    }

    IEnumerator jumpOffABridge()
    {
        yield return new WaitForSecondsRealtime(10f);
        rhythm.Enter.SetBool("change", true);
        back = true;
        
        
    }

    IEnumerator hey()
    {
        if (!watch)
        {
        yield return new WaitForSecondsRealtime(0.1f);
        pressed = false;
        yield return new WaitForSecondsRealtime(5f);
        if (pressed == false)
        {
            rhythm.Enter.SetBool("change", true);
        }
        }
      
    }

    IEnumerator sus()
    {
        yield return new WaitForSecondsRealtime(0.01f);
        StartCoroutine(hey());
    }

  

   
}
