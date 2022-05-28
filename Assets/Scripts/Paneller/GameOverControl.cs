using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    [SerializeField] GameObject _background, _gameOverPanel, _spawner;

    private void FixedUpdate()
    {
        GameOver();
    }

    void GameOver()
    {
        if (_background.GetComponent<SpriteRenderer>().color == Color.red)
        {
            _gameOverPanel.SetActive(true);
            _spawner.GetComponent<SpawnSmallCircle>().enabled = false;
            
        }
    }

}
