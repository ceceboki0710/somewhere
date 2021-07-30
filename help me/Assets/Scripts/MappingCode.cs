using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingCode : MonoBehaviour
{
    public RhythmGameMapper rhythms;

    public void TutorialRedCardinalPatternDemo()
    {
                    rhythms.beatsPerSecond = 119.4f;
                    rhythms.loopType = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 5;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void RedCardinalTutorialGameplay()
    {
                    rhythms.beatsPerSecond = 119.4f;
                    rhythms.loopType = 2;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 5;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void TutorialBlueJayPatterns()
    {
                    rhythms.loopType = 3;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 6;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 8;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void BlueJayTutorialGameplay()
    {
                    rhythms.loopType = 4;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 6;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 7;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }
    public void TutorialBullFinchPatterns()
    {
                    rhythms.loopType = 5;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 9;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 10;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 12;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

     public void BullFinchTutorialGamePlay()
    {
                    rhythms.loopType = 6;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 9;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 10;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 11;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void TutorialParrotPatterns()
    {
                    rhythms.loopType = 7;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 13;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 16;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 14;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void ParrotTutorialGamePlay()
    {
                    rhythms.loopType = 8;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 13;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 16;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 15;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void Brazil()
    {
         rhythms.loopType = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }  
}
