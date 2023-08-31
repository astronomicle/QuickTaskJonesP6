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
    public GameObject Sun;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        YouWinText.SetActive(true);
        Time.timeScale = 0f;
        Destroy(Player);
    }
}
