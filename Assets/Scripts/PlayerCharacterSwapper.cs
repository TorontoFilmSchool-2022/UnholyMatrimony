using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterSwapper : MonoBehaviour
{
    public GameObject ModelUnity;
    public GameObject ModelScale;
    public GameObject ModelMannequin;

    public Avatar AvatarUnity;
    public Avatar AvatarScale;
    public Avatar AvatarMannequin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (ModelUnity.activeInHierarchy)
            {
                ModelUnity.SetActive(false);
                ModelScale.SetActive(true);

                other.GetComponent<Animator>().avatar = AvatarScale;
            }
            else if (ModelScale.activeInHierarchy)
            {
                ModelScale.SetActive(false);
                ModelMannequin.SetActive(true);

                other.GetComponent<Animator>().avatar = AvatarMannequin;
            }
            else if (ModelMannequin.activeInHierarchy)
            {
                ModelMannequin.SetActive(false);
                ModelUnity.SetActive(true);

                other.GetComponent<Animator>().avatar = AvatarUnity;
            }
        }
    }
}
