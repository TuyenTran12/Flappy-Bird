using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float moveRange ;
    public float moveSpeed = 3f;

    private GameObject obj;
    private Vector3 oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Let the background go to the left
        transform.Translate(Vector3.left * Time.deltaTime* moveSpeed);

        //For backgrounds that can be repeated continuously
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.position = oldPosition;
        }
    }
}
