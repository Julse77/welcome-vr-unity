using UnityEngine;

public class CreateNamelist: MonoBehaviour
{
    public GameObject Namelist;
    private string player = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == player)
        {
            Namelist.SetActive(true);
        }
    }
}
