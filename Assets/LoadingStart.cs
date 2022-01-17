using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingStart : MonoBehaviour
{
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadSceneAsync("Playground", LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSceneLoad());
    }

    // Update is called once per frame
    void Update()
    {
    }
}