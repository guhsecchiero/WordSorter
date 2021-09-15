using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI[] levelTexts;
    int[] checkLevelComplete = new int[10];

    public void LoadFaseOne()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadFaseTwo()
    { 
        SceneManager.LoadScene(2);
    }
    public void LoadFaseThree()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadFaseFour()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadFaseFive()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadFaseSix()
    {
        SceneManager.LoadScene(6);
    }
    public void LoadFaseSeven()
    {
        SceneManager.LoadScene(7);
    }
    public void LoadFaseEight()
    {
        SceneManager.LoadScene(8);
    }
    public void LoadFaseNine()
    {
        SceneManager.LoadScene(9);
    }
    public void LoadFaseTen()
    {
        SceneManager.LoadScene(10);
    }
    public void Close()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void TryAgain()
    {
        int openScene;
        openScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(openScene);
    }

    public void LoadProgress()
    {
        LevelData data = SaveSystem.LoadLevel();

        if (data.levelIndex == 1)
            checkLevelComplete[0] = data.levelIndex;
        if (data.levelIndex == 2)
            checkLevelComplete[1] = data.levelIndex;
        if (data.levelIndex == 3)
            checkLevelComplete[2] = data.levelIndex;
        if (data.levelIndex == 4)
            checkLevelComplete[3] = data.levelIndex;
        if (data.levelIndex == 5)
            checkLevelComplete[4] = data.levelIndex;
        if (data.levelIndex == 6)
            checkLevelComplete[5] = data.levelIndex;
        if (data.levelIndex == 7)
            checkLevelComplete[6] = data.levelIndex;
        if (data.levelIndex == 8)
            checkLevelComplete[7] = data.levelIndex;
        if (data.levelIndex == 9)
            checkLevelComplete[8] = data.levelIndex;
        if (data.levelIndex == 10)
            checkLevelComplete[9] = data.levelIndex;
    }

    public void Play()
    {
        if (checkLevelComplete[0] == 1)
            levelTexts[0].color = Color.green;
        if (checkLevelComplete[1] == 2)
            levelTexts[1].color = Color.green;
        if (checkLevelComplete[2] == 3)
            levelTexts[2].color = Color.green;
        if (checkLevelComplete[3] == 4)
            levelTexts[3].color = Color.green;
        if (checkLevelComplete[4] == 5)
            levelTexts[4].color = Color.green;
        if (checkLevelComplete[5] == 6)
            levelTexts[5].color = Color.green;
        if (checkLevelComplete[6] == 7)
            levelTexts[6].color = Color.green;
        if (checkLevelComplete[7] == 8)
            levelTexts[7].color = Color.green;
        if (checkLevelComplete[8] == 9)
            levelTexts[8].color = Color.green;
        if (checkLevelComplete[9] == 10)
            levelTexts[9].color = Color.green;
    }
}
