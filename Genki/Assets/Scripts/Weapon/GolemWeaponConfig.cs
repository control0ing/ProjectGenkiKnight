﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Genki.Control;

namespace Genki.Weapon
{
    public class GolemWeaponConfig : WeaponConfig
    {
        public override void GenerateBullet(IUnitControl owner, Vector2 position, Quaternion rotation, Vector2 direction)
        {
            var right = Vector2.Perpendicular(direction);
            var direction1 = direction + right * 2f;
            var direction2 = direction * bulletForce;
            var direction3 = direction * bulletForce - right * 2f;

            GenerateOneBullet(owner, position, rotation, direction1);
            GenerateOneBullet(owner, position, rotation, direction2);
            GenerateOneBullet(owner, position, rotation, direction3);
        }
    }
}

