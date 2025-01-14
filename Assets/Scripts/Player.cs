using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted; 

    private void Start () // runs at first frame, while update runs at everyframe 
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.W)) // wasd controls for player
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)) // "getkey" all prefabs, "getkeydown" one time prefab
        {
            if(_numSeedsLeft > 0)
            {
                PlantSeed();
            }
        }
    }

    public void PlantSeed ()
    {
       
        {
            GameObject plantsSpawned = Instantiate(_plantPrefab, transform.position, transform.rotation); // plant prefab spawns at game object's position and rotation
            _numSeedsLeft--; // takes away one from _numSeedsLeft
            _numSeedsPlanted++; // add ones to _unSeedsPlanted
            _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
        }
    }
}
