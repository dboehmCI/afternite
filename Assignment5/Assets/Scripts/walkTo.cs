using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkTo : MonoBehaviour {


    public Transform goal;
    public bool RaceOn;
    Animator anim;

    UnityEngine.AI.NavMeshAgent agent;
    // Use this for initialization

    void Start () {

        anim = GetComponent<Animator>();
       

    }

     private void Update()
    {
        if (!RaceOn)
        {
            return;
        }
        else
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            anim.SetBool("Walk", true);
            agent.destination = goal.position;

        }
        
    }
    private void FixedUpdate()
    {
        if (!RaceOn)
        {
            return;
        }
        else
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            anim.SetBool("Walk", true);
            agent.destination = goal.position;

        }
    }


}
