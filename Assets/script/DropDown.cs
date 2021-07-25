using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void GoingUp()
	{
        anim.SetBool("goDown", false);
        anim.SetBool("GoUp", true);
    }

    public void GoDown()
    {
        anim.SetBool("GoUp", false);
        anim.SetBool("goDown", true);
     }
}
