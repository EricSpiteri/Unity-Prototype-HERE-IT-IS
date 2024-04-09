
using UnityEngine;


public class PlayerControls : MonoBehaviour{

//declaring physics variables and assigning their values
public float speed = 8;
public float jumpforce = 15;

//declaring RigidBody
private Rigidbody playerRb;

//intitialising

void Start(){
    
    //fetching Rigidbody
    playerRb = GetComponent <Rigidbody> ();

}

//what happens after initialisation

void Update(){

    float vertical = Input.GetAxisRaw("Vertical");
    float horizontal = Input.GetAxisRaw("Horizontal");
    Vector3 direction = new Vector3(horizontal, 0, vertical).normalized * speed;
    direction.y = playerRb.velocity.y;

    playerRb.velocity = direction;

    //Jump Mechanic
    if (Input.GetButtonDown("Jump")){playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);}
}

















}
