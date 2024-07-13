using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class PipesMove : MonoBehaviour
{
    public float moveRange;
    public float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //Give random pipes y coordinates
        transform.position = new Vector3(transform.position.x, Random.Range(-2, 2), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Let the pipes go to the left
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Move pipes to run multiple pipes without creating them
        if (collision.gameObject.tag == "ResetPipe")
        {
            transform.position = new Vector3(transform.position.x + moveRange, Random.Range(-1, 1), 0);
        }
    }


}
