using Unity.Entities;
using Unity.Mathematics;

namespace ECS.Features.Input
{
    public readonly partial struct InputAspect : IAspect
    {
        private readonly RefRO<InputTag> _tag;
        private readonly RefRW<MoveInputComponent> _move;
        private readonly RefRW<LookInputComponent> _look;
        private readonly RefRW<ControlsInputComponent> _controls;
        
        public float2 Move
        {
            get => _move.ValueRO.Vector;
            set => _move.ValueRW.Vector = value;
        }
        
        public float2 Look
        {
            get => _look.ValueRO.Vector;
            set => _look.ValueRW.Vector = value;
        }

        public bool Fire
        {
            get => _controls.ValueRO.Fire;
            set => _controls.ValueRW.Fire = value;
        }
        
        public bool Jump
        {
            get => _controls.ValueRO.Jump;
            set => _controls.ValueRW.Jump = value;
        }
    }
}