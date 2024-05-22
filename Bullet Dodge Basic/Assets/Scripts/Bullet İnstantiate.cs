using System.Collections;
using UnityEngine;

public class Bulletİnstantiate : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;
    float randomtime;
    float HighestTime = 4f;
    float LowestTime = 2f;
    private void Start()
    {
        StartCoroutine(ShootBullet());
    }

    private void Update()
    {
        Debug.Log(HighestTime + LowestTime);
    }              

    IEnumerator ShootBullet()
    {
        randomtime = Random.Range(LowestTime, HighestTime);
        yield return new WaitForSeconds(randomtime);

        if (LowestTime >= 0.6f)
            LowestTime -= 0.1f;

        if (HighestTime >= 1f)
            HighestTime -= 0.05f;
        Quaternion rotation = Quaternion.Euler(0, 0, 90); 
        Instantiate(BulletPrefab, transform.position, rotation);

        StartCoroutine(ShootBullet());
    }
}
