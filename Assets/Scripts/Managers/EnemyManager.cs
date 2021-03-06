using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  public PlayerHealth playerHealth;
  public float spawnTime = 3f;
  public GameObject enemy;
  public Transform[] spawnPoints;


  void Start()
  {
    //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
    InvokeRepeating("Spawn", spawnTime, spawnTime);
  }

  void Spawn()
  {
    //Jika player telah mati maka tidak membuat enemy baru
    if (playerHealth.currentHealth <= 0f)
    {
      return;
    }

    //Mendapatkan nilai random
    int spawnPointIndex = Random.Range(0, spawnPoints.Length);
    int spawnEnemy = Random.Range(0, 3);

    Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    //Memduplikasi enemy
    // Factory.FactoryMethod(spawnEnemy);
  }
}