using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestInfoBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questTextMP;
    public float timeToDespawn;

    private void Start()
    {
        Invoke("Despawn", timeToDespawn);
    }

    public void SetText(string newText)
    {
        questTextMP.text = newText;
    }

    public void Despawn()
    {
        Destroy(gameObject);
    }
}
