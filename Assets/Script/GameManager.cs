using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// navigation button
    /// </summary>
    [Header("導航button")]public Button navBut;

    /// <summary>
    /// Player
    /// </summary>
    [Header("Player")] public GameObject player;

    /// <summary>
    /// Checkpoint1
    /// </summary>
    [Header("Checkpoint1")] public Dropdown dropdown_1;

    /// <summary>
    /// Checkpoint2
    /// </summary>
    [Header("Checkpoint2")] public Dropdown dropdown_2;

    /// <summary>
    /// 得分
    /// </summary>
    [Header("得分")] public Text souer_on_scene;
    [Header("得分")] public Text souer_on_victory;
    [Header("得分")] public Text souer_on_timesup;

    public float souerData=0;


    /// <summary>
    /// 第一關導航點
    /// </summary>
    public List<GameObject> leve11Point;
   
    /// <summary>
    /// 第二關導航點
    /// </summary>

    public List<GameObject> leve11Point2;

    public static bool Is_navBut; //false

    public static bool leveNav=true;

    // Start is called before the first frame update
    void Start()
    {
        NavButClick();
        dropdown_1.onValueChanged.AddListener(Dropdown_1);
        dropdown_2.onValueChanged.AddListener(Dropdown_2);
    }


    public void SouerEvent()
    {
        souerData += 25;
        souer_on_scene.text = souerData.ToString();
        souer_on_victory.text = souerData.ToString();
        souer_on_timesup.text = souerData.ToString();
    }


    /// <summary>
    /// navigation button event
    /// </summary>
    private void NavButClick()
    {
       navBut.onClick.AddListener(() =>
       {
          if (leveNav)
          {
               dropdown_2.gameObject.SetActive(false);
               Is_navBut = !Is_navBut;

               if (Is_navBut)
               {
                   dropdown_1.gameObject.SetActive(true);
                   player.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(true);
                }
                else
                {
                   dropdown_1.gameObject.SetActive(false);
                   player.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(false);
                }

            }
            else
            {
               Is_navBut = !Is_navBut;

               //dropdown_1.gameObject.SetActive(false);
               if (Is_navBut)
               {
                  dropdown_2.gameObject.SetActive(true);
                  player.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(true);
               }
               else
               {
                  dropdown_2.gameObject.SetActive(false);
                  player.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(false);
               }

           }

       });
    }

    private void Dropdown_1Event(int index)
    {
        if (leve11Point[index] != null)
        {
            player.GetComponent<NavMeshPoint>().point = leve11Point[index];
            player.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(true);
            NavMeshPoint.is_Navigation = true;
            player.GetComponent<NavMeshPoint>().Navheight =0f;
        }
    }
    private void Dropdown_2Event(int index)
    {
        if (leve11Point2[index] != null)
        {
            player.GetComponent<NavMeshPoint>().point = leve11Point2[index];
            player.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(true);
            NavMeshPoint.is_Navigation = true;
            player.GetComponent<NavMeshPoint>().Navheight =0f;
        }
    }

    /// <summary>
    /// dropdown list event
    /// </summary>
    public void Dropdown_1(int Value)
    {
        switch (Value)
        {
            case 0:
                Dropdown_1Event(Value);
                break;
            case 1:
                Dropdown_1Event(Value);
                break;
            case 2:
                Dropdown_1Event(Value);
                break;
            case 3:
                Dropdown_1Event(Value);
                break;
            case 4:
                Dropdown_1Event(Value);
                break;
            case 5:
                Dropdown_1Event(Value);
                break;

            default:
                Dropdown_1Event(0);
                break;
        }
    }   
    
    /// <summary>
    /// dropdown list event 1
    /// </summary>
    public void Dropdown_2(int Value)
    {
        switch (Value)
        {
            case 0:
                Dropdown_2Event(Value);
                break;
            case 1:
                Dropdown_2Event(Value);
                break;
            case 2:
                Dropdown_2Event(Value);
                break;
            case 3:
                Dropdown_2Event(Value);
                break;

            default:
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}
