using UnityEngine;

namespace BING
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            // transform �������� Transform ����
            // Translate(x, y, z) �첾
            // * ���k
            // Time.delateTime �C�V���ɶ�
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
