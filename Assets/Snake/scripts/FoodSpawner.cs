using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FoodSpawner : MonoBehaviour
{
   
    public GameObject Food;
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;
    public float time = 1;
    void Start()
    {
        // InvokeRepeating("Spawn", time - 1, time);
        Spawn();
    }
   public void Spawn()
    {
        int x = (int)Random.Range((int)borderLeft.position.x + 20,
        (int)borderRight.position.x) / 20 * 20;
        int y = (int)Random.Range((int)borderBottom.position.y + 20,
        (int)borderTop.position.y) / 20 * 20;
       GameObject sw= Instantiate(Food, new Vector2(x, y), Quaternion.identity);
      //  sw.transform.parent = GameObject.FindGameObjectWithTag("she").transform;
    }
}