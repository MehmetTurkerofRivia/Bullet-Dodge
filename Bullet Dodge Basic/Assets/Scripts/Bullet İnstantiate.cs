using System.Collections;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;
    float randomtime;
    float HighestTime = 2f;
    float LowestTime = 1f;
    private void Start()
    {
        StartCoroutine(ShootBullet());
    }
    IEnumerator ShootBullet()
    {
        randomtime = Random.Range(LowestTime, HighestTime);          
        Quaternion rotation = Quaternion.Euler(0, 0, 90); 
        Instantiate(BulletPrefab, transform.position, rotation);
        yield return new WaitForSeconds(randomtime);
        if (LowestTime >=0.1f)
            LowestTime -= 0.02f;
        if (HighestTime >= 0.3f)
            HighestTime -= 0.01f;
        StartCoroutine(ShootBullet());
    }
}
