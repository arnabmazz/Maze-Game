using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiaozhuan : MonoBehaviour {
    public GameObject kaishi;
    public GameObject guanqia;
    public GameObject DY;
    public GameObject DE;
    public GameObject DS;
    public GameObject D4;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void KaiShi()
    {
       kaishi.SetActive(false);
        guanqia.SetActive(true);
        DY.SetActive(false);
        DE.SetActive(false);
        DS.SetActive(false);
        D4.SetActive(false);
    }
    public void DIYIGUAN()
    {
        kaishi.SetActive(false);
        guanqia.SetActive(false);
        DY.SetActive(true);
        DE.SetActive(false);
        DS.SetActive(false);
        D4.SetActive(false);
    }
    public void DIERGUAN()
    {
        kaishi.SetActive(false);
        guanqia.SetActive(false);
        DY.SetActive(false);
        DE.SetActive(true);
        DS.SetActive(false);
        D4.SetActive(false);
    }
    public void DISANGUAN()
    {
        kaishi.SetActive(false);
        guanqia.SetActive(false);
        DY.SetActive(false);
        DE.SetActive(false);
        DS.SetActive(true);
        D4.SetActive(false);
    }
    public void DISIGUAN()
    {
        kaishi.SetActive(false);
        guanqia.SetActive(false);
        DY.SetActive(false);
        DE.SetActive(false);
        DS.SetActive(false);
        D4.SetActive(true);
    }

}
