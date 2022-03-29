using UnityEngine;

namespace JASE
{
    /// <summary>
    /// 武器系統
    /// 1. 儲存玩家擁有的武器資料
    /// 2. 根據武器資料生成武器
    /// 3. 賦予武器相關資料，飛行速度、攻擊力
    /// </summary>
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;

        /// <summary>
        /// 計時器
        /// </summary>
        private float timer;

        /// <summary>
        /// 繪製圖示
        /// 作用：在編輯器內 (Unity) 繪製各種圖形輔助開發
        /// 不會在執行檔內出現的
        /// </summary>
        private void OnDrawGizmos()
        {
            // 1. 圖示顏色
            // new Color(紅，綠，藍，透明度) 值 0 - 1
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            // 2. 繪製圖示
            // 圖示 的 繪製圖形(中心點，半徑)
            // transform.position + dataWeapon.v2SpawnPoint[0] 角色座標 + 生成位置
            // 目的：生成位置會根據角色位置作相對移動

            // for 迴圈
            // (初始值 ; 條件 ; 每一次迴圈結束執行區塊)
            for (int i = 0; i < dataWeapon.v2SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[i], 0.1f);
            }
        }

        private void Update()
        {
            SpawnWeapon();
        }

        /// <summary>
        /// 生成武器
        /// 每隔武器間隔時間就生成武器在生成位置上
        /// </summary>
        private void SpawnWeapon()
        {
            print("經過時間：" + timer);

            // 如果 計時器 大於等於 間隔時間
            if (timer >= dataWeapon.interval)
            {
                // 生成(物件)
                Instantiate(dataWeapon.goWeapon);
                // 計時器 歸零
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }
}
