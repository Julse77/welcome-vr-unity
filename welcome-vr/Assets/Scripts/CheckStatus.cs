using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatus : MonoBehaviour
{
    //public GameObject[] CheckLists;
    public List<GameObject> CheckLists = new List<GameObject>();

    private void CheckObjectsStatus()
    {
        for (int i = 0; i < CheckLists.Count; i++)
        {
            Debug.Log($"!!! {CheckLists[i]} of status is {CheckLists[i].activeSelf}");
        }    
    }

    private void FixedUpdate()
    {
        CheckObjectsStatus();
    }

}
