using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class annniu2 : MonoBehaviour
{
    public Vector3 vec;
   
	// Start is called before the first frame update
	void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

	// Update is called once per frame
	public void baocunweizhi()
    {
        vec = GameObject.Find("Player").transform.position;
    }
    public void jiazaiweizhi()
    {
        GameObject.Find("Player").transform.position=vec;
    }
}
