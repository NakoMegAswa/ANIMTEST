using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;
    float speed = 5.0f;
    Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
       if( Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("isStrafe", true);
        }

       if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isStrafe", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
            playerAnim.SetBool("isStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("isStrafe", false);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("trigAttack");
        }


         void OnCollisionEnter(Collision collision)

        {
            if(collision.gameObject.CompareTag("Cube"))
            {
                speed = 0;
            }
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    playerAnim.SetBool("isAttack", true);
       // }

      //  if(Input.GetKeyUp(KeyCode.Space))
       // {
        //    playerAnim.SetBool("isAttack", false);
        //}
    }
}
