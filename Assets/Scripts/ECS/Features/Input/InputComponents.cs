using Unity.Entities;
using Unity.Mathematics;

namespace ECS.Features.Input
{
    public struct InputTag : IComponentData
    {
    }

    public struct MoveInputComponent : IComponentData
    {
        public float2 Vector;
    }

    public struct LookInputComponent : IComponentData
    {
        public float2 Vector;
    }

    public struct ControlsInputComponent : IComponentData
    {
        public bool Fire;
        public bool Jump;
    }
}