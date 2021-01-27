using System;
using UnityEngine;

namespace Test.Base
{
    public class Vector3Test : MonoBehaviour
    {
        private Transform _boll;
        private Transform _capsule;
        private Transform _cube1;
        private Transform _cube2;

        // Start is called before the first frame update
        void Start()
        {
            _boll = transform.parent;
            _capsule = GameObject.Find("Capsule").transform;
            _cube1 = GameObject.Find("Cube1").transform;
            _cube2 = GameObject.Find("Cube2").transform;
            _capsule = GameObject.Find("Capsule").transform;

            TestAngle();
            // TestPosition();
            // TestDistance();
            // TestProject();
            // TestLerp();
            // TestSlerp();
            // TestMove();
            // TestRotate();
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void TestAngle()
        {
            Vector3 v1 = new Vector3(1, 0, 0);
            Vector3 v2 = new Vector3(1, 1, 1);
            Debug.Log("Angle：" + Vector3.Angle(v1, v2));
            Debug.Log("SignedAngle：" + Vector3.SignedAngle(v1, v2, Vector3.up));
        }

        private void TestPosition()
        {
            // 移动前：boll(0, 0.5, 3) Cube (0, 0, 5)
            transform.Translate(new Vector3(0, 0, 1), Space.Self);
            Debug.Log("localPosition:" + transform.localPosition); // (0, 0, 6)
            Debug.Log("position:" + transform.position); //(0, 0.5, 9)
        }

        private void TestDistance()
        {
            Debug.Log("Distance:" + Vector3.Distance(_cube1.position, _cube2.position));
        }

        private void TestProject()
        {
            Vector3 v3 = new Vector3(5, 3, 0);
            Debug.Log("Project right：" + Vector3.Project(v3, Vector3.right)); //(5, 0, 0)
            Debug.Log("Project left：" + Vector3.Project(v3, Vector3.left)); //(5, 0, 0)
            Debug.Log("Project forward：" + Vector3.Project(v3, Vector3.forward)); //(0, 0, 0)
        }

        private void TestLerp()
        {
            //Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t)
            Vector3 from = new Vector3(0, 0, 0);
            Vector3 to = new Vector3(10, 0, 0);
            Debug.Log(Vector3.Lerp(from, to, 1)); //(10, 0, 0)
            Debug.Log(Vector3.Lerp(from, to, 0.2f)); //(2, 0, 0)
        }

        private void TestSlerp()
        {
            Vector3 from = new Vector3(0, 0, 0);
            Vector3 to = new Vector3(3, 0, 0);
            Debug.Log(Vector3.Slerp(from, to, 1)); //(3, 0, 0)
            Debug.Log(Vector3.Slerp(from, to, 0.2f)); //(0.6, 0, 0)
        }

        private void TestMove()
        {
            Vector3 from = new Vector3(0, 0, 0);
            Vector3 to = new Vector3(0, 10, 0);
            Debug.Log(Vector3.MoveTowards(to, from, 0.1f));//(0, 9.9, 0)
        }

        private void TestRotate()
        {
            Vector3 from = new Vector3(0, 0, 0);
            Vector3 to = new Vector3(1, 1, 1);
            Debug.Log("RotateTowards:" + Vector3.RotateTowards(from, to, 0.1f, 0.2f));
        }
    }
}