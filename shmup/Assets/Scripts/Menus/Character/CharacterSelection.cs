using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharecter = 0;

    public void NextCharacter()
    {
        characters[selectedCharecter].SetActive(false);
        selectedCharecter = (selectedCharecter + 1) % characters.Length;
        characters[selectedCharecter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharecter].SetActive(false);
        selectedCharecter--;
        if (selectedCharecter < 0)
        {
            selectedCharecter += characters.Length;
        }
        characters[selectedCharecter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharecter", selectedCharecter);
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
}
