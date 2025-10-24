using System.Collections;
using System.Collections.Generic;
using UnityChan;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public GameObject victory;
    public Timer timer;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name=="Player")
        {
            victory.SetActive(true);
            NavMeshPoint.is_Navigation = false;
            timer.is_timer = false;
            other.transform.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(false);
            GameManager.leveNav = true;
        }
    }
}
