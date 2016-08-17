using UnityEngine;
using System.Collections;

public class MoveToTarget : MonoBehaviour 
{
    [SerializeField]
    private Transform target;

	// Update is called once per frame
	private void LateUpdate()
    {
        var pos = transform.position;
        pos.x = target.position.x;
        transform.position = pos;
	}
}
