using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public movement playerMovement;
    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag=="obstacle"){
            playerMovement.enabled = false;
            FindObjectOfType<gameManager>().endGame();
        }
    }

}
