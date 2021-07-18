using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject howToMenu;
    public GameObject customizeMenu;
    public GameObject quitMenu;
    private int _currentScene;
    
    // Start is called before the first frame update
   
    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
