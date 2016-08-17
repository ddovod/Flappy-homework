using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{
    [SerializeField]
    private Vector2 force = Vector2.up; 

    private Rigidbody2D bird;

    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            bird.AddForce (force, ForceMode2D.Impulse);
        }
	}
}
