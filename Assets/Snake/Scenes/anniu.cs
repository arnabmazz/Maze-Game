using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anniu : MonoBehaviour {



	public string ll = "she";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void jinyouxi()
    {
        SceneManager.LoadScene(ll);
		GameObject.FindGameObjectWithTag("wz").GetComponent<annniu2>().baocunweizhi();
		//Application.LoadLevelAdditive("she");
		//cj.SetActive(false);
		//anniu111.SetActive(true);
		//ll =Instantiate(she);
		//PlayerPrefs.SetFloat("tx", player.position.x);
		//PlayerPrefs.SetFloat("ty", player.position.y);
		//PlayerPrefs.SetFloat("tz", player.position.z);
	}
    public void hiuyouxi()
    {
		  SceneManager.LoadScene("Maze");
		Time.timeScale = 1;
		//Application.UnloadLevel("she");
		//anniu111.SetActive(false);
		//cj.SetActive(true);
		//Destroy(ll);
	}


}
