using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class MenuBotton : MonoBehaviour
{
public int n;
      
    public void ChangeScene()
    {
        SceneManager.LoadScene(n);
    }
}
