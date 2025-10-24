using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRot : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name=="Player")
        {
            NavMeshPoint.is_Navigation = false;
            other.transform.GetComponent<NavMeshPoint>().lineGameObject.gameObject.SetActive(false);
            GameObject.Find("GameManager").gameObject.GetComponent<GameManager>().SouerEvent();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.position, speed*Time.deltaTime);
    }
}
