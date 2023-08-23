using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;

public class GameEnd : MonoBehaviour
{
    public GameObject YouWinText;
    public GameObject Player;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        YouWinText.SetActive(true);
        Time.timeScale = 0f;
        Destroy(Player);
    }
}
