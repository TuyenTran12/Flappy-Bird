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
        //Cho các pipes random toạ độ y
        transform.position = new Vector3(transform.position.x, Random.Range(-2, 2), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Cho các pipes đi về phía bên trái
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Di chuyển các pipes để chạy nhiều pipes không cần tạo
        if (collision.gameObject.tag == "ResetPipe")
        {
            transform.position = new Vector3(transform.position.x + moveRange, Random.Range(-1, 1), 0);
        }
    }

}
