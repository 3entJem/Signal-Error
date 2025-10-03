using UnityEngine;
using System.Windows;

public class JetPack : MonoBehaviour
{
    public GameObject JetParticles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        JetParticles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       OnKeyDownSpace();
    }

    public void OnKeyDownSpace()
    {
        if (e.KeyCode == KeyCode.Space)
        {
            JetParticles.SetActive(true);
        }
    }
}
