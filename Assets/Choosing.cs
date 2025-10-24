using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{   public GameObject girl;
    public GameObject boy;
    // Start is called before the first frame update
    void Start()
    {
        girl.SetActive(false);
    }

    void Next(){
        girl.SetActive(true);
        boy.SetActive(false);
    }
     void Previous(){
        girl.SetActive(true);
        boy.SetActive(false);
    }
}
