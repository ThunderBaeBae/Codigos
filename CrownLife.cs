using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownLife : MonoBehaviour
{
    public int enemyLife;
    private Animator animator;
    public ScoreManager scoreManager;
    public int points;

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
            Destroy(gameObject, 0.3f);
        }
    }
}
