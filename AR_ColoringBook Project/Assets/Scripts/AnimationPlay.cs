using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    public GameObject anim,environment;
    public void playAni()
    {
        Animator ani = anim.GetComponent<Animator>();
        ani.enabled=true;
        environment.SetActive(true);
    }
}
