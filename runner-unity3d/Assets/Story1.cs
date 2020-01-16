using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1 : MonoBehaviour
{
    public Fade fade;
    // Start is called before the first frame update
    void Start()
    {
        fade.BeginFade(-1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
