using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manLookPlayer : MonoBehaviour
{
    // player 위치 변수
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
