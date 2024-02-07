using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private Vector3 offset = new Vector3(10, 0, 0);
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
