using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    public void SpawnTarget()
    {
        Instantiate(targetPrefab, transform.position, Quaternion.identity);
    }

}
