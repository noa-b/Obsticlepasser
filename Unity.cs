using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
      //the vehicle moves in: x, y, z  
        //transform.Translate(0, 0, 1);

        // A more anderstandeble version of the privius line.
        transform.Translate(Vector3.forward * Time.deltaTime * 20 );

    }
}
