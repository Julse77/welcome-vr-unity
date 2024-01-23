using UnityEngine;

public class ControlObjectAnimation : MonoBehaviour
{
    [Header("Room Door GameObjects")]
    public GameObject SecondRoomDoor;
    public GameObject ThirdRoomDoor;

    [Header("Windows GameObject")]
    public GameObject RightWindow;

    private RaycastHit rayHit;
    private float rayDistance = 50f;

    private string windowTag = "windowOpen_1st";
    private string secondRoomDoorTag = "Stage_First_Door_1";
    private string thirdRoomDoorTag = "Stage_First_Door_2";


    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (Physics.Raycast(transform.position, transform.forward, out rayHit, rayDistance))
            {
                if (rayHit.collider.CompareTag(windowTag))
                {
                    RightWindow.GetComponent<windowOpen_1st>().PlayAnimation();
                }

                if (rayHit.collider.CompareTag(secondRoomDoorTag))
                {
                    SecondRoomDoor.GetComponent<OpenDoor>().PlayOpenSecondDoor();
                }

                if (rayHit.collider.CompareTag(thirdRoomDoorTag))
                {
                    ThirdRoomDoor.GetComponent<OpenDoor>().PlayOpenThirdDoor();
                }
            }
        }
    }
}
