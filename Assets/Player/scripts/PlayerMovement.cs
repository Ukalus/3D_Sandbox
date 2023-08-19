using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 10.0f;
    private Transform playerTransform;
    

    // Get a direction vector;
    private Vector3 calcDirection(){
        return new Vector3(
            Input.GetAxis("Horizontal"),
            (Input.GetKey(KeyCode.LeftShift) ?  -1 : Input.GetAxis("Jump") ),
            Input.GetAxis("Vertical")
        );
    }

    // Apply direction vector
    private void move(Transform transform , Vector3 direction){
                                               // Deltatime for right framerate
        transform.position += direction * speed * Time.deltaTime; 
    }


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       move(playerTransform, calcDirection());
        
    }
}
