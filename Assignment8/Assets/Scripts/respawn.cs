using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour {


    private bool checkpointCollide = false;
    private bool showSavemsg = true;
    public static int levelN = 0;

    private Vector3 startPos;
    private Quaternion startRot;


    public GameObject Interact;
   

    private void Awake()
    {
        Interact.SetActive(false);
    }

     void Update()
    {
        if (checkpointCollide)
        {
            if (showSavemsg)
            Interact.SetActive(true);

                if (Input.GetKeyDown(KeyCode.F))
                {
                    showSavemsg = false;
                    Interact.SetActive(false);
                }
            
        }
    }
    // Use this for initialization
    void Start () {

        startPos = transform.position;
        startRot = transform.rotation;

	}

    private void OnTriggerStay(Collider col)
    {
       if  (showSavemsg == false)
        {
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        checkpointCollide = false;
      
        Interact.SetActive(false);
     
    }
    // Update is called once per frame
    void OnTriggerEnter (Collider col) {

        if (col.tag == "death")
        {
            transform.position = startPos;
            transform.rotation = startRot;

            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        }
        else if(col.tag == "checkpoint")
        {
               

            checkpointCollide = true;

    

        }
        else if(col.tag =="thirdPersonGoal")
        {
           
            Destroy(col.gameObject);
            GetComponent<Animator>().Play("WIN00", -1, 0f);
           
        }
    }
  
}
