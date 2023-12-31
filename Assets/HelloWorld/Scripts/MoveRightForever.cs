using UnityEngine;

namespace HelloWorld
{
    /// <summary>
    /// [class] 一个让物体无限向y的代码，用于测试脚本是否可以正常运行
    /// </summary>
    public class MoveRightForever : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            transform.Translate(0, 0.1f, 0);
        }
    }
}