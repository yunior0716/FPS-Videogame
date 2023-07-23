using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    public float health = 100f;
    public int pointsValue = 10; // A�adido - puntos que otorga el objeto al ser destruido

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameManager.Instance.AddPoints(pointsValue);  // A�adido - a�ade puntos al destruirse
            Destroy(gameObject);
        }
    }
}
