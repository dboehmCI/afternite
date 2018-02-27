using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
    public Transform player;
    static Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		

        if (Vector3.Distance(player.position, this.transform.position) < 5) // Determines if NPC Sees Player
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("Walk", true);

            if (direction.magnitude > 4) // Moves NPC to Player
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("Walk", true);
                
            }
            else
            {
               
                anim.SetBool("Walk", false);
            }

        }
        else
        {
            anim.SetBool("Walk", false);
        }

	}
}
