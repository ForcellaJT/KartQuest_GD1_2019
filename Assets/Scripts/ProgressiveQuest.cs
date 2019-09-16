using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[CreateAssetMenu]
public class ProgressiveQuest : Quest
{
    //public UnityEvent OnQuestUpdate;
    public string questProgressText;
    private string _orignalProgressText;

    [Header("Progress")]
    [Tooltip("Total number of steps to complete")]
    public int totalSteps;

    [Tooltip("Current quest progress")]
    public int progress;

    private void Start()
    {
        
    }

    public void AddProgress()
    {
        progress++;

        questProgressText = _orignalProgressText + " - (" + progress.ToString() + "/" + totalSteps.ToString() + ")";

        //if a quest info box already exists, destory it
        if (FindObjectOfType<QuestInfoBox>())
        {
            Destroy(FindObjectOfType<QuestInfoBox>().gameObject);
        }

        QuestInfoBox q = Instantiate(questInfoBox.gameObject, null).GetComponent<QuestInfoBox>();
        q.SetText(questProgressText);

        UpdateQuest();
        CheckForComplete();
    }

    public void CheckForComplete()
    {
        if(progress >= totalSteps)
        {
            OnQuestComplete.Invoke();
        }
    }
}
