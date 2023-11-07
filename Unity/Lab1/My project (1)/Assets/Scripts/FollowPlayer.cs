using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <Summary>
/// This class will move the camera to follow the player
/// </Summary>

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,6,-7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Camera follows the player with specified offset position
        transform.position = player.transform.position + offset;
    }
}
