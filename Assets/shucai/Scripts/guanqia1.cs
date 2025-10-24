using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guanqia1 : MonoBehaviour {

    public GameObject yindao;
    public GameObject BTN;
    public GameObject BTN1;
    public GameObject BTN3;
    public GameObject BTN4;
    public GameObject JL;
    public GameObject D1;
    public GameObject D2;

    public int I = 0;

    public bool YIDONG=false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (YIDONG)
        {
            BTN1.transform.Translate(new Vector2(0, -85)*Time.deltaTime); // change moving path
            BTN3.transform.Translate(new Vector2(0, 85) * Time.deltaTime);
            StartCoroutine(TINGZHI());
        }


        if (I == 2)
        {
            JL.SetActive(true);
        }
    }
   public void YINDAO()
    {
        yindao.SetActive(false);
    }
    public void BOTTON()
    {
       // BTN.SetActive(false);
        //BTN3.SetActive(true);
        I++;
    }
    public void BOTTON1()
    {
        // BTN1.SetActive(false);
        // BTN4.SetActive(true);
        YIDONG = true;
        I++;
    }
    public void JIANGLI()
    {
        D1.SetActive(false);
        D2.SetActive(true);
    }
    IEnumerator TINGZHI()
    {
        yield return new WaitForSeconds(1f);
        YIDONG = false;
    }

}
