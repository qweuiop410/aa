using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    public GameObject pinPrefeb;
    public GameObject startPanel;

    public Text nullEnemyName;
    public Text inputEnemyName;
    public TextMesh enemyName;

    public bool pause = false;

    private void Start()
    {
        startPanel.SetActive(true);
        Time.timeScale = 0;
        pause = true;
    }
    
    void Update()
    {
        if (!pause)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpawnPin();
            }
        }
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1;
        pause = false;

        if (nullEnemyName.text == "stress")
        {
            enemyName.text = nullEnemyName.text;
        }
        else
        {
            enemyName.text = inputEnemyName.text;
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefeb, transform.position, transform.rotation);
    }

}
