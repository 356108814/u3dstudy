using UnityEngine;

namespace InputTest
{
    public class PlayerInput : MonoBehaviour
    {
        public string state = "idle";
        public float moveSpeed = 2;
        public float rotationSpeed = 10f;

        private Transform _playerTransform;
        private Transform _cameraTransform;
        private float _rotation;

        void Start()
        {
            _playerTransform = GameObject.Find("Dreamer").transform;
            _cameraTransform = Camera.main.transform;
        }

        // Update is called once per frame
        void Update()
        {
            _rotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
            _cameraTransform.Rotate(Vector3.up, _rotation);

            if (Input.GetKey(KeyCode.W))
            {
                state = "run";
                _playerTransform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
            }

            if (Input.GetKey(KeyCode.S))
            {
                state = "run";
                _playerTransform.Translate(Vector3.back * (moveSpeed * Time.deltaTime));
            }

            if (Input.GetKey(KeyCode.A))
            {
                state = "run";
                _playerTransform.Rotate(Vector3.up, _rotation);
                _playerTransform.Translate(Vector3.left * (moveSpeed * Time.deltaTime));
            }

            if (Input.GetKey(KeyCode.D))
            {
                state = "run";
                _playerTransform.Rotate(Vector3.up, _rotation);
                _playerTransform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
            }

            if (Input.GetKey(KeyCode.Space))
            {
                state = "attack";
            }

            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) ||
                Input.GetKeyUp(KeyCode.D))
            {
                state = "idle";
            }

            // if (Input.GetMouseButton(0))
            // {
            //     //需要碰撞到物体才可以
            //     var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //     RaycastHit hit;
            //     var isCollider = Physics.Raycast(ray, out hit);
            //     if (isCollider)
            //     {
            //         Debug.Log("射线检测到的点是" + hit.point);
            //         _playerTransform.Translate(hit.point);
            //     }
            // }

            // if (Input.GetMouseButtonUp(0))
            // {
            //     Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            //         Input.mousePosition.y,
            //         Camera.main.transform.position.z > 0
            //             ? Camera.main.transform.position.z
            //             : -Camera.main.transform.position.z)); //屏幕坐标转换世界坐标
            //
            //     Debug.Log("通过修改Z轴获取到的世界坐标是" + worldPos);
            //     // _playerTransform.Translate(worldPos, Space.World);
            //     _playerTransform.position = worldPos;
            // }
        }
    }
}