using UnityEngine;

namespace Playclapp
{
    [RequireComponent(typeof(Rigidbody),(typeof(BoxCollider)))]
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField]private Transform _path;
        [SerializeField]private Transform[] _point;

        private int _currentPoint;

        public float _speed;
        public float _timeDestroy = 1f;

        private void Start()
        {
            _point = new Transform[_path.childCount];

            for (int i = 0; i < _path.childCount; i++)
            {
                _point[i] = _path.GetChild(i);
            }
        }

        private void Update()
        {
            Transform target = _point[_currentPoint];

            transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);                               
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject,_timeDestroy);
        }
    }  
}