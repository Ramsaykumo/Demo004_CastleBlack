using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour {

    public NavMeshAgent agent;
    public Animator anim;
    public ETCJoystick joy;
	void Update () {
        
        
	}

    public void MoveAnimStart()
    {
        anim.SetFloat("HeroSpeed", joy.tmSpeed);
    }

    public void MoveAnimEnd()
    {
        anim.SetFloat("HeroSpeed", 0);
    }
}
