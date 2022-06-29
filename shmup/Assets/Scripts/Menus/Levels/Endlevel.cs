using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endlevel : MonoBehaviour
{
    private int nextSceneToLoad;

    public float nextFire = 10.0f;
    public float currentTime = 0.0f;

    public GameObject completeLevelUI;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > nextFire)
        {
            nextFire += currentTime;

            SceneManager.LoadScene(nextSceneToLoad);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}