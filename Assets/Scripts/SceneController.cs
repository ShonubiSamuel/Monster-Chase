using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   
    public void Restart()
  {
    //SceneManager.LoadScene("Gameplay");  or
    
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void Home()
  {
    SceneManager.LoadScene("Main Menu");
  }

}
