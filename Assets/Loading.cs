using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadSceneAsync("Demo", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
    }
}