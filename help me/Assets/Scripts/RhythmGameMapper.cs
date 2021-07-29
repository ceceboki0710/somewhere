using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
[System.Serializable]
//Created by color!please studios


[RequireComponent(typeof(AudioSource))]

public class beatMap
{
    public int beatsBtwWave;
    public int eventType;

    public float noOfEvents;

    public float songPositionWave;

    public bool beatMode;
    public bool timeMode;

    public bool beatRest;

    public bool timeRest;




}



public class RhythmGameMapper : MonoBehaviour
{
    public beatMap[] Events;

    public beatMap currentEvent;
    public int currentEventNumber;

    public bool canSpawn;

    public int nextBeatsBtwWave;
    public float nextTimeBtwWave;

    public int callBackNumber;
    public static RhythmGameMapper Instance { get; set; }

    [Header("Assignables")]

    public float beatsPerSecond;

    public float beatsPerMeasure;

    //public float bpmDividedByFour;
    public float secPerBeat;

    public float secPerMeasure;
    public float songPosition;
    public float songDuration;
    private float songPositionInBeatsExact;
    public float songPositionInBeats;

    public float songPositionInMeasures;

    public int completedBeats = 0;

    public int completedMeasures = 0;

    public float loopPositionInBeats;

    public float beatThresholdLate;
    public float beatThresholdEarly;

    float[] targetBeats = new float[3];

    private float lastReportedBeat = 0f;

    public float dspSongTime;
    public float firstBeatOffset;
    public AudioSource musicSource;
    public AudioSource metronome_audioSrc;
    public float secPerRealBeat;

    public float songLength;

    public bool onBeat;

    public float songPosBeat;

    public float beatTime;

    private int timesQuarterBeat;
    public bool metronome;

    public bool beatGo;

    public bool timeGo;

    public bool willPress;

    public bool canPress;

    public bool newWaveGenerate;

    public bool autoPlay = true;

    public int randomBirdnumber;

    public int nextEventRandom;

    public AudioClip sound3;
    public AudioClip sound5;

    public AudioClip sound1;

    public AudioClip sound2;
    public AudioClip sound01;

    public AudioClip sound02;

    public GameObject clickedText;
    public GameObject failedText;
    public GameObject successText;
    public ScoreManager scoreManager;

    public Animator player;

    public bool birbTurn;

    public GameObject redBirb;

    public GameObject parrot;

    public GameObject blueJay;

    public GameObject blackBird;
    public Transform redBirbSpawn;

    public GameObject birbNote1;
    public GameObject birbNote2;

    public GameObject birbNote3;

    public GameObject playerNote1;
    public GameObject playerNote2;
    public GameObject playerNote3;

    public bool birbTurn2;

    public bool playerTurn;

    public Transform playerMouth;

    public Transform birdMouth;

    DayNightCycle dayNightCycle;

    public GameObject logbook;

    public GameObject gameOverScreen;

    public TextMeshProUGUI birdSeedPacketsCounter;

    public int noteEventNumber;

    public bool canBird;

    public bool singRightNow;

    public bool birbTurn3;

    public bool Resume2;
    public Animator bookLog;

    public Animator blackOut;

    public Animator dayTime;

    public Animator lowSun;

    public Animator night;

    public Animator earlyMorning;

    public bool sceneChange;

    public int changeNumber;

    public bool paused;

    public bool notBadAtGame;

    public int lives;

    public bool tutorial;

    public Transform radioMouth;

    public int loopType;

    public MappingCode mappingCode;

    public Animator Enter;

    public bool watching;

    public int realerScore;

    public Animator light;

    public Animator leftLamp;

    public Animator rightLamp;

    public bool singleTap;

    public float _doubleTapTimeD;

    public int doubleTapRootBeer;

    bool doubleTapD = false;

