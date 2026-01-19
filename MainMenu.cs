using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame() //Pocinje igra
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Settings() //Odlaz u setting
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Izadji() //Iskljucuje igru
    {
        Application.Quit();
    }
    public void Vracanje() //Vraca u Main Menu
    {
        SceneManager.LoadSceneAsync(0);
    }
}

