using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullLife : MonoBehaviour
{
    public int enemyLife;
    public ScoreManager scoreManager;
    public int points;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void HurtEnemy()
    {
        enemyLife--;
        if (enemyLife <= 0)
        {
            scoreManager.AddScore(points);
            animator.SetTrigger("die");

            Destroy(gameObject, 0.5f);
        }
    }
}
