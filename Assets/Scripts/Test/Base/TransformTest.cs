using UnityEngine;

namespace Test.Base
{
    public class TransformTest : MonoBehaviour
    {
        private Transform _cube;
        private Transform _cube1;
        
        // Start is called before the first frame update
        void Start()
        {
            _cube = GameObject.Find("Cube").transform;
            _cube1 = GameObject.Find("Cube1").transform;
            foreach (Transform child in transform)
            {
                Debug.Log(child.position);
            }
            
            Debug.Log("eulerAngles:" + _cube1.eulerAngles);//与Unity编辑器中的rotation的x,y,z对应
            
            Debug.Log("position:" + _cube.position);//(4.0, 0.5, 8.0)，世界坐标
            Debug.Log("local position:" + _cube.localPosition);//(4.0, 0.0, 5.0)
            Debug.Log("parent position:" + _cube.parent.position);//(0.0, 0.5, 3.0)
            Debug.Log("transformPoint:" + _cube.TransformPoint(_cube.localPosition));//(8.0, 0.5, 13.0)
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
