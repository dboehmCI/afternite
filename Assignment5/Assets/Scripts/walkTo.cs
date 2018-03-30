using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkTo : MonoBehaviour {

    public int playerNpcChoice;
    public Transform dragon, chicken, condor;
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

            if (playerNpcChoice == 1)
            {
                agent.destination = dragon.position;
            }

            else if (playerNpcChoice == 2)
            {
                anim.SetBool("Walk", true);
                agent.destination = chicken.position;
            }
            else if (playerNpcChoice == 3)
            {
                agent.destination = condor.position;
            }
        }
        
      
    }



}
