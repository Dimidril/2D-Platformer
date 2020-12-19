using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Transform _path;

    private Transform[] _patrolPoints;
    private int _targetPointIndex = 0;

    private void Start()
    {
        _patrolPoints = new Transform[_path.childCount];

        for (int i = 0; i < _patrolPoints.Length; i++)
        {
            _patrolPoints[i] = _path.GetChild(i);
        }

        transform.position = _patrolPoints[_targetPointIndex].position;
    }

    private void Update()
    {
        Transform target = _patrolPoints[_targetPointIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        if (transform.position == target.position)
        {
            _targetPointIndex++;
            if (_targetPointIndex >= _patrolPoints.Length)
                _targetPointIndex = 0;
        }
    }
}