using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{

  bool gameHasEnded = false;

  public float ok = 1f;

  public GameObject completeLevelUI;

  public void CompleteLevel ()
  {
    completeLevelUI.SetActive(true);
  }

  public void EndGame ()
  {
    if (gameHasEnded == false)
    {
        gameHasEnded = true;
        Debug.Log("ohno");
        Invoke( "Restart" , ok);
    }
}
     void Restart ()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
