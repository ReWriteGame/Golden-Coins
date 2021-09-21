using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerData spawnerData;

    public Transform spawnPosition;
    public bool playOnAwake = true;

    [SerializeField] Vector2Int numberOfSpawns;
    [SerializeField] Vector2 delay�etweenSpawns;



    private void Start()
    {
        if (playOnAwake)
            StartCoroutine(startSpawnCor());
    }

    public IEnumerator startSpawnCor()
    {
        for (int i = 0; i < Random.Range(numberOfSpawns.x, numberOfSpawns.y); i++)
        {
            yield return new WaitForSeconds(Random.Range(delay�etweenSpawns.x, delay�etweenSpawns.y));
            RandomSpawn();
        }

        yield break;
    }

    public void RandomSpawn()
    {
        Spawn(Random.Range(0, spawnerData.Prefabs.Count));
    }

    public void Spawn(int index)
    {
        if (index < 0) return;
        Instantiate(spawnerData.Prefabs[index], spawnPosition).transform.localPosition = Vector3.zero;
    }


    // � ��������� ������� 
    // ��������� ���-�� �� ���
    // ������ ��������� ����� �������� �������� ��������
    // ����� ����� 
    // ������������ ���������
    // ���� ��������� ������� ����� ��������
}
