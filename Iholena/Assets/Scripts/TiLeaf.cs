using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ToDO:
// - clamp height
// - jerky movement
// - refactor code - generic move() method

public class TiLeaf : MonoBehaviour
{
   [SerializeField]
   private float _speed = 5.0f;
   private float _rightLimit = 14.5f;
   private float _leftLimit = -14.5f;
   private float _verticalLimit = -8.3f;

   void Update()
   {
      float _horizontalPos;
      float _verticalPos;

      _horizontalPos = Input.GetAxis("Horizontal");
      _verticalPos = Input.GetAxis("Vertical");
      Vector3 newPosition = new Vector3(_horizontalPos, _verticalPos, 0);

      transform.Translate(newPosition * _speed * Time.deltaTime);

      if (transform.position.x >= _rightLimit)
      {
         newPosition = new Vector3(_leftLimit, _verticalLimit, 0);
         transform.position = newPosition;
      }
      transform.Translate(Vector3.right * _speed * Time.deltaTime);

      if (transform.position.x <= _leftLimit)
      {
         newPosition = new Vector3(_rightLimit, _verticalLimit, 0);
         transform.position = newPosition;
      }
      transform.Translate(Vector3.left * _speed * Time.deltaTime);

      transform.rotation = Quaternion.identity;
   }
}
