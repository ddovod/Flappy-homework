using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollisionDector : MonoBehaviour {

    void OnCollisionEnter2D (Collision2D coll)
    {
        SceneManager.LoadScene (0);
    }
}
