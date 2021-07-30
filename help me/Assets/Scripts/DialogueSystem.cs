using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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


    public ScoreManager socrelol;

    


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
    }

    // Update is called once per frame
    void Update()
    {
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
           if (Input.GetKeyDown(KeyCode.Return))
           {
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
                back = false;
                pressed = false;
                GameObject[] birds = GameObject.FindGameObjectsWithTag("Cardinals");
                foreach(GameObject bird in birds)
                GameObject.Destroy(bird);
                switch(rhythm.loopType)
                {
                    case 1:
                    rhythm.parent.SetActive(false);
                    break;
                    case 2: 
                    rhythm.parent.SetActive(false);
                    break;
                    case 3:
                     rhythm.parent.SetActive(false);
                     break;
                }

           }

           if (rhythm.realerScore == 3)
           {
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
                back = false;
                GameObject[] birds = GameObject.FindGameObjectsWithTag("Cardinals");
                foreach(GameObject bird in birds)
                GameObject.Destroy(bird);
                rhythm.realerScore = 0;
                 switch(rhythm.loopType)
                {
                    case 1:
                    rhythm.parent.SetActive(false);
                    break;
                    case 2: 
                    rhythm.parent.SetActive(false);
                    break;
                    case 3:
                     rhythm.parent.SetActive(false);
                     break;
                }
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
