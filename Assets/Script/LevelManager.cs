using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FishHunter.LevelManager
{
    public class LevelManager : Singleton<LevelManager>
    {
        public string GameScene;

        public void PlayGame()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}

