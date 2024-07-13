using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rgbd2D;

    public float upBird = 2f;

    GameObject GC; // GameController
    GameObject Audio;

    [SerializeField] private float rotationSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        rgbd2D = GetComponent<Rigidbody2D>();
        GC = GameObject.FindGameObjectWithTag("GameController");
        Audio = GameObject.FindGameObjectWithTag("Audio");
    }

    // Update is called once per frame
    void Update()
    {
        //When you click the mouse, the player will fly up
        if (Input.GetMouseButton(0))
        {
            if (!GC.GetComponent<gameController>().isEndGame && GC.GetComponent<gameController>().isStartGame)
            {
                GC.GetComponent<gameController>().PlayGame();
                rgbd2D.velocity = new Vector2(0, upBird);
                Audio.GetComponent<Sound>().PlaySound(Audio.GetComponent<Sound>().Flap);
            }
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rgbd2D.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GC.GetComponent<gameController>().EndGame();
        Audio.GetComponent<Sound>().PlaySound(Audio.GetComponent<Sound>().Hit);
        Audio.GetComponent<Sound>().PlaySound(Audio.GetComponent<Sound>().Die);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GC.GetComponent<gameController>().CountPoint();
        Audio.GetComponent<Sound>().PlaySound(Audio.GetComponent<Sound>().Point);
    }
    
}
