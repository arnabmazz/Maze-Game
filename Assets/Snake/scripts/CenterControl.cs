using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CenterControl : MonoBehaviour
{
    public Move1 snake;
    public FoodSpawner foodspowner;
    public GameObject text;
    void Start()
    {
        Time.timeScale = 1;
        text.SetActive(false);
        snake.Onlose += Onlose;
    }
    void Onlose()
    {
       
        text.SetActive(true);
        Time.timeScale = 0;
    }
}