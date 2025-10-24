using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
public class Move1 : MonoBehaviour
{
    public GameObject TailPrefab;
    public float speed = 0.3f;
    public Action Onlose;
    public FoodSpawner FSP;

    private Vector2 dir = 20 * Vector2.right;
    private List<Transform> tail = new List<Transform>();
    private bool ate;
    public GameObject shang;
    public GameObject zuo;
    public GameObject xia;
    public GameObject you;

    void Start()
    {
        InvokeRepeating("move", speed, speed);
    }
    void move()
 
 {
Vector2 position = transform.position;
    transform.Translate(dir);
    if (ate)
   {
            //吃到食物长长身体
      GameObject body = (GameObject)Instantiate(TailPrefab, position,
Quaternion.identity);
         //   body.transform.parent = GameObject.FindGameObjectWithTag("she").transform;
            tail.Insert(0, body.transform);
      ate = false;
   }
    else if (tail.Count > 0)
   {
      tail.Last().position = position;
      tail.Insert(0, tail.Last());
      tail.RemoveAt(tail.Count - 1);
   }
}
  void Update()
{
        //蛇移动
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (v > 0 && dir != 20 * Vector2.down)
        {
            dir = 20 * Vector2.up;
            zuo.SetActive(false);
            shang.SetActive(true);
            you.SetActive(false);
            xia.SetActive(false);
        }
        if (v < 0 && dir != 20 * Vector2.up)
        {
            dir = 20 * Vector2.down;
            zuo.SetActive(false);
            shang.SetActive(false);
            you.SetActive(false);
            xia.SetActive(true);
        }
        if (h > 0 && dir != 20 * Vector2.left)
        {
            dir = 20 * Vector2.right;
            zuo.SetActive(false);
            shang.SetActive(false);
            you.SetActive(true);
            xia.SetActive(false);
        }
        if (h < 0 && dir != 20 * Vector2.right)
        {
            dir = 20 * Vector2.left;
            zuo.SetActive(true);
            shang.SetActive(false);
            you.SetActive(false);
            xia.SetActive(false);
        }
}
void OnTriggerEnter2D(Collider2D coll)
{
    if (coll.name.StartsWith("food"))
    {
        ate = true;
        FSP.Spawn();
        Destroy(coll.gameObject);
    }
    else
    {
        if (Onlose != null)
            Onlose();
    }
        Debug.Log(coll.name);
}
}