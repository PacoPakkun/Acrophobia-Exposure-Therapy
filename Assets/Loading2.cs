using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading2 : MonoBehaviour
{
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadSceneAsync("Mountain", LoadSceneMode.Single);
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
