
namespace Generation {
    public class CanyonGenerator : SimpleBaseGenerator
    {
        private const int COLOR_SAMPLING = 128;

        public CanyonGenerator(int? _seed = null) : base(_seed)
        {
            SeaLevel = 0;
        }

        public override void Run()
        {
            HeightOperations.AddNoise(map, 0.1f, 0.004f);
            HeightOperations.AddNoise(map, 0.2f, 0.01f);
            HeightOperations.AddNoise(map, 0.015f, 0.05f);
            HeightOperations.AddNoise(map, 0.005f, 0.1f);
            map.Normalize();
            HeightOperations.SimpleFlattenTopAndBottom(map);
        }

    }
}
