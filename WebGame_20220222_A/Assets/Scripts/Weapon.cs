using UnityEngine;

namespace JASE
{
    /// <summary>
    /// 武器：附加在武器上
    /// </summary>
    public class Weapon : MonoBehaviour
    {
        [HideInInspector]
        public float attack;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "敵人")
            {
                collision.gameObject.GetComponent<HurtSystem>().GetHurt(attack);
            }
        }
    }
}
