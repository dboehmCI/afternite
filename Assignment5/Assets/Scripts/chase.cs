using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
    public Transform player;
    Animator anim;
    public Transform head;


    string state = "Walk";

    public GameObject[] waypoints;
    int currentWP = 0;
    public float rotSpeed = 0.2f;
    public float obsRotate = 0.5f;
    public float speed = 1.5f;
    float accuracyWP = 5.0f;
    private bool obstacle = false;
    private RaycastHit hit;
    private int range;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        range = 80;

	}
	
   
	// Update is called once per frame
	void Update () {
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
        float angle = Vector3.Angle(direction, head.up);
        if (!obstacle)
        {
           
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);

            if (state == "Walk" && waypoints.Length > 0)
            {

                anim.SetBool("Walk", true);
                if (Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracyWP)
                {
                    currentWP = Random.Range(0, waypoints.Length);

                    /*
                    currentWP++;
                    if (currentWP >= waypoints.Length)
                    {
                        currentWP = 0;

                    } */
                }

                //rotate towards waypoint


                direction = waypoints[currentWP].transform.position - transform.position;
                this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
                this.transform.Translate(0, 0, Time.deltaTime * speed);
            }
        }
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Transform leftRay = this.transform;
        Transform rightRay = this.transform;

        if (Physics.Raycast(leftRay.position + (this.transform.right * 7), this.transform.forward, out hit, range) || Physics.Raycast(rightRay.position - (this.transform.right * 7), this.transform.forward, out hit, range))
        {
            if (hit.collider.gameObject.CompareTag("tree"))
            {
                obstacle = true;
                this.transform.Rotate(Vector3.up * Time.deltaTime * obsRotate);
            }
        }

        if (Physics.Raycast(this.transform.position - (this.transform.forward * 4), this.transform.right, out hit, 10) ||
                                        Physics.Raycast(this.transform.position - (this.transform.forward * 4), -this.transform.right, out hit, 10))
        {
            if (hit.collider.gameObject.CompareTag("tree"))
            {
                obstacle = false;
            }
        }

        if (Vector3.Distance(player.position, this.transform.position) < 10 && (angle < 30 || state == "Idle")) // Determines if NPC Sees Player
        {
            state = "Idle";
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);


            if (direction.magnitude > 5) // Moves NPC to Player
            {
                this.transform.Translate(0, 0, Time.deltaTime * speed);
                anim.SetBool("Walk", true);
            }
            else
            { 
                anim.SetBool("Walk", false);
            }

        }
        else
        {
            anim.SetBool("Walk", true);
            state = "Walk";
        }

        if (Vector3.Distance(player.position, this.transform.position) < 2 && Input.anyKeyDown)
        {
            walkTo();
        }
        

    }

    public Transform goal;
    bool RaceOn = false;

    // Use this for initialization
    void walkTo()
    {


       
            UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.destination = goal.position;
        

    }
}


