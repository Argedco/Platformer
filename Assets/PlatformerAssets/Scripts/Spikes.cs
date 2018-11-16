using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {


    //Unity calls this function when our spikes touch any other object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the collision was the player (aka has a Player Script)
        Player playerScript = collision.collider.GetComponent<Player>();
        //only do something if it WAS the player
        if (playerScript != null)
        {
            //We DID hit the player.
            //Kill them
            playerScript.Kill();

        }

    }
}
