using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fastory.Helper;

namespace Fastory.Helpers
{
    public class CleansingTheWorldFrom : MonoBehaviour
    {
        public string tagObjForDestroy;
        private void Start()
        {
            if (tagObjForDestroy == string.Empty || tagObjForDestroy == null)
            {
                tagObjForDestroy = Tag.Food;
            }

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(tagObjForDestroy))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

