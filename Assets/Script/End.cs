using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    /// <summary>
    /// Checkpoint1
    /// </summary>
    [Header("Checkpoint1")] public Dropdown dropdown_1;

    /// <summary>
    /// Checkpoint2
    /// </summary>
    [Header("Checkpoint2")] public Dropdown dropdown_2;

    /// <summary>
    /// Player
    /// </summary>
    [Header("Player")] public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        {
            NavMeshPoint.is_Navigation = false;
            other.transform.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(false);
            GameManager.leveNav = false;
            GameManager.Is_navBut= false;
            dropdown_1.gameObject.SetActive(false);
            dropdown_2.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
