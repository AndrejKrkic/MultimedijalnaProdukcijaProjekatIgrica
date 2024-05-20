using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public Transform startPos;
    public GameObject player;
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("MRtav si");
    //    SceneManager.LoadScene(0);
    //    //player.transform.position = startPos.position;
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("MRtav si");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
