using System.Collections;
using Data;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class ManagingScenes : MonoBehaviour
    {
        public void SetScene(int scene)
        {
            DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
            SetNextScene(scene);
        }

        public void SetPreviousScene()
        {
            print(DataInteraction.lastSaved);
            SceneManager.LoadScene(DataInteraction.lastSaved);
        }

        public void ShowStatistics()
        {
            DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(1);
        }

        public void SetNextLevel()
        {
            int nextScene = Random.Range(2, SceneManager.sceneCountInBuildSettings);
            while(nextScene == SceneManager.GetActiveScene().buildIndex)
            {
                nextScene = Random.Range(2, SceneManager.sceneCountInBuildSettings);
            }
            DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;

            StartCoroutine(MethodName());
            SetNextScene(nextScene);
            
            //альтернатива
            //SceneManager.LoadScene(Random.Range(2, SceneManager.sceneCount);
        }

        private void SetNextScene(int scene)
        {
            SceneManager.LoadScene(scene);
        }

        private IEnumerator MethodName()
        {
            yield return new WaitForSeconds(4);
        }
    }
}
