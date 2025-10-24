using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guanqia4 : MonoBehaviour {

    public GameObject yindao;
    public GameObject BTN;
    public GameObject BTN1;
    public GameObject BTN2;
    public GameObject BTN3;
    public GameObject BTN4;
    public GameObject BTN5;
    public GameObject BTN6;
    public GameObject BTN7;
    public GameObject BTN8;
    public GameObject BTN9;
    public GameObject BTN10;
    public GameObject BTN11;
    public GameObject BTN12;
    public GameObject BTN13;

    public GameObject SL;
    public GameObject SB;

    public int I = 0;

    public bool YIDONG = false;
    public bool YIDONG2 = false;

    public bool YIDONG3 = false;
    public bool YIDONG4 = false;

    public bool YIDONG5 = false;
    public bool YIDONG6 = false;

    private float timer;
    public Image image;
    public bool jishi;

    private bool anguo = false;
    private bool anguo1 = false;
    // Use this for initialization
    void Start()
    {
        jishi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (YIDONG)
        {
            BTN6.transform.Translate(new Vector2(0, -85) * Time.deltaTime);
            BTN4.transform.Translate(new Vector2(0, 85) * Time.deltaTime);
            StartCoroutine(TINGZHI());
           
        }
        if (YIDONG2)
        {
            BTN9.transform.Translate(new Vector2(0, -85) * Time.deltaTime);
            BTN5.transform.Translate(new Vector2(0, 85) * Time.deltaTime);
            StartCoroutine(TINGZHI2());
           
        }

        if (jishi)
        {
            timer += Time.deltaTime;
        }
        image.fillAmount = (15-timer) / 15f;
        if (timer < 15)
        {
            if (YIDONG3&&YIDONG4&&YIDONG5&&YIDONG6)
            {
                SL.SetActive(true);
                jishi = false;
            }
        }
        if (timer >= 15)
        {
            SB.SetActive(true);
        }
    }
    public void YINDAO()
    {
        yindao.SetActive(false);
    }
    public void BOTTON()
    {
        BTN.SetActive(false);
        BTN11.SetActive(true);

        YIDONG5=true;
    }
    public void BOTTON1()
    {
      
     
      
    }
    public void BOTTON2()
    {
        BTN2.SetActive(false);
        BTN10.SetActive(true);
      
       YIDONG6=true;
    }
    public void BOTTON3()
    {
       
      
       
    }
    public void BOTTON4()
    {
        if (!anguo)
        {
            anguo = true;
            YIDONG = true;
        }
       
    }
    public void BOTTON5()
    {
        if (!anguo1)
        {
            anguo1 = true;
            YIDONG2 = true;
        }
       
    }
    IEnumerator TINGZHI()
    {
        yield return new WaitForSeconds(1f);
        YIDONG = false;
        BTN4.SetActive(false);
        BTN12.SetActive(true);
        YIDONG3 = true;
    }
    IEnumerator TINGZHI2()
    {
        yield return new WaitForSeconds(1f);
        YIDONG2 = false;
        BTN5.SetActive(false);
        BTN13.SetActive(true);
        YIDONG4 = true;
    }

}
