using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartLevelObjectives : MonoBehaviour
{
    public TextMeshProUGUI questObjective;
    public QuestManager questManager;

    public float TimeToDespawn;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Quest q in questManager.quests)
        {
            TextMeshProUGUI info = Instantiate(questObjective, transform);
            info.SetText(q.questText);
        }

        Invoke("Despawn", TimeToDespawn);
    }

    public void Despawn()
    {
        //Destroy(transform.root.gameObject);

        transform.parent.gameObject.SetActive(false);
    }

}
