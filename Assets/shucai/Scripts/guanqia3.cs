using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guanqia3 : MonoBehaviour {
    public GameObject yindao;
    public GameObject BTN;
    public GameObject BTN1;
    public GameObject BTN3;
    public GameObject BTN4;
    public GameObject BTN5;
    public GameObject BTN6;
    public GameObject BTN7;
    public GameObject BTN8;
    public GameObject BTN10;
    public GameObject JL;
    public GameObject D3;
    public GameObject D4;

    public guanqia4 guanqia;
    public int I = 0;


    public bool YIDONG = false;
    public bool YIDONG2 = false;
    public bool YIDONG3 = false;

    private bool anxia;
    private bool anxia1;
    private bool anxia2;

    // Use this for initialization
    void Start()
    {
        guanqia = GameObject.FindGameObjectWithTag("Finish").GetComponent<guanqia4>();
    }

    // Update is called once per frame
    void Update()
    {
        if (YIDONG)
        {
            BTN.transform.Translate(new Vector2(0, -85) * Time.deltaTime);
            BTN5.transform.Translate(new Vector2(0, 85) * Time.deltaTime);
            StartCoroutine(TINGZHI());
        }
        if (YIDONG2)
        {
            BTN6.transform.Translate(new Vector2(0, -85) * Time.deltaTime);
            BTN1.transform.Translate(new Vector2(0, 85) * Time.deltaTime);
            StartCoroutine(TINGZHI2());
        }
        if (YIDONG3)
        {
            BTN4.transform.Translate(new Vector2(100,0) * Time.deltaTime);
            BTN10.transform.Translate(new Vector2(-100, 0) * Time.deltaTime);
            StartCoroutine(TINGZHI3());
        }


        //if (I == 3)
        //{
        //    JL.SetActive(true);
        //}
    }
    public void YINDAO()
    {
        yindao.SetActive(false);
    }
    public void BOTTON()
    {
        if (!anxia)
        {
            anxia = true;
            YIDONG = true;
            I++;
        }
    }
    public void BOTTON1()
    {
        if (!anxia1)
        {
            anxia1 = true;
            YIDONG2 = true;
            I++;
        }
    }
    public void BOTTON2()
    {
        BTN3.SetActive(false);
        BTN7.SetActive(true);
        I++;
    }
    public void BOTTON3()
    {
        if (!anxia2)
        {
            anxia2 = true;
            YIDONG3 = true;
            I++;
        }
    }
    public void JIANGLI()
    {
        D3.SetActive(false);
        D4.SetActive(true);
        guanqia.jishi = true;
    }

    IEnumerator TINGZHI()
    {
        yield return new WaitForSeconds(1f);
        YIDONG = false;
        BTN.SetActive(false);
        BTN10.SetActive(true);

    }
    IEnumerator TINGZHI2()
    {
        yield return new WaitForSeconds(1f);
        YIDONG2 = false;
        BTN1.SetActive(false);
        BTN8.SetActive(true);
    }
    IEnumerator TINGZHI3()
    {
        yield return new WaitForSeconds(1f);
        YIDONG3 = false;
        JL.SetActive(true);
    }
}
