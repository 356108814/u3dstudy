using UnityEngine;

namespace CameraTest
{
    public class CameraCtrl : MonoBehaviour
    {
        private GameObject _cameraRig;
        private Transform _cameraTransform;
        private GameObject _player;
        
        // Start is called before the first frame update
        void Start()
        {
            _cameraRig = GameObject.Find("CameraRig");
            _cameraTransform = _cameraRig.transform;

            _player = GameObject.Find("Ellen");
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 targetPos = _cameraTransform.position + new Vector3(0, 1, 0);
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, targetPos, Time.deltaTime);
            _cameraTransform.LookAt(_player.transform.position);
        }
    }
}
