using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;    //  x  y   z  
    private Vector3 offset = new Vector3(1, 7, -21);



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    { 
        // Offsets the cameras position to the vihecle position   
        transform.position = player.transform.position + offset;
    }
}
