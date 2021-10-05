using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_doorOpen_1 : MonoBehaviour
{

    public GameObject firstdooropensound;
    public GameObject door;



    // Update is called once per frame
    public void PlayAnimation()
    {
        door.SetActive(false);
        firstdooropensound.SetActive(true);
        Invoke("sounddeactivate", 5f);

    }
    void sounddeactivate()
    {
        firstdooropensound.SetActive(false);
    }
}
