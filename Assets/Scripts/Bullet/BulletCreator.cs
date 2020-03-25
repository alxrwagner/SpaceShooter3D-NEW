using UnityEngine;

public class BulletCreator : CreateObject
{
    public float SpawnWait;
    public float StartWait;
    public Quaternion Rotation;
    public override GameObject Create()
    {
        var bullet = Instantiate(Prefab);
        bullet.transform.position = ObjectSpawn.transform.position;
        bullet.transform.rotation = Rotation;
        bullet.SetActive(false);

        return bullet;
    }

    private void Awake()
    {
        Rotation = Quaternion.Euler(90, 0, 0);
        ObjectSpawn = GameObject.Find("BulletSpawn");
        Prefab = Resources.Load<GameObject>("Prefabs/Bullet");
        ObjectSpawn = GameObject.Find("BulletSpawn");
    }
}
