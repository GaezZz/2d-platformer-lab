using System;
using Unity.VisualScripting;
using UnityEngine;

public class CharacMovement : MonoBehaviour
{

    public Rigidbody2D character;

    public float characterVelocity; //velocidad del pj
    public float jumpForce; //fuerza del salto
    private Boolean isGrounded; //ir viendo si toco el suelo


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        characterMove();
        characterJump();

    }


    private void characterMove(){ //movimiento del personaje

        if (Input.GetKey(KeyCode.RightArrow)){
            gameObject.transform.position += Vector3.right * characterVelocity * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            gameObject.transform.position += Vector3.left * characterVelocity * Time.deltaTime;
        }
    }

    private void characterJump(){ //salto del pj


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true){ //cambio la velocidad que sube y miro si no esta saltando ya
            character.linearVelocity = new Vector3(0,jumpForce,0);
            isGrounded = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //le especifico el collision para decirle que es contra lo que choco lo que quiero mirar su capa
        if (collision.gameObject.layer == 3){
            isGrounded = true;
            Debug.Log(collision.gameObject.name); 
        }
            
        
    }
}