    void Start()
    {
        RhythmGameMapper.Instance = this;
        //Load the AudioSource attached to the Conductor GameObject
        musicSource.GetComponent<AudioSource>();
        //Metronome
        //metronome_audioSrc.GetComponent<AudioSource>();
        //Calculate the number of seconds in each beat
        secPerRealBeat = 60f / (beatsPerSecond);
        secPerBeat = 60f / (beatsPerSecond);
        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;
        //Start the music
        //musicSource.time = 10f;
        Application.targetFrameRate = 120;



        //dayNightCycle = GameObject.Find("Background").GetComponent<DayNightCycle>();

        //Invoke("OnAudioEnd", musicSource.clip.length + 2f);
    }

    void OnAudioEnd()
    {
        StartCoroutine(OnAudioEndCoroutine());
    }

    IEnumerator OnAudioEndCoroutine()
    {
        Debug.Log("song ended");
        yield return new WaitForSeconds(4f);
        DayNightCycle.switchBackground();
        SceneManager.LoadScene("GamePlay");
    }

    void Awake()
    {
        canPress = true;
        newWaveGenerate = true;
        nextEventRandom += 3;
        canBird = true;
        birbTurn3 = true;
        if (autoPlay)
        {
            //  musicSource.Play();
            songLength = musicSource.clip.length;

            currentEventNumber = 0;
            currentEvent = Events[currentEventNumber];
            StartCoroutine(StartMusic());
        }
        changeNumber = 0;
        notBadAtGame = false;
        realerScore = 0;
        doubleTapRootBeer = 0;


    }

    IEnumerator StartMusic()
    {
        yield return new WaitForSeconds(2f);
        musicSource.Play();
    }

