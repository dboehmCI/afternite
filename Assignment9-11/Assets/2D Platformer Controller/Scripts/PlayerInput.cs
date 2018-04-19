using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        


        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.I))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingRight", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingLeft", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Run", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Jump", false);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.I))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingRight", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingLeft", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Run", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Jump", false);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingRight", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingLeft", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Run", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Jump", false);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingRight", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingLeft", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Run", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Jump", false);


        }
        else if (Input.GetButtonDown("Jump"))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingRight", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingLeft", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Run", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Jump", true);
            player.OnJumpInputDown();



        }
        else if (Input.GetButtonUp("Jump"))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingRight", true);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("facingLeft", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Run", false);
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Jump", false);

        }
        else
        {
 
                GameObject.Find("Player").GetComponent<Animator>().SetBool("Walk", false);
                GameObject.Find("Player").GetComponent<Animator>().SetBool("Idle", true);
            

        }
                

     

   


    }
}
