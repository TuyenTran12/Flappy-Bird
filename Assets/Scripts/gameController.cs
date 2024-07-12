using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    int point = 0;
    public Text txtPoint;

    public bool isEndGame, isStartGame = false; // Cho biết đã Start hoặc End game chưa
    public GameObject btnStartGame, imgEndGame,btnEndGame; // Các UI
    // Start is called before the first frame update
    void Start()
    {
        isEndGame = false;
        //isStartGame = false;
        btnStartGame.SetActive(true);
        imgEndGame.SetActive(false);
        btnEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        isStartGame = true;
        btnStartGame.SetActive(false);
    }
    public void EndGame()
    {
        isEndGame = true;
        Time.timeScale = 0;
        imgEndGame.SetActive(true);
        btnEndGame.SetActive(true);
    }
    public void CountPoint()
    {
        point++;
        txtPoint.text = "POINT: " + point.ToString();
    }
    public void ReStartGame()
    {
        SceneManager.LoadScene(0);
    }
}
