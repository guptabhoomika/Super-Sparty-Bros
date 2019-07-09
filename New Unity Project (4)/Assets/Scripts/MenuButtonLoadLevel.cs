using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // include so we can load new scenes

public class MenuButtonLoadLevel : MonoBehaviour {

	public void loadLevel(string levelToLoad)
	{
		SceneManager.LoadScene(levelToLoad);
	}
    public void retry(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void About(string about)
    {
        SceneManager.LoadScene(about);
    }
 
}
