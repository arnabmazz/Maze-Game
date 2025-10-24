using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guanqia2 : MonoBehaviour {

    public GameObject yindao;
    public GameObject BTN;
    public GameObject BTN1;
    public GameObject BTN3;
    public GameObject BTN4;
    public GameObject BTN5;
    public GameObject BTN6;
    public GameObject BTN7;
    public GameObject BTN8;
    public GameObject BTN9;

    public GameObject JL;
    public GameObject D2;
    public GameObject D3;

    public int I = 0;

    public bool YIDONG = false;
    public bool YIDONG2 = false;

     public bool YIDONG3 = false;
    public bool YIDONG4= false;
    private bool anguo = false;
    private bool anguo1 = false;
    // Use this for initialization
    void Start()
    {

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
            BTN1.transform.Translate(new Vector2(-100, 0) * Time.deltaTime);
            BTN6.transform.Translate(new Vector2(100, 0) * Time.deltaTime);
            StartCoroutine(TINGZHI2());
           
        }



        if (YIDONG3&&YIDONG4)
        {
            StartCoroutine(xianshi());
        }
    }
    public void YINDAO()
    {
        yindao.SetActive(false);
    }
    public void BOTTON()
    {
        if (!anguo)
        {
            anguo = true;
            YIDONG = true;
            I++;
        }
    }
    public void BOTTON1()
    {
        if (!anguo1)
        {
            anguo1 = true;
            YIDONG2 = true;
            I++;
        }
    }
    public void BOTTON2()
    {
        BTN3.SetActive(false);
        BTN7.SetActive(true);
     //   I++;
    }
    public void BOTTON3()
    {
       
       
       // I++;
    }
    public void JIANGLI()
    {
        D2.SetActive(false);
        D3.SetActive(true);
    }
    IEnumerator TINGZHI()
    {
        yield return new WaitForSeconds(1f);
        YIDONG = false;
        BTN9.SetActive(true);
        BTN3.SetActive(false);
        YIDONG3 = true;
    }
    IEnumerator TINGZHI2()
    {
        yield return new WaitForSeconds(1f);
        YIDONG2 = false;
        BTN8.SetActive(true);
        BTN4.SetActive(false);
        YIDONG4 = true;
    }
    IEnumerator xianshi()
    {
        yield return new WaitForSeconds(1f);
        JL.SetActive(true);
    }
}
