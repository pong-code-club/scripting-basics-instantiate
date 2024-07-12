using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody MyRidgidbody;
    public Vector3 MyForceVector3;
    public ForceMode MyForceMode;

    // Start is called before the first frame update
    void Start()
    {
        MyRidgidbody.AddForce(MyForceVector3, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
