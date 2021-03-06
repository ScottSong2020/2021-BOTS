using Godot;
using System;

public class Missile : SpaceProjectile, SpaceDamagable
{
    public bool Homing = false;
    public float Acceleration = 100f;
    public float RotationDeadband = 0.3f;
    public float RotationSpeed = 30f;
    public Node2D Target;

    public void Hit()
    {
        Destroyed = true;
        QueueFree();
    }

    public override void _PhysicsProcess(float delta)
    {

    }
}
