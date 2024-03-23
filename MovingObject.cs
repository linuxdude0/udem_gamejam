using Godot;
using System;

public partial class MovingObject : Node2D
{
	public Vector2 velocity = new Vector2(0,0);
	public double mass = 1;
	public Vector2 acceleration = new Vector2(0,0);
	public Vector2 current_velocity;

	// public MovingObject(Vector2 velocity, double mass) {
	// 	this.velocity = velocity;
	// 	this.mass = mass;
	// } 

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.set_velocity(new Vector2(1,1));
		this.apply_force(new Vector2(1,5));
		// this.apply_force(new Vector2(2,5));
	}

	public void apply_force(Vector2 force) {
		this.acceleration += force/(float)mass;
	}

	public void set_mass(double mass) {
		this.mass = mass;
	}

	public void set_velocity(Vector2 vel) {
		this.velocity = vel;
		this.current_velocity = this.velocity;
	}

	public void set_acceleration(Vector2 a) {
		this.acceleration = a;
	}

	public double get_mass() {
		return this.mass;
	}

	public Vector2 get_force_applied() {
		return this.acceleration*(float)this.mass;
	}

	public Vector2 get_current_velocity() {
		return this.current_velocity;
	}

	public Vector2 get_velocity() {
		return this.velocity;
	}

	public void elastic_collide(MovingObject object2) {
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		this.current_velocity += this.acceleration*(float)delta;
		Position+=this.current_velocity;
		GD.Print(this.acceleration);
	}
}
