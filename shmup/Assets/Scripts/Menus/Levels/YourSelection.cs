using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharecter = 0;

    // Start is called before the first frame update
    void Start()
    {
        characters[selectedCharecter].SetActive(false);
        int sc = PlayerPrefs.GetInt("selectedCharecter");
        selectedCharecter = sc;
        characters[selectedCharecter].SetActive(true);
    }
}
