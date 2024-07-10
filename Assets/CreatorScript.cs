using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorScript : MonoBehaviour
{
    public GameObject MyBallGameObject;
    public Vector3 MyInstantiatePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(MyBallGameObject, MyInstantiatePosition, Quaternion.identity);
        }
    }
}
