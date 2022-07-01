using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public GameObject star;
    public GameObject pos;
    public float timer;
    private int countStar = 3;
    private float time;

    public TextMeshProUGUI stars;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        stars.text = "Stars: " + Player.CountStars();
        StartGame();
    }

    public void StartGame()
    {
        int count = GameObject.FindGameObjectsWithTag("Star").Length;
        if (count < countStar & time >= timer)
        {
            Instantiate(star, pos.transform);
            count += 1;
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
