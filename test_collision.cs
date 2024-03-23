using Godot;
using System;

public partial class test_collision : Node2D
{
	public MovingObject[] objs = new MovingObject[32];

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.objs[0] = new MovingObject();
		this.objs[1] = new MovingObject();
		this.objs[0].set_velocity(new Vector2(0.5f, 0.5f));
		this.objs[1].set_velocity(new Vector2(-0.5f, -0.5f));
		for(int i=0; i<this.objs.Length; i++) {
			if (this.objs[i] != null){
				var image = Image.LoadFromFile("res://icon.svg");
				Texture2D texture = ImageTexture.CreateFromImage(image);
				Sprite2D sprite = new Sprite2D();
				sprite.Texture = texture;
				this.objs[i].AddChild(sprite);
			}
		}
		this.objs[0].Position = new Vector2(0, 0);
		this.objs[1].Position = new Vector2(100, 100);
		this.AddChild(this.objs[0]);
		this.AddChild(this.objs[1]);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		for(int i=0; i<this.objs.Length; i++) {
			if (this.objs[i] != null){
				this.objs[i]._Process(delta);
			}
		}
	}
}
