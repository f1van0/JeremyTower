using Unity.Entities;

namespace ECS.Features.Camera
{
    public class CameraComponent : IComponentData
    {
        public UnityEngine.Camera Value;
    }

    public struct CameraTargetTag : IComponentData
    {
    }
}