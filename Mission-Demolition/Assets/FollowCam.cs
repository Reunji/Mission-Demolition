using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    [Header("Set in Inspector")]
    public float easing = 0.05f;
    static public GameObject POI;
    [Header("Set Dynamically")]
    public float camZ;
    void Awake()
    {
    camZ = this.transform.position.z;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
    if(POI==null)return;
    Vector3 destination = POI.transform.position;
    destination = Vector3.Lerp(transform.position, destination, easing);
    destination.z = camZ;
    transform.position = destination;
    }
}
