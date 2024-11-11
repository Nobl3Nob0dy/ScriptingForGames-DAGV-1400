using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect1 : MonoBehaviour
{
    private ParticleSystem pSystem;
    
    public int firstCount = 10;
    public int secondCount = 20;
    public int thirdCount = 40;
    public float deleayBetween = 2.3f;
    
    // Start is called before the first frame update
    void Start()
    {
        pSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            StartCoroutine(EmiteParticleCoRoutine());
        }
    }

    private IEnumerator EmiteParticleCoRoutine()
    {
        pSystem.Emit(firstCount);
        yield return new WaitForSeconds(deleayBetween);
        
        pSystem.Emit(secondCount);
        yield return new WaitForSeconds(deleayBetween);
        
        pSystem.Emit(thirdCount);
    }
}
