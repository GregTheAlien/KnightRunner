using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region
    public static GameManager gm;

    void Awake()
    {
        if (!gm)
            gm = this;
        else
            Destroy(this);
    }
    #endregion

    [Header ("Game Data")]
    public float gameSpeed;

    [Header ("Player Info")]
    public GameObject player;

    [Header("UI Elements")]
    public Text scoreText;
    public Text highScoreText;
}
