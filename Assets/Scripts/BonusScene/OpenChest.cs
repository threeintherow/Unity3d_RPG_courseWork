using UnityEngine;

namespace BonusScene
{
    public class OpenChest : MonoBehaviour
    {

        public GameObject[] objects;

        private void OnMouseDown()
        {
            Destroy(gameObject);
            Instantiate(objects[0], objects[0].transform.position, objects[0].transform.rotation);
            Instantiate(objects[1], objects[1].transform.position, objects[1].transform.rotation);
        }
    }
}
