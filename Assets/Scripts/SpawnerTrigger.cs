using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{

    public GameObject groundSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger"))
        {
            Instantiate(groundSection, other.transform.position + new Vector3(10, 0, 0), Quaternion.identity);
        }

        if(other.gameObject.CompareTag("DestroyTrigger"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}
