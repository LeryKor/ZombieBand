using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerCharacter : MonoBehaviour
{
    private float _health = 100.0f;
    private int maxHealth = 150;
    
    public Slider slider;
    public void Hurt(int damage)
    {
        _health -= damage;
        slider.value = _health;
        if (_health <= 0)
        {
            SceneManager.LoadScene("Scene2D");
        }
        Debug.Log("Health: " + _health);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
