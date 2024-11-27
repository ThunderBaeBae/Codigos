using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public int playerLifes;
    public TextMeshProUGUI playerText;
    public GameObject playerPrefab;
    public GameObject gameOverPanel;

    public void CreateANewPlayer()
    {
        if (playerLifes >= 1)
        {
            playerLifes--;
            playerText.text = "Vida:" + playerLifes;

            Instantiate(playerPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            gameOverPanel.SetActive(true);

        }
  
    
    
    
    }


}
