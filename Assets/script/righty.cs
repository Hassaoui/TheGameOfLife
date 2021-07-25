using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class righty : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void GoingRight()
    {
        anim.SetBool("goingLeft", false);
        anim.SetBool("goingRight", true);
    }

    public void GoingLeft()
    {
        anim.SetBool("goingRight", false);
        anim.SetBool("goingLeft", true);
    }
}
