using GD_Program;
using GD_Program.SceneModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godot.SceneScripts
{
    public partial class MainScene : Node2D
    {
        public MainSceneModel Model { get; set; }

        public MainScene()
        {
            Model = Program.Services.GetService<MainSceneModel>();
            Model.Sence = this;
            Model.SetPackedScene(nameof(MainScene));
        }
        public override void _Ready()
        {
            Model.Ready();
            base._Ready();
        }

        public override void _Process(double delta)
        {
            
            base._Process(delta);
        }
    }
}
