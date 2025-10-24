using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class NavMeshPoint : MonoBehaviour
{
    private NavMeshAgent _navPlayer;

    private NavMeshPath _navPath;

    public LineRenderer lineGameObject;
    public GameObject point;

    public  float Navheight=0f;

   public static bool is_Navigation=false;


    // Start is called before the first frame update
    void Start()
    {
        _navPlayer = transform.GetComponent<NavMeshAgent>();

        _navPath = new NavMeshPath();
    }

    bool is_Click;
    public  void Openis_Navigation()
    {
        is_Click = !is_Click;
        if(is_Click)
           is_Navigation = true;
        else
            is_Navigation = false;

        if (is_Navigation)
            lineGameObject.gameObject.SetActive(true);
        else
            lineGameObject.gameObject.SetActive(false);



    }

    public void Close_Navigation()
    {
        is_Navigation = false;
    }

    public void Quit()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

        Debug.Log("Quit Edit Game");

#else

            Application.Quit();

          

#endif
    }

    public void Starts()
    {
        SceneManager.LoadScene("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (is_Navigation)
        {

            _navPlayer.CalculatePath(point.transform.position, _navPath);

            if (_navPath.corners.Length < 2)

                return;

            else
            {

                lineGameObject.positionCount = _navPath.corners.Length;
                Vector3[] tmpCorners = _navPath.corners;

                for (int i = 0; i < tmpCorners.Length; i++)
                {

                    tmpCorners[i].y += Navheight;

                }

                lineGameObject.SetPositions(tmpCorners);
            }
        }
    }
}
