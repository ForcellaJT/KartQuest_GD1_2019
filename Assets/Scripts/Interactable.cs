using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [Tooltip("If true, the condtion will check for the gameObjects tag instead of its name")]
    public bool useTags;
    //public string[] keys;
    public List<string> keys;

    [Header("Events")]

    public UnityEvent TriggerEnter;
    public UnityEvent TriggerExit;
    public UnityEvent TriggerStay;

    private void OnTriggerEnter(Collider other)
    {
        if (useTags)
        {
            var tag = other.transform.root.tag;

            if (keys.Contains(tag))
            {
                TriggerEnter.Invoke();
            }
        }

        else
        {
            var parent = other.transform.root;

            if (keys.Contains(parent.name))
            {
                TriggerEnter.Invoke();
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        var parent = other.transform.root;

        if (keys.Contains(parent.name))
        {
            TriggerExit.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        var parent = other.transform.root;

        if (keys.Contains(parent.name))
        {
            TriggerStay.Invoke();
        }
    }
}
