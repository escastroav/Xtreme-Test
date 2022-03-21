using UnityEngine;

public class SceneSwaper : MonoBehaviour
{
    [Tooltip("Utilizado par spawnear objetos persistentes.")]
    [SerializeField] GameObject persistentObject = null;
    [SerializeField] bool hasSpawned = false;
    private void Awake() {
        if(hasSpawned)
            return;
        
        SpawnPersistentObject();
        
        hasSpawned = true;
    }

    private void SpawnPersistentObject()
    {
        GameObject persistent = Instantiate(persistentObject);  
        DontDestroyOnLoad(persistent);
    }


}
