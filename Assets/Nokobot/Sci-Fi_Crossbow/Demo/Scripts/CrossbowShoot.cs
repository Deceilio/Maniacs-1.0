using UnityEngine;

namespace Nokobot.Assets.Crossbow
{
    public class CrossbowShoot : MonoBehaviour
    {
        public GameObject arrowPrefab;
        public Transform arrowLocation;

        public float shotPower = 100f;

        void Start()
        {
            if (arrowLocation == null)
                arrowLocation = transform;
        }

        void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                if (SaveScripts.inventoryOpen == false && SaveScripts.optionOpen == false)
                {
                    if (SaveScripts.arrows > 0)
                    {
                        Instantiate(arrowPrefab, arrowLocation.position, arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
                    }
                }
            }
        }
    }
}
