using UnityEngine;
using System.Collections.Generic;

public class Game : MonoBehaviour {

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private Vector2 offset = Vector2.right;


    [SerializeField]
    private float vertOffset = 1;

    private IList<GameObject> obstacles;

    [SerializeField]
    private float speed;

    private float horOffset = 4;
    
    // Use this for initialization
    void Start () 
    {
        Create (transform.position + (Vector3)offset);
    }

    private void Create(Vector2 pos)
    {
        obstacles = new List<GameObject>();
        while (obstacles.Count < 5) {
            var obs = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
            obs.SetActive (true);
            setPipeVertPos(obs);
            obs.transform.Translate(Vector2.right * obstacles.Count * horOffset);
            obstacles.Add(obs);
        }
    }

    private void Update()
    {
        foreach (var obs in obstacles) {
            obs.transform.Translate (Vector2.left * speed * Time.deltaTime);
            if (obs.transform.position.x < -5) {
                setPipeVertPos(obs);
                obs.transform.Translate(Vector2.right * horOffset * obstacles.Count);
            }
        }
    }

    private void setPipeVertPos(GameObject pipe)
    {
        var vOffset = Random.Range(-2.0f, 2.0f);
        var tubeUp = pipe.transform.Find("tube_up");
        var tubeDown = pipe.transform.Find("tube_down");
        var oldTubeUpPos = tubeUp.position;
        var oldTubeDownPos = tubeDown.position;
        oldTubeUpPos.y = 4 + vOffset;
        oldTubeDownPos.y = -4 + vOffset;
        tubeUp.position = new Vector3(oldTubeUpPos.x, oldTubeUpPos.y, oldTubeUpPos.z);
        tubeDown.position = new Vector3(oldTubeDownPos.x, oldTubeDownPos.y, oldTubeDownPos.z);
    }
}
