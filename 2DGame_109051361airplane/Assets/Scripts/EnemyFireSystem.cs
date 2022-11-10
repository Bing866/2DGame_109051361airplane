using UnityEngine;

namespace BING
{
    /// <summary>
    /// �ĤH�o�g�t��
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("�ͦ��l�u���j"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            // �I�s��k
            //SpawnBullet();

            // ���𭫽ƩI�s("��k�W��"�A����ɶ��A�����W�v)
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}