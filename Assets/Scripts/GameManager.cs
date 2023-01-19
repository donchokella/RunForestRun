using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // to use OrderBy

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private InGameRanking inGameRanking;

    private GameObject[] runners;
    List<RankingSystem> sortArray = new List<RankingSystem>();  //?


    private void Awake()
    {
        instance = this; //?
        runners = GameObject.FindGameObjectsWithTag("Runner"); //?
        inGameRanking = FindObjectOfType<InGameRanking>(); //?
    }

    private void Start()
    {
        for (int i = 0; i < runners.Length; i++)
        {
            sortArray.Add(runners[i].GetComponent<RankingSystem>()); //?
        }
    }

    void CalculateRank()
    {
        sortArray = sortArray.OrderBy(x => x.dist).ToList(); //? dist or distance
        sortArray[0].rank = 1;
        sortArray[1].rank = 2;
        sortArray[2].rank = 3;
        sortArray[3].rank = 4;
        sortArray[4].rank = 5;

        inGameRanking.a = sortArray[0].name;
        inGameRanking.b = sortArray[1].name;
        inGameRanking.c = sortArray[2].name;
        inGameRanking.d = sortArray[3].name;
        inGameRanking.e = sortArray[4].name;
    }

    private void Update()
    {
        CalculateRank();
    }
}
