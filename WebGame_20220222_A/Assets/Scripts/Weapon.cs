using UnityEngine;

namespace JASE
{
    /// <summary>
    /// �Z���G���[�b�Z���W
    /// </summary>
    public class Weapon : MonoBehaviour
    {
        [HideInInspector]
        public float attack;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "�ĤH")
            {
                collision.gameObject.GetComponent<HurtSystem>().GetHurt(attack);
            }
        }
    }
}
