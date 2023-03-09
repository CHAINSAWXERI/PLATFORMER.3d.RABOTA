using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        ChangeScene(2);
    }

    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