    void Update()
    {
        birdSeedPacketsCounter.text = "x " + lives.ToString();

        if (musicSource.isPlaying == false)
        {
            return;
        }

        if (musicSource.isPlaying)
        {
            lastReportedBeat = songPositionInBeats;

            secPerRealBeat = (60f / (beatsPerSecond));
            secPerBeat = (60f / (beatsPerSecond));
            secPerMeasure = secPerRealBeat * beatsPerMeasure;

            //determine how many seconds since the song started
            //songPosition = (float)(AudioSettings.dspTime - dspSongTime);
            songPosition = (float)(AudioSettings.dspTime - dspSongTime - firstBeatOffset);
            //determine how many beats since the song started
            songPositionInBeatsExact = songPosition / secPerBeat;
            songPositionInBeats = (float)songPositionInBeatsExact;
            songPositionInMeasures = (float)(songPosition / secPerMeasure);
            ReportBeat();
            //GameTimeline();

            if (songPositionInBeats >= (completedBeats + 1))
            {
                completedBeats++;
            }

            if (songPositionInBeats >= (completedMeasures + 1) * beatsPerMeasure)
            {
                completedMeasures++;
            }

            loopPositionInBeats = songPositionInBeats - completedMeasures * beatsPerMeasure;

            if (Input.GetKeyDown(KeyCode.J))
            {
                Debug.Log(secPerRealBeat);
            }

            songPosBeat = (int)songPositionInBeats / beatsPerMeasure;
            ExecuteEvent();


            if (currentEvent.beatRest)
            {
                if (currentEvent.beatsBtwWave <= 0 && !canSpawn)
                {
                    canSpawn = true;
                    currentEventNumber += 1;
                    newWaveGenerate = true;
                    randomBirdnumber = Random.Range(0, 4);
                    currentEvent = Events[currentEventNumber];
                    timeGo = true;

                }
            }


            player.SetBool("willPress", willPress);



            if (currentEvent.timeRest)
            {
                if (currentEvent.songPositionWave < songPosition)
                {
                    canSpawn = true;
                    currentEventNumber++;
                    newWaveGenerate = true;
                    randomBirdnumber = Random.Range(0, 4);
                    currentEvent = Events[currentEventNumber];
                    beatGo = true;
                }


            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (singleTap)
                {
                    if (!watching)
                    {
                        if (canPress)
                        {
                            notBadAtGame = true;
                            if (!willPress)
                            {
                                if (lives == 1)
                                {
                                    lives--;
                                    StopCoroutine(StartMusic());
                                    player.SetBool("isGameOver", true);
                                    musicSource.Pause();
                                    gameOverScreen.SetActive(true);
                                    paused = true;
                                    canPress = false;
                                    scoreManager.SaveScore();
                                    scoreManager.highScoreText.text = "High Score: " + ScoreManager.highScore;
                                    birbTurn3 = false;
                                }
                                else
                                {
                                    Hurt();
                                }
                            }
                            else if (willPress)
                            {
                                realerScore++;
                                PlayerTurnAnimation();
                                singRightNow = false;
                                StartCoroutine(flyAway());
                                //successText.SetActive(true);
                                willPress = false;
                                scoreManager.AddScore();
                                canPress = false;
                                switch (callBackNumber)
                                {
                                    case 0:
                                        metronome_audioSrc.PlayOneShot(sound5, 1f);
                                        break;
                                    case 1:
                                        metronome_audioSrc.PlayOneShot(sound1, 1f);
                                        break;
                                }
                                player.SetBool("isPressed", true);
                                StartCoroutine(pressTimer());
                                StartCoroutine(takePictureAnimator());


                            }
                            //clickedText.SetActive(true);


                        }

                    }
                }
                else
                {


                    #region doubleTapD

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        doubleTapRootBeer += 1;
                        if (doubleTapRootBeer == 1)
                        {
                            metronome_audioSrc.PlayOneShot(sound01, 1f);
                            PlayerTurnAnimation();
                        }
                        if (Time.time < _doubleTapTimeD + .5f)
                        {
                            doubleTapD = true;
                        }
                        _doubleTapTimeD = Time.time;
                    }

                    #endregion

                    if (doubleTapD)
                    {
                        if (canPress)
                        {
                            notBadAtGame = true;
                            if (willPress)
                            {
                                realerScore++;
                                PlayerTurnAnimation();
                                singRightNow = false;
                                StartCoroutine(flyAway());
                                //successText.SetActive(true);
                                willPress = false;
                                scoreManager.AddScore();
                                canPress = false;
                                switch (callBackNumber)
                                {
                                    case 0:
                                        metronome_audioSrc.PlayOneShot(sound5, 1f);
                                        break;
                                    case 1:
                                        metronome_audioSrc.PlayOneShot(sound02, 1f);
                                        break;
                                }
                                player.SetBool("isPressed", true);
                                StartCoroutine(pressTimer());
                                StartCoroutine(takePictureAnimator());
                                notBadAtGame = true;

                            }
                            if (!willPress)
                            {
                                if (lives == 1)
                                {
                                    lives--;
                                    StopCoroutine(StartMusic());
                                    player.SetBool("isGameOver", true);
                                    musicSource.Pause();
                                    gameOverScreen.SetActive(true);
                                    paused = true;
                                    canPress = false;
                                    scoreManager.SaveScore();
                                    scoreManager.highScoreText.text = "High Score: " + ScoreManager.highScore;
                                    birbTurn3 = false;
                                }
                                else
                                {
                                    if (!doubleTapD)
                                    {
                                        Hurt();
                                    }

                                }
                            }
                        }
                        Debug.Log("DoubleTapD");
                    }
                }


            }



            if (currentEventNumber >= Events.Length - 1)
            {
                if (tutorial)
                {
                    currentEventNumber = 0;
                    nextEventRandom = 0;
                    currentEvent = Events[0];
                    switch (loopType)
                    {
                        case 0:
                            mappingCode.TutorialRedCardinalPatternDemo();
                            break;
                        case 1:
                            mappingCode.RedCardinalTutorialGameplay();
                            break;
                    }
                }

            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }

            if (!metronome_audioSrc.isPlaying)
            {
                player.SetBool("isPressed", false);
            }
        }

        if (!musicSource.isPlaying)
        {
            if (!paused)
            {
                sceneChange = true;
            }

        }

