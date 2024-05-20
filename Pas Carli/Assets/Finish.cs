using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public int level;
    //public Transform[] startPoints;
    //public GameObject player;

    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("END");
        //player.transform.position = startPoints[level].position;
        SceneManager.LoadScene(level);

    }

}
