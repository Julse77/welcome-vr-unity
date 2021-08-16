using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manLookPlayer : MonoBehaviour
{
    // player 위치 변수
    public Transform player;
    private Vector3 playerPosition;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3(player.position.x, player.position.y, player.position.z);
        transform.LookAt(playerPosition);
    }
}
