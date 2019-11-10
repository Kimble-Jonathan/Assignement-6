using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class playercontroller : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent Agent;
    public ThirdPersonCharacter character;

    void Start()
    {
        Agent.updateRotation = false;    
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                Agent.SetDestination(hit.point);
            }

            if (Agent.remainingDistance > Agent.stoppingDistance)
            {
                character.Move(Agent.desiredVelocity, false, false);
            }else
            {
                character.Move(Vector3.zero, false, false);
            }
        }
    }
}
