//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MoveMeteor : MonoBehaviour
//{
//    //private Pool _pool;

//    [SerializeField]
//    private int _meteorCount;

//    public float SpawnWait;
//    public float StartWait;

//    private void Awake()
//    {
//        _pool = new Pool();
//    }
//    public void Move()
//    {
//        for (int i = 0; i < _pool.Objects.Count; i++)
//        {
//            _pool.Objects[i].transform.Translate(0f, _pool.Objects.Speed * Time.fixedDeltaTime, 0f);
//        }

//    }

//    IEnumerator MeteorWaves()
//    {
//        while (true)
//        {


//            yield return new WaitForSeconds(SpawnWait);

//            for (int i = 0; i < _meteorCount; i++)
//            {
//                Create();

//                yield return new WaitForSeconds(SpawnWait);
//            }
//        }
//    }

//    private void Start()
//    {
//        StartCoroutine(MeteorWaves());
//    }
//}
