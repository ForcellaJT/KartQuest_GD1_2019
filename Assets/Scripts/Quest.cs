using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[CreateAssetMenu]
public class Quest : MonoBehaviour
{
    public bool complete;
    public QuestInfoBox questInfoBox;
    public GameEvent completeEvent; 

    [Space(10)]
    public UnityEvent OnQuestComplete;
    public UnityEvent OnQuestUpdate;

    [Space(10)]
    public string questText;
    public string questCompleteText;

    private void Start()
    {
        complete = false; 
    }

    public virtual void CompleteQuest()
    {
        //if a quest info box already exists, destory it
        if (FindObjectOfType<QuestInfoBox>())
        {
            Destroy(FindObjectOfType<QuestInfoBox>().gameObject);
        }

        QuestInfoBox q = Instantiate(questInfoBox.gameObject, null).GetComponent<QuestInfoBox>();
        q.SetText(questCompleteText);

        complete = true;

        completeEvent.Raise();
        OnQuestComplete.Invoke();
    }

    public virtual void UpdateQuest()
    {
        //QuestInfoBox q = Instantiate(questInfoBox.gameObject, null).GetComponent<QuestInfoBox>();
        //q.SetText(questCompleteText);
        OnQuestUpdate.Invoke();
    }
}
