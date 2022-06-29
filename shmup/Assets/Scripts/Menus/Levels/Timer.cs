using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float startingTime = 40f;
    [SerializeField] float currentTime = 0f;

    public Text countdownText;

    private int nextSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        countdownText.text = currentTime.ToString("0");

        //print (currentTime);
        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}
