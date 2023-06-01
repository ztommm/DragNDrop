using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importé, lai varétu veikt ainu ieládi
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour
{
    public void UzSakumu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        Time.timeScale = 1;
    }
   

    public void Apturet()
    {
        Application.Quit();
        Time.timeScale = 0;
    }

}
