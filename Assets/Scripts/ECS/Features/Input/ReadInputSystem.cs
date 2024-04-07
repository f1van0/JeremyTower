using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace ECS.Features.Input
{
    [UpdateInGroup(typeof(SimulationSystemGroup), OrderFirst = true)]
    public partial class ReadInputSystem : SystemBase
    {
        protected override void OnCreate()
        {
            Entity entity = EntityManager.CreateEntity();
            EntityManager.AddComponent<InputTag>(entity);
            EntityManager.AddComponent<MoveInputComponent>(entity);
            EntityManager.AddComponent<LookInputComponent>(entity);
            EntityManager.AddComponent<ControlsInputComponent>(entity);
        }

        protected override void OnUpdate()
        {
            foreach (InputAspect inputAspect in SystemAPI.Query<InputAspect>())
            {
                Vector3 mousePosition = UnityEngine.Input.mousePosition;

                inputAspect.Fire = UnityEngine.Input.GetButton("Fire1");
                inputAspect.Jump = UnityEngine.Input.GetButton("Jump");
                inputAspect.Move = new float2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
                inputAspect.Look = new float2(mousePosition.x - Screen.width * 0.5f, mousePosition.y - Screen.height * 0.5f);
            }
        }
    }
}