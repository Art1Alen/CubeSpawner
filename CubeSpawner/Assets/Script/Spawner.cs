using UnityEngine;

namespace Playclapp
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]private GameObject _template;
        [SerializeField]private float _timeSpawner = 0.0f;

        private void Start()
        {            
            InvokeRepeating("NewSpaw", _timeSpawner, _timeSpawner);
        }
        public void NewSpaw()
        {
           GameObject newObject = Instantiate(_template, new Vector3(0, 0.5f, 0), Quaternion.identity);
        }
    }
}
