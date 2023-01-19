using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 3f;

    
    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(player.position.x, player.position.y, -10f);
        //Vector3.Slerp is a method that "spherically interpolates between two vectors"
        transform.position = Vector3.Slerp(transform.position, newPosition, followSpeed * Time.deltaTime);
    }
}
