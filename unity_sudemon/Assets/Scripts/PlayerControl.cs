using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //  public 변수 선언
    public int speedForward = 6;    //  전진 속도
    public int speedSide = 6;       //  옆걸음 속도
    public int speedRotate = 1;     //  회전 속도


    //  private 변수 선언
    private Transform tr;           //  위치
    private float dirX = 0;         //  좌우 이동 값
    private float dirZ = 0;         //  앞뒤 이동 값
    private float rotLR = 0;        //  회전 값


    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()   // Player 이동
    {               
        dirX = 0;   //  좌우 이동 방향 (왼쪽 : -1, 오른쪽 : 1)
        dirZ = 0;   //  전진 후진 이동 방향 (후진 : -1, 전진 : 1)

        // 왼손 스틱 입력
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);

            if (absX > absY)
            {
                // Right
                if (coord.x > 0)
                    dirX = +1;
                // Left
                else if (coord.x < 0)
                    dirX = -1;
                else
                    dirX = 0;

            }
            else
            {
                // Up
                if (coord.y > 0)
                    dirZ = +1;
                // Down
                else if (coord.y < 0)
                    dirZ = -1;
                else
                    dirZ = 0;

            }
            // 이동 방향 설정 후 이동
            Vector3 moveDir = new Vector3(dirX * speedSide, 0, dirZ * speedForward);
            transform.Translate(moveDir * Time.smoothDeltaTime);
        }
         
    }

    void RotatePlayer()     // Player 회전
    {
        // 오른손 스틱 입력
        Vector2 coord = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        var absX = Mathf.Abs(coord.x);
        var absY = Mathf.Abs(coord.y);

        if (absX > absY)
        {
            // Right
            if (coord.x > 0)
                rotLR = +1;
            // Left
            else if (coord.x < 0)
                rotLR = -1;
            else
                rotLR = 0;

        }
        else
            rotLR = 0;

        transform.Rotate(0f, rotLR * speedRotate, 0f);

    }

}