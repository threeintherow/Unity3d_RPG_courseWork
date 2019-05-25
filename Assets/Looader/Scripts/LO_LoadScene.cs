using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LO_LoadScene : MonoBehaviour
{
	public void ChangeToScene (int scene)
	{		
		LO_LoadingScreen.LoadScene(scene);
	}
}
