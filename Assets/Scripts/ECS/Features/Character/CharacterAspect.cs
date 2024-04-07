using Unity.Entities;

namespace ECS.Features.Character
{
    public readonly partial struct CharacterAspect : IAspect
    {
        private readonly RefRO<CharacterTag> _tag;
    }
}