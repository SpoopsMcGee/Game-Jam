using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void NextScene(Level1)
    {
        Application.LoadLevel(Level1);
    }
}