using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private Vector2 offset = Vector2.right;


    [SerializeField]
    private float vertOffset = 1;

	// Use this for initialization
	void Start () 
    {
        Create (transform.position + (Vector3)offset);
	}

    void HandleAction (TriggerEvent obj)
    {
        obj.Triggered -= HandleAction;
        Create (obj.transform.position + (Vector3)offset);
    }

    private void Create(Vector2 pos)
    {
        var obstacle = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
        obstacle.SetActive (true);
        var t = obstacle.GetComponent<TriggerEvent> ();
        t.Triggered += HandleAction;

        var off = Random.Range (-vertOffset, vertOffset);
    }
}
