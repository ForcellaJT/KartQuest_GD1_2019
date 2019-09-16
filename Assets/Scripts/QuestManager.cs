using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests;
    [Space(10)]
    public UnityEvent OnAllQuestsComplete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CheckGameProgress()
    {
        int questsNeedToFinish = quests.Count;

        var questsCompleted = 0;

        foreach(Quest q in quests)
        {
            if (q.complete)
            {
                questsCompleted++;
            }
        }

        //if our completed quests equal the number needed to finish
        if(questsCompleted >= questsNeedToFinish)
        {
            OnAllQuestsComplete.Invoke();
        }
    }
}
