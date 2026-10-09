using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public KeyCode spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundcheck;
    public float groundcheckradius;
    public LayerMask WhatIsGround;
    private bool grounded;
    void Start()
    {
       
    }

   
    void Update()
    {

         if(Input.GetKeyDown(spacebar)&& grounded){
            Jump();
         }

if (Input.GetKey(L)){
    GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);

    if(GetComponent<SpriteRenderer>()!=null){
        GetComponent<SpriteRenderer>().flipX = true;
    }
}

if (Input.GetKey(R)){
    GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);

        if(GetComponent<SpriteRenderer>()!=null){
        GetComponent<SpriteRenderer>().flipX = false;
    }
    }
}

void Jump(){
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
}

void FixedUpdate()
{
    grounded = GetComponent<Collider2D>().IsTouchingLayers(WhatIsGround);
}
void OnDrawGizmosSelected()
{
    if (groundcheck != null)
        Gizmos.DrawWireSphere(groundcheck.position, groundcheckradius);
}
}
