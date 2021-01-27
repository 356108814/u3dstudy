using UnityEngine;

namespace CameraTest
{
    public class CameraFollow : MonoBehaviour
    {
        private float _disY = 4;
        private float _disZ = -8;
        private Transform _followTarget;
        private Vector3 _offset;

        private Vector3 _targetPos;
        private float _speed = 1;

        // Start is called before the first frame update
        void Start()
        {
            _followTarget = GameObject.FindWithTag("Player").transform;
            _offset = new Vector3(0, this._disY, this._disZ);
        }

        // Update is called once per frame
        void Update()
        {
            Quaternion rotation = Quaternion.Euler(0, _followTarget.eulerAngles.y, 0); //将玩家Y轴旋转转换为四元数（代表一个三维旋转）  
            //rotation * offset：四元数 *一个向量 = 将该向量转四元数代表的角度，即将该旋转应用到该向量，得到一个新的向量。体现为摄像机随着角色的旋转而左右旋转（但还没以角色为中心注视）  
            _targetPos = _followTarget.position + (rotation * _offset);
            transform.position = Vector3.Lerp(transform.position, _targetPos, Time.deltaTime * _speed);
            transform.LookAt(_followTarget);
        }
    }
}