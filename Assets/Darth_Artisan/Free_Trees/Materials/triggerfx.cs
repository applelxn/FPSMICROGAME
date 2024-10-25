using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX_trigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
    }


}
