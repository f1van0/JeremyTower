using Unity.Entities;
using UnityEngine;

namespace ECS.Features.Character
{
    public class CharacterMono : MonoBehaviour
    {
        public int test;
    }
    public class CharacterMonoBaker : Baker<CharacterMono>
    {
        public override void Bake(CharacterMono authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<CharacterTag>(entity);
        }
    }
}