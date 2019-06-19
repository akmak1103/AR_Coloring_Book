using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    public GameObject anim;
    public void playAni()
    {
        Animator ani = anim.GetComponent<Animator>();
        ani.SetInteger("dino",1);
    }
}
