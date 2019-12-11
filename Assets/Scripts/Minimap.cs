using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{

    public Transform player;

    // LateUpdate for following the players position AFTER players transform position
    void LateUpdate()
    {

        // Minimap Camera follows the player
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        // Minimap Rotation (Delete the "//" below, if rotation should be applied)
        // transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }





}