using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Pipe : MonoBehaviour
{   
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
