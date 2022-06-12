using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    void FixedUpdate()
    {
        if(Menu.isFirst == false)
        {
            Destroy(gameObject);
        }
    }
}
