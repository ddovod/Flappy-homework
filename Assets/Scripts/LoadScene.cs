using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour 
{
    public int index;

    public void Load()
    {
        SceneManager.LoadScene (index);
    }
}
