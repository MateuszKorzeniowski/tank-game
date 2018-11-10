using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    private int nbPlayers;

    private void Start()
    {
        nbPlayers = PlayerPrefs.GetInt("nbPlayers");
    }


}
