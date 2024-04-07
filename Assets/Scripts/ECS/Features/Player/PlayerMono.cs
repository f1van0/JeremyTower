using ECS.Features.Camera;
using Unity.Entities;
using UnityEngine;

namespace ECS.Features.Player
{
    public class PlayerMono : MonoBehaviour
    {
    }

    public class PlayerMonoBaker : Baker<PlayerMono>
    {
        public override void Bake(PlayerMono authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<PlayerTag>(entity);
            AddComponent<CameraTargetTag>(entity);
        }
    }
}