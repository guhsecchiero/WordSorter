using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] finalPositions;

    [SerializeField]
    public GameObject[] letters;

    [SerializeField]
    public TextMeshPro[] answers;

    public GameObject victoryScreen;


    int checkFirst;
    int checkSecond;
    int checkThird;
    DragObject dragObject;
    public int activeScene;

    public static GameManager instance;
    bool checking;

    string[,] lettersData = new string[3, 4] { {"U","T","A","T"},
                                               {"","","",""},
                                               {"","","","",} };

    string[,] lettersData2 = new string[3, 5] { {"A","R","O","C","R"},
                                               {"","","","",""},
                                               {"","","","",""} };

    string[,] lettersData3 = new string[3, 6] { {"V","D","I","A","R","E" },
                                                {"","","","","","" },
                                                {"","","","","","" }};

    string[,] lettersData4 = new string[4, 4] { {"A","A","A","O"},
                                               {"C","M","G","T"},
                                               {"","","","",},
                                               {"","","","",} };

    string[,] lettersData5 = new string[4, 5] { {"O","V","I","R","C"},
                                               {"A","A","L","P",""},
                                               {"","","","",""},
                                               {"","","","",""}};

    string[,] lettersData6 = new string[4, 5] { {"E","P","D","A","I"},
                                               {"M","T","I","E","O"},
                                               {"","","","",""},
                                               {"","","","",""}};

    string[,] lettersData7 = new string[5, 4] { {"E","R","I","T" }, 
                                                { "D", "V", "A", "A" }, 
                                                { "R", "M", "A", "O" }, 
                                                { "", "", "", "" }, 
                                                { "", "", "", "" } };

    string[,] lettersData8 = new string[4, 6] { {"X","S","E","D","E","I" },
                                                {"O","F","C","R","","" },
                                                {"","","","","","" },
                                                {"","","","","","" } };

    string[,] lettersData9 = new string[4, 6] { {"R","O","R","S","U","M" },
                                                {"E","A","B","C","A","B" },
                                                {"","","","","","" },
                                                {"","","","","","" } };

    string[,] lettersData10 = new string[5, 5] {{"R","R","M","R","E"},
                                               {"U","G","C","N","I"},
                                               {"R","A","D","O","A"},
                                               {"","","","",""},
                                               {"","","","",""}};

    private void Awake()
    {
        activeScene = SceneManager.GetActiveScene().buildIndex;
        dragObject = GetComponent<DragObject>();
        checking = true;
        instance = this;
    }

    void Start()
    {
        checkFirst = 0;
        checkSecond = 0;
        checkThird = 0;

        if (activeScene == 1)
        {
            for (int k = 0; k <= 3; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData[0, k];
            }
        }
        if (activeScene == 2)
        {
            for (int k = 0; k <= 4; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData2[0, k];
            }
        }
        if (activeScene == 3)
        {
            for (int k = 0; k <= 5; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData3[0, k];
            }
        }
        if (activeScene == 4)
        {
            for (int k = 0; k <= 3; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData4[0, k];
            }
            for (int k = 0; k <= 3; k++)
            {
                letters[k + 4].GetComponentInChildren<TextMeshPro>().text = lettersData4[1, k];
            }
        }
        if (activeScene == 5)
        {
            for (int k = 0; k <= 4; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData5[0, k];
            }
            for (int k = 0; k <= 3; k++)
            {
                letters[k + 5].GetComponentInChildren<TextMeshPro>().text = lettersData5[1, k];
            }
        }
        if (activeScene == 6)
        {
            for (int k = 0; k <= 4; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData6[0, k];
            }
            for (int k = 0; k <= 4; k++)
            {
                letters[k + 5].GetComponentInChildren<TextMeshPro>().text = lettersData6[1, k];
            }
        }
        if (activeScene == 7)
        {
            for (int k = 0; k <= 3; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData7[0, k];
            }
            for (int k = 0; k <= 3; k++)
            {
                letters[k + 4].GetComponentInChildren<TextMeshPro>().text = lettersData7[1, k];
            }
            for (int k = 0; k <= 3; k++)
            {
                letters[k + 8].GetComponentInChildren<TextMeshPro>().text = lettersData7[2, k];
            }
        }
        if (activeScene == 8)
        {
            for (int k = 0; k <= 5; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData8[0, k];
            }
            for (int k = 0; k <= 3; k++)
            {
                letters[k + 6].GetComponentInChildren<TextMeshPro>().text = lettersData8[1, k];
            }
        }
        if (activeScene == 9)
        {
            for (int k = 0; k <= 5; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData9[0, k];
            }
            for (int k = 0; k <= 5; k++)
            {
                letters[k + 6].GetComponentInChildren<TextMeshPro>().text = lettersData9[1, k];
            }
        }
        if (activeScene == 10)
        {
            for (int k = 0; k <= 4; k++)
            {
                letters[k].GetComponentInChildren<TextMeshPro>().text = lettersData10[0, k];
            }
            for (int k = 0; k <= 4; k++)
            {
                letters[k + 5].GetComponentInChildren<TextMeshPro>().text = lettersData10[1, k];
            }
            for (int k = 0; k <= 4; k++)
            {
                letters[k + 10].GetComponentInChildren<TextMeshPro>().text = lettersData10[2, k];
            }
        }
    }



    public void CheckVictory()
    {         
        for (int i = 0; i < letters.Length; i++)
        {
            TextMeshPro textLetter = letters[i].GetComponentInChildren<TextMeshPro>();
            DragObject _drag = letters[i].GetComponentInChildren<DragObject>();

            // Checagem da resposta da fase 1
            if (activeScene == 1)
            {
                if (textLetter.text == "T" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "T" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "U" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (checkFirst == 4)
                {
                    answers[0].color = Color.green;
                }
                if (checkFirst == 4)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 2
            if (activeScene == 2)
            {
                if (textLetter.text == "C" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "R" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "R" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "O" && checkFirst == 4)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (checkFirst == 5)
                {
                    answers[0].color = Color.green;
                }
                if (checkFirst == 5)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 3
            if (activeScene == 3)
            {
                if (textLetter.text == "D" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "E" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "R" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "I" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "V" && checkFirst == 4)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 5)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (checkFirst == 6)
                {
                    answers[0].color = Color.green;
                }
                if (checkFirst == 6)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 4
            if (activeScene == 4)
            {
                if (textLetter.text == "C" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "M" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "G" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "A" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "T" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "O" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (checkFirst == 4)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 4)
                {
                    answers[1].color = Color.green;
                }
                if (checkFirst == 4 && checkSecond == 4)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 5
            if (activeScene == 5)
            {
                if (textLetter.text == "C" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "P" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "L" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "I" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "V" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "R" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[8] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "O" && checkSecond == 4)
                {
                    if (_drag.target.gameObject == finalPositions[9] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (checkFirst == 4)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 5)
                {
                    answers[1].color = Color.green;
                }
                if (checkFirst == 4 && checkSecond == 5)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 6
            if (activeScene == 6)
            {
                if (textLetter.text == "T" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "E" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "M" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "P" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "O" && checkFirst == 4)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "I" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "D" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "E" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "I" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[8] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "A" && checkSecond == 4)
                {
                    if (_drag.target.gameObject == finalPositions[9] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (checkFirst == 5)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 5)
                {
                    answers[1].color = Color.green;
                }
                if (checkFirst == 5 && checkSecond == 5)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 7
            if (activeScene == 7)
            {
                if (textLetter.text == "V" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "I" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "D" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "M" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "O" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "R" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "A" && checkThird == 0)
                {
                    if (_drag.target.gameObject == finalPositions[8] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "R" && checkThird == 1)
                {
                    if (_drag.target.gameObject == finalPositions[9] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "T" && checkThird == 2)
                {
                    if (_drag.target.gameObject == finalPositions[10] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "E" && checkThird == 3)
                {
                    if (_drag.target.gameObject == finalPositions[11] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (checkFirst == 4)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 4)
                {
                    answers[1].color = Color.green;
                }
                if (checkThird == 4)
                {
                    answers[2].color = Color.green;
                }
                if (checkFirst == 4 && checkSecond == 4 && checkThird == 4)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 8
            if (activeScene == 8)
            {
                if (textLetter.text == "F" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "I" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "X" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "O" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "D" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "E" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "S" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[8] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "C" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[9] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "E" && checkSecond == 4)
                {
                    if (_drag.target.gameObject == finalPositions[10] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "R" && checkSecond == 5)
                {
                    if (_drag.target.gameObject == finalPositions[11] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (checkFirst == 4)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 6)
                {
                    answers[1].color = Color.green;
                }
                if (checkFirst == 4 && checkSecond == 6)
                {
                    Victory();
                }
            }

            // Checagem da resposta da fase 9
            if (activeScene == 9)
            {
                if (textLetter.text == "E" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "M" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "B" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "O" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "R" && checkFirst == 4)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "A" && checkFirst == 5)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "B" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "U" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "S" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[8] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "C" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[9] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "A" && checkSecond == 4)
                {
                    if (_drag.target.gameObject == finalPositions[10] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "R" && checkSecond == 5)
                {
                    if (_drag.target.gameObject == finalPositions[11] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (checkFirst == 6)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 6)
                {
                    answers[1].color = Color.green;
                }
                if (checkFirst == 6 && checkSecond == 6)
                {
                    Victory();
                }
            }                

            // Checagem da resposta da fase 10
            if (activeScene == 10)
            {
                if (textLetter.text == "M" && checkFirst == 0)
                {
                    if (_drag.target.gameObject == finalPositions[0] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "U" && checkFirst == 1)
                {
                    if (_drag.target.gameObject == finalPositions[1] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "N" && checkFirst == 2)
                {
                    if (_drag.target.gameObject == finalPositions[2] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "D" && checkFirst == 3)
                {
                    if (_drag.target.gameObject == finalPositions[3] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "O" && checkFirst == 4)
                {
                    if (_drag.target.gameObject == finalPositions[4] && _drag.targetLocked == true)
                    {
                        checkFirst++;
                    }
                }
                if (textLetter.text == "R" && checkSecond == 0)
                {
                    if (_drag.target.gameObject == finalPositions[5] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "E" && checkSecond == 1)
                {
                    if (_drag.target.gameObject == finalPositions[6] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "G" && checkSecond == 2)
                {
                    if (_drag.target.gameObject == finalPositions[7] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "R" && checkSecond == 3)
                {
                    if (_drag.target.gameObject == finalPositions[8] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "A" && checkSecond == 4)
                {
                    if (_drag.target.gameObject == finalPositions[9] && _drag.targetLocked == true)
                    {
                        checkSecond++;
                    }
                }
                if (textLetter.text == "C" && checkThird == 0)
                {
                    if (_drag.target.gameObject == finalPositions[10] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "R" && checkThird == 1)
                {
                    if (_drag.target.gameObject == finalPositions[11] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "I" && checkThird == 2)
                {
                    if (_drag.target.gameObject == finalPositions[12] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "A" && checkThird == 3)
                {
                    if (_drag.target.gameObject == finalPositions[13] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (textLetter.text == "R" && checkThird == 4)
                {
                    if (_drag.target.gameObject == finalPositions[14] && _drag.targetLocked == true)
                    {
                        checkThird++;
                    }
                }
                if (checkFirst == 5)
                {
                    answers[0].color = Color.green;
                }
                if (checkSecond == 5)
                {
                    answers[1].color = Color.green;
                }
                if (checkThird == 5)
                {
                    answers[2].color = Color.green;
                }
                if (checkFirst == 5 && checkSecond == 5 && checkThird == 5)
                {
                    Victory();
                }
            }            
        }

       
        Debug.Log(checkFirst);
        Debug.Log(checkSecond);
    }

    public void Victory()
    {
        victoryScreen.SetActive(true);
        SaveLevel();
    }

    public void SaveLevel()
    {
        if (activeScene == 1)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 2)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 3)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 4)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 5)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 6)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 7)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 8)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 9)
        {
            SaveSystem.SaveData(this);
        }
        if (activeScene == 10)
        {
            SaveSystem.SaveData(this);
        }
    }
}
