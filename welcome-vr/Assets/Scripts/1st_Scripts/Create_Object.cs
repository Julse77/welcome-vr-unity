using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Object : MonoBehaviour
{
    public GameObject myeongbu;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            myeongbu.SetActive(true);

        }

    }
}
