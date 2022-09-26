using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followpathmovement : MonoBehaviour
{
    [SerializeField] private List<Transform> _wayPoints = new List<Transform>();
    public string path = "";
    public float stoppingDistance = 0.2f;

    private int _currentWayPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        var path = GameObject.Find(this.path);
        for (int i = 0; i < path.transform.childCount; i++)
        {
            _wayPoints.Add(path.transform.GetChild(i));
        }
        StartCoroutine(MoveToWayPoints());
    }
    IEnumerator MoveToWayPoints()
    {
        var distance = Vector3.Distance(transform.position,
            _wayPoints[_currentWayPoint].position);
        while (Mathf.Abs(distance) > stoppingDistance)
        {

            float speed = 0;
            transform.position = Vector3.MoveTowards(transform.position,
                _wayPoints[_currentWayPoint].position,
                speed * Time.deltaTime);
            distance = Vector3.Distance(transform.position,
                _wayPoints[_currentWayPoint].position);
            yield return null;
        }
        if (_currentWayPoint < _wayPoints.Count - 1)
        {
            _currentWayPoint++;
            StartCoroutine(MoveToWayPoints());
        }

    }
    }
