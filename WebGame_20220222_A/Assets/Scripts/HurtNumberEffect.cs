using UnityEngine;
using System.Collections;    // �ޥ�.�t��.���X(��Ƶ��c�A��P�{�ǡA����ɶ�)

namespace JASE
{
    /// <summary>
    /// ���˼ƭȮĪG
    /// �H�J�H�X�A��j�Y�p�A�첾
    /// </summary>
    public class HurtNumberEffect : MonoBehaviour
    {
        private CanvasGroup group;

        private void Start()
        {
            StartCoroutine(Test());
        }

        // ��P�{�Ǥ�k
        // �Ǧ^���������O IEnumerator
        private IEnumerator Test()
        {
            print("�ڬO�Ĥ@��");

            // ���B �Ƿ| ���ݬ��
            yield return new WaitForSeconds(2);

            print("�@���A�ڬO�ĤG��");
        }
    }
}
