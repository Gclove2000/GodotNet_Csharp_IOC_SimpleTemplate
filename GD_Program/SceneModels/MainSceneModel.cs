using GD_Extension.Utils;
using GD_Program.Interfaces;
using GD_Program.Services;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD_Program.SceneModels
{
    public class MainSceneModel : ISceneModel
    {

        private TestService testService;

        private TestUtils testUtils = new TestUtils();
        public MainSceneModel(TestService testService)
        {
            this.testService = testService;
        }
        public override void Process(double delta)
        {

        }

        public override void Ready()
        {
            GD.Print("Hello Godot!");
            //在Ready中测试IOC
            testService.Test();
            testUtils.Test();
        }
    }
}