        if (sceneChange)
        {

            switch (changeNumber)
            {
                case 0:
                    dayTime.SetBool("daytimeBool", true);
                    light.SetFloat("lightNumber", 1);
                    changeNumber += 1;
                    break;
                case 1:
                    lowSun.SetBool("lowSunBool", true);
                    light.SetFloat("lightNumber", 2);
                    changeNumber += 1;
                    break;
                case 2:
                    night.SetBool("nightBool", true);
                    light.SetFloat("lightNumber", 3);
                    changeNumber += 1;
                    break;
                case 3:
                    lowSun.SetBool("lowSunBool", false);
                    light.SetFloat("lightNumber", 4);
                    changeNumber += 1;
                    break;
                case 4:
                    dayTime.SetBool("daytimeBool", false);
                    light.SetFloat("lightNumber", 5);
                    changeNumber += 1;
                    break;
                case 5:
                    dayTime.SetBool("daytimeBool", true);
                    light.SetFloat("lightNumber", -1);
                    changeNumber = 1;
                    break;


            }
            sceneChange = false;

        }

        if (changeNumber == 2)
        {
            leftLamp.SetBool("lightUp", true);
            rightLamp.SetBool("lightUp", true);
        }

        if (changeNumber == 3)
        {
            leftLamp.SetBool("lightUp", false);
            rightLamp.SetBool("lightUp", false);
        }




    }




    public void Pause()
    {
        paused = true;
        bookLog.SetBool("Enter", true);
        blackOut.SetBool("Focus", true);
        Time.timeScale = 0;
        musicSource.Pause();
        metronome_audioSrc.Pause();
    }

    public void Pause2()
    {
        paused = true;
        Time.timeScale = 0;
        musicSource.Pause();
        metronome_audioSrc.Pause();
    }

    public void Resume()
    {
        paused = false;
        blackOut.SetBool("Focus", false);
        StartCoroutine(DelayResume());
        Resume2 = true;
    }

    public void Resume22()
    {
        paused = false;
        bookLog.SetBool("Enter", false);
        StartCoroutine(DelayResume());
        Resume2 = true;
    }

    IEnumerator DelayResume()
    {
        yield return new WaitForSecondsRealtime(1);
        Resume2 = true;
    }

    void LateUpdate()
    {
        if (Resume2 == true)
        {
            Time.timeScale = 1;
            musicSource.UnPause();
            metronome_audioSrc.UnPause();
            Resume2 = false;
        }

    }
    void ExecuteEvent()
    {
        if (canSpawn == true)
        {

            if (currentEvent.beatMode == true && beatGo == true)
            {
                beatGo = false;
                EventType();



            }

            if (currentEvent.timeMode == true && beatGo == true)
            {

                timeGo = false;
                EventType();

            }


        }

        if (currentEvent.noOfEvents == 0)
        {
            canSpawn = false;

        }
    }

    void EventType()
    {
        switch (currentEvent.eventType)
        {
            case 0:
                canBird = true;
                singleTap = true;
                break;
            //Player plays the flute
            case 1:
                StartCoroutine(slackTimer(0.5f));
                noteEventNumber = currentEvent.eventType;
                Debug.Log("Song position in beats when player sound plays: " + songPositionInBeats);
                //metronome_audioSrc.PlayOneShot(sound5, 1f);
                break;
            //Bird enters
            case 2:
                singleTap = true;
                //StartCoroutine(slackTimer());
                metronome_audioSrc.PlayOneShot(sound3, 1f);
                noteEventNumber = currentEvent.eventType;
                Debug.Log("Song position in beats when bird sound plays: " + songPositionInBeats);
                birbTurn2 = true;
                singRightNow = true;
                BirbTurnAnimation();
                break;
            case 3:

                noteEventNumber = currentEvent.eventType;
                Debug.Log("Song position in beats when player sound plays: " + songPositionInBeats);
                //metronome_audioSrc.PlayOneShot(sound5, 1f);
                RadioTurnAnimation();
                singRightNow = false;
                StartCoroutine(flyAway());
                //successText.SetActive(true);
                willPress = false;
                canPress = false;
                switch (callBackNumber)
                {
                    case 0:
                        metronome_audioSrc.PlayOneShot(sound5, 1f);
                        break;
                    case 1:
                        metronome_audioSrc.PlayOneShot(sound1, 1f);
                        break;
                }
                player.SetBool("isPressed", true);
                StartCoroutine(pressTimer());
                notBadAtGame = true;
                break;
            case 4:
                doubleTapRootBeer = 0;
                singleTap = false;
                metronome_audioSrc.PlayOneShot(sound2, 1f);
                noteEventNumber = currentEvent.eventType;
                Debug.Log("Song position in beats when bird sound plays: " + songPositionInBeats);
                birbTurn2 = true;
                singRightNow = true;
                BirbTurnAnimation();
                break;

            case 5:
                Instantiate(redBirb, redBirbSpawn.position, Quaternion.identity);
                canBird = false;
                birbTurn = true;
                birbTurn3 = true;
                callBackNumber = 0;
                break;
            case 6:
                Instantiate(blueJay, redBirbSpawn.position, Quaternion.identity);
                canBird = false;
                birbTurn = true;
                birbTurn3 = true;
                callBackNumber = 1;
                break;

            case 7:
                StartCoroutine(slackTimer(1f));
                noteEventNumber = currentEvent.eventType;
                Debug.Log("Song position in beats when player sound plays: " + songPositionInBeats);
                //metronome_audioSrc.PlayOneShot(sound5, 1f);
                break;



        }

    }

    void ReportBeat()
    {
        if (lastReportedBeat < (int)songPositionInBeats)
        {
            onBeat = true;
            beatsInLoop += 1;
            beatTime += 0.25f;
            QuarterBeat();
            lastReportedBeat = songPositionInBeats;
            //StartCoroutine(fadeText());
        }
        else
        {
            onBeat = false;
        }
    }

    [SerializeField] private int beatsInLoop;

    public void QuarterBeat()
    {
        if (metronome == true && lastReportedBeat >= 0f)
        {
            //plays metronome click at every quarter note
            metronome_audioSrc.PlayOneShot(metronome_audioSrc.clip, 1f);
        }




        if (!canSpawn && currentEvent.beatMode == true)
        {
            currentEvent.beatsBtwWave -= 1;
        }
        if (canSpawn && currentEvent.noOfEvents > 0)
        {
            beatGo = true;
            currentEvent.noOfEvents--;
        }


        if (beatsInLoop == 4)
        {
            beatsInLoop = 0;
        }

    }



    public void FullBeat()
    {
        //BeatEvent();
        Debug.Log("Full");


    }

    void PlayerTurnAnimation()
    {
        player.SetBool("isPressed", true);
        switch (noteEventNumber)
        {
            case 1:
                var randomNoteNumber = Random.Range(0, 3);
                switch (randomNoteNumber)
                {
                    case 0:
                        GameObject effect = Instantiate(playerNote1, playerMouth.position, Quaternion.identity);
                        Destroy(effect, 2f);
                        break;

                    case 1:
                        GameObject effect2 = Instantiate(playerNote2, playerMouth.position, Quaternion.identity);
                        Destroy(effect2, 2f);
                        break;

                    case 2:
                        GameObject effect3 = Instantiate(playerNote3, playerMouth.position, Quaternion.identity);
                        Destroy(effect3, 2f);
                        break;
                }
                break;

            case 7:
                var randomNoteNumber2 = Random.Range(0, 3);
                switch (randomNoteNumber2)
                {
                    case 0:
                        GameObject effect = Instantiate(playerNote1, playerMouth.position, Quaternion.identity);
                        Destroy(effect, 2f);
                        break;

                    case 1:
                        GameObject effect2 = Instantiate(playerNote2, playerMouth.position, Quaternion.identity);
                        Destroy(effect2, 2f);
                        break;

                    case 2:
                        GameObject effect3 = Instantiate(playerNote3, playerMouth.position, Quaternion.identity);
                        Destroy(effect3, 2f);
                        break;
                }
                break;
        }
    }


    void BirbTurnAnimation()
    {
        switch (noteEventNumber)
        {
            case 2:
                StartCoroutine(birbNoteTurn1());
                break;

            case 4:
                StartCoroutine(birbNoteTurn2());
                break;

        }
    }

    void RadioTurnAnimation()
    {
        switch (noteEventNumber)
        {

            case 3:
                var randomNoteNumber = Random.Range(0, 3);
                switch (randomNoteNumber)
                {
                    case 0:
                        GameObject effect = Instantiate(playerNote1, radioMouth.position, Quaternion.identity);
                        Destroy(effect, 2f);
                        break;

                    case 1:
                        GameObject effect2 = Instantiate(playerNote2, radioMouth.position, Quaternion.identity);
                        Destroy(effect2, 2f);
                        break;

                    case 2:
                        GameObject effect3 = Instantiate(playerNote3, radioMouth.position, Quaternion.identity);
                        Destroy(effect3, 2f);
                        break;
                }
                break;

            case 7:
                var randomNoteNumber2 = Random.Range(0, 3);
                switch (randomNoteNumber2)
                {
                    case 0:
                        GameObject effect = Instantiate(playerNote1, radioMouth.position, Quaternion.identity);
                        Destroy(effect, 2f);
                        break;

                    case 1:
                        GameObject effect2 = Instantiate(playerNote2, radioMouth.position, Quaternion.identity);
                        Destroy(effect2, 2f);
                        break;

                    case 2:
                        GameObject effect3 = Instantiate(playerNote3, radioMouth.position, Quaternion.identity);
                        Destroy(effect3, 2f);
                        break;
                }
                break;
        }
    }


    IEnumerator pressTimer()
    {
        yield return new WaitForSeconds(0.5f);
        canPress = true;

    }

    IEnumerator fadeText()
    {
        yield return new WaitForSeconds(0.6f);
        clickedText.SetActive(false);
        failedText.SetActive(false);
        successText.SetActive(false);
    }

    IEnumerator takePictureAnimator()
    {
        player.SetBool("takePicture", true);
        yield return new WaitForSeconds(0.3f);
        player.SetBool("takePicture", false);
    }

    IEnumerator slackTimer(float wait)
    {
        willPress = true;
        yield return new WaitForSeconds(wait);
        willPress = false;
        if (notBadAtGame == false)
        {
            Hurt();
            Debug.Log("sus");
        }
    }

    void Hurt()
    {
        lives--;
        birbTurn3 = false;
        willPress = false;
        StartCoroutine(pressTimer());
        StopCoroutine(slackTimer(0.5f));
        StartCoroutine(ow());
    }

    IEnumerator birbNoteTurn1()
    {
        GameObject effect = Instantiate(birbNote1, birdMouth.position, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        GameObject effect2 = Instantiate(birbNote2, birdMouth.position, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        GameObject effect3 = Instantiate(birbNote3, birdMouth.position, Quaternion.identity);
        Destroy(effect3, 2f);
        Destroy(effect, 2f);
        Destroy(effect2, 2f);
    }

    IEnumerator birbNoteTurn2()
    {
        GameObject effect = Instantiate(birbNote1, birdMouth.position, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        GameObject effect2 = Instantiate(birbNote2, birdMouth.position, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        GameObject effect3 = Instantiate(birbNote3, birdMouth.position, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        GameObject effect4 = Instantiate(birbNote1, birdMouth.position, Quaternion.identity);
        Destroy(effect3, 2f);
        Destroy(effect, 2f);
        Destroy(effect2, 2f);
        Destroy(effect4, 2f);
    }

    IEnumerator flyAway()
    {
        yield return new WaitForSecondsRealtime(0.7f);
        birbTurn3 = false;

    }

    IEnumerator ow()
    {
        player.SetBool("isPressed", true);
        yield return new WaitForSecondsRealtime(0.3f);
        player.SetBool("isGameOver", true);
        yield return new WaitForSecondsRealtime(0.3f);
        player.SetBool("isPressed", false);
        player.SetBool("isGameOver", false);
    }





}