using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChaScript : MonoBehaviour
{
  //  private Animator anim;
    public Text text;
    public Text name;
    public string info;
    public string NPC;

    public GameObject dialogue;

    void Start()
    {
      //  anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name=="Player")
        {
            dialogue.SetActive(true);
            text.text = info;
            name.text = NPC;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Player")
        {
            dialogue.SetActive(false);
        }
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    anim.SetBool("Run", true);
        //}
        //else
        //{
        //    anim.SetBool("Run", false);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    anim.SetBool("RunLeft", true);
        //}
        //else
        //{
        //    anim.SetBool("RunLeft", false);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    anim.SetBool("RunRight", true);
        //}
        //else
        //{
        //    anim.SetBool("RunRight", false);
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    anim.SetBool("RunBack", true);
        //}
        //else
        //{
        //    anim.SetBool("RunBack", false);
        //}

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    anim.SetBool("Attack", true);
        //}
        //else
        //{
        //    anim.SetBool("Attack", false);
        //}
    }
}
