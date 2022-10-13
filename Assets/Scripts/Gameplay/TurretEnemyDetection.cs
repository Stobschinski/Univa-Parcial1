using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretEnemyDetection : MonoBehaviour
{
    private GameObject _detectedEnemy = null;
    [SerializeField] private Transform _turrentPivot = null;

    public Vector3 Vector3 { get; private set; }

    private void Update()
    {
        if (_detectedEnemy == null) return;

        var direction:Vector3 = _detectedEnemy.transform.position - transform.parent.position;
        
        var targetRotation:Quaternion = Quaternion.LookRotation(forward: direction,
            upwards: Vector3.up);
        _turrentPivot.rotation = targetRotation;
        var distance:float = Vector3.Distance(a: _detectedEnemy.transform.position, b: transform.parent.position);

        if (Mathf.Abs(distance) > _maxDistance)
        {
            _detectedEnemy = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy") && _detectedEnemy == null)
        {
            _detectedEnemy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy") && _detectedEnemy == other.gameObject)
        {
            _detectedEnemy = null;
        }
    }

}
