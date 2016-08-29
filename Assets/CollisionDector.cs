using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionDector : MonoBehaviour {

    [SerializeField]
    private Text textField;

    private int currentScore = 0;
    
    void OnCollisionEnter2D (Collision2D coll)
    {
        SceneManager.LoadScene (0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.StartsWith("obstacle", System.StringComparison.CurrentCulture)) {
            currentScore += 1;
            textField.text = System.Convert.ToString(currentScore);
        }
    }
}


