using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class ActiveWithKey : MonoBehaviour
{
    [InfoBox("On key down, sets objects active or inactive based on the first objects activeInHierarchy")]
    [Space(10)]
    public KeyCode key;
    public GameObject[] objects;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (objects[0].activeInHierarchy)
            {
                foreach(GameObject go in objects)
                {
                    go.SetActive(false);
                }
            }
            else
            {
                foreach (GameObject go in objects)
                {
                    go.SetActive(true);
                }
            }
        }
    }
}
