using ECS.Features.Character;
using Unity.Entities;

namespace ECS.Features.Player
{
    public readonly partial struct PlayerAspect : IAspect
    {
        private readonly RefRO<PlayerTag> _tag;
        private readonly CharacterAspect _character;
    }
}