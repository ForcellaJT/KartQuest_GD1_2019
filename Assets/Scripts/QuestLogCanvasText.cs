using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class QuestLogCanvasText : MonoBehaviour
{
    public Quest myQuest;
    public TextMeshProUGUI uncompleteText;
    public TextMeshProUGUI completeText;

    //we check quest progres on enable incase our quest was completed
    //while our gameobject was inactive
    private void OnEnable()
    {
        uncompleteText.text = myQuest.questText;
        completeText.text = myQuest.questCompleteText;
        CheckQuestProgress();
    }

    // Start is called before the first frame update
    void Start()
    {
        //we need to gather our text info
        uncompleteText.text = myQuest.questText;
        completeText.text = myQuest.questCompleteText;

        //if our quest is not complete, then we set the default values
        if (!myQuest.complete)
        {
            uncompleteText.gameObject.SetActive(true);
            completeText.gameObject.SetActive(false);
        }
        else
        {
            uncompleteText.gameObject.SetActive(false);
            completeText.gameObject.SetActive(true);
        }
    }

    /* Our game event listener looks to see 
     * if a quest is complete. If true then we
     * finish this function.   
    */
    public void CheckQuestProgress()
    {
        if (myQuest.complete)
        {
            uncompleteText.gameObject.SetActive(false);
            completeText.gameObject.SetActive(true);
        }

    }
}
