using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_3roomOpenbox : MonoBehaviour
{
    private Animator anim;
    public GameObject room3box;
    public GameObject Taegeukgi1_1;
    public GameObject Taegeukgi2_1;
    public GameObject Taegeukgi3_1;
    public GameObject Taegeukgi4_1;
    
    

    void Update()
    {
        actiavateture();
    }

    void actiavateture()
    {
        if (Taegeukgi1_1.activeSelf == true)
        {
            if(Taegeukgi2_1.activeSelf == true)
            {
                if (Taegeukgi3_1.activeSelf == true)
                {
                    if (Taegeukgi4_1.activeSelf == true)
                    {
                        Invoke("openbox", 2f);
                        
                    }
                }
            }
        }

    }

    void openbox()
    {
        anim = this.room3box.GetComponent<Animator>();
        anim.Play("2st_3roomboxopen");
    }

}
